using System;
using System.Xml.Linq;
using System.IO.Ports;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace SwimV6Launcher
{
    public partial class Launcher : Form
    {
        static string configPath = @"C:\SEIKO\SwimV6\swim.config";
        static string exePath = @"C:\SEIKO\SwimV6\SwMain.exe";
        public Launcher()
        {
            InitializeComponent();
            string defaultServer = GetCurrentServerName();
            this.textBoxServer.Text = defaultServer;
            AddCmbBox();
        }
        private void AddCmbBox()
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBoxComPort.Items.Add(s);
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            // Update server and password from UI
            ChangeServer(this.textBoxServer.Text, this.textBoxPassword.Text);

            if (this.checkBoxOnline.Checked)
            {
                EnableOnline();

                string? portName = this.comboBoxComPort.SelectedItem?.ToString();
                if (portName == null)
                {
                    MessageBox.Show("COMポートを選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ChangePortName(portName);
            }
            if (checkBoxParaMode.Checked)
            {
                EnableParaMode();
            }
            else
            {
                DisableParaMode();
            }
            // run swimv6
            startSwimV6();
        }
        static void startSwimV6()
        {
            try
            {

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = exePath,
                    WorkingDirectory = @"C:\SEIKO\SwimV6\", // 推奨：実行フォルダ指定
                    UseShellExecute = true
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("起動失敗: " + ex.Message);
            }
        }
        static void ChangePortName(string portName)
        {
            string ComNo = portName.Replace("COM", ""); // "COM3" → "3"
            XDocument xml = XDocument.Load(configPath);
            // Build Port value
            xml.Root.Element("Online")
                    .Element("Port")
                    .Value = ComNo;
            xml.Save(configPath);
        }
        static void EnableOnline()
        {
            XDocument xml = XDocument.Load(configPath);
            // Online → UseFlg を 1 に変更
            xml.Root.Element("Online")
                    .Element("UseFlg")
                    .Value = "1";
            xml.Save(configPath);
        }
        static void ChangeServer(string newHost, string password)
        {
            XDocument xml = XDocument.Load(configPath);

            // Build Net value and insert password between "Password=" and ";"
            // Keep existing structure but replace Password value
            string netValue = $"Server={newHost}\\SQLEXPRESS;User ID=Sw;Password={password};Database=Sw";

            xml.Root.Element("Db")
                    .Element("Connect")
                    .Element("Net")
                    .Value = netValue;

            xml.Root.Element("Db")
                    .Element("Connect")
                    .Element("SvName")
                    .Value = newHost;

            xml.Save(configPath);
        }
        static void EnableParaMode()
        {


            XDocument xml = XDocument.Load(configPath);

            // Paralympics → DisplayFlg を 1 に変更
            xml.Root.Element("Op")
                    .Element("Paralympics")
                    .Element("DisplayFlg")
                    .Value = "1";

            xml.Save(configPath);

        }
        static void DisableParaMode()
        {


            XDocument xml = XDocument.Load(configPath);

            // Paralympics → DisplayFlg を 1 に変更
            xml.Root.Element("Op")
                    .Element("Paralympics")
                    .Element("DisplayFlg")
                    .Value = "0";

            xml.Save(configPath);

        }
        static string GetCurrentServerName()
        {
            try
            {
                XDocument xml = XDocument.Load(configPath);

                string netValue = xml.Root.Element("Db")
                                          .Element("Connect")
                                          .Element("Net")
                                          .Value;

                // 例: "Server=server\SQLEXPRESS;User ID=Sw;Password=;Database=Sw"
                // 正規表現で Server= と \SQLEXPRESS の間を抜き取る
                var match = Regex.Match(netValue, @"Server=([^\\;]+)");
                if (match.Success)
                {
                    return match.Groups[1].Value;
                }
                else
                {
                    // fallback
                    return xml.Root.Element("Db")
                                   .Element("Connect")
                                   .Element("SvName")
                                   .Value;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("サーバー名取得失敗: " + ex.Message);
                return "server"; // fallback
            }
        }

    }

}
