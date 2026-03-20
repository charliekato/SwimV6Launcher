namespace SwimV6Launcher
{
    partial class Launcher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelServer = new Label();
            textBoxServer = new TextBox();
            checkBoxParaMode = new CheckBox();
            buttonRun = new Button();
            textBoxPassword = new TextBox();
            label1 = new Label();
            checkBoxOnline = new CheckBox();
            labelPort = new Label();
            comboBoxComPort = new ComboBox();
            SuspendLayout();
            // 
            // labelServer
            // 
            labelServer.AutoSize = true;
            labelServer.Location = new Point(53, 27);
            labelServer.Name = "labelServer";
            labelServer.Size = new Size(108, 25);
            labelServer.TabIndex = 0;
            labelServer.Text = "ServerName";
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(193, 24);
            textBoxServer.Margin = new Padding(3, 4, 3, 4);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(305, 31);
            textBoxServer.TabIndex = 1;
            // 
            // checkBoxParaMode
            // 
            checkBoxParaMode.AutoSize = true;
            checkBoxParaMode.Location = new Point(108, 242);
            checkBoxParaMode.Margin = new Padding(3, 4, 3, 4);
            checkBoxParaMode.Name = "checkBoxParaMode";
            checkBoxParaMode.Size = new Size(142, 29);
            checkBoxParaMode.TabIndex = 2;
            checkBoxParaMode.Text = "障がい者モード";
            checkBoxParaMode.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(250, 314);
            buttonRun.Margin = new Padding(3, 4, 3, 4);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(101, 56);
            buttonRun.TabIndex = 3;
            buttonRun.Text = "Run";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(193, 74);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(305, 31);
            textBoxPassword.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 77);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 4;
            label1.Text = "Password";
            // 
            // checkBoxOnline
            // 
            checkBoxOnline.AutoSize = true;
            checkBoxOnline.Location = new Point(108, 152);
            checkBoxOnline.Margin = new Padding(3, 4, 3, 4);
            checkBoxOnline.Name = "checkBoxOnline";
            checkBoxOnline.Size = new Size(89, 29);
            checkBoxOnline.TabIndex = 6;
            checkBoxOnline.Text = "Online";
            checkBoxOnline.UseVisualStyleBackColor = true;
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Location = new Point(250, 153);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(45, 25);
            labelPort.TabIndex = 7;
            labelPort.Text = "Port";
            // 
            // comboBoxComPort
            // 
            comboBoxComPort.FormattingEnabled = true;
            comboBoxComPort.Location = new Point(316, 150);
            comboBoxComPort.Name = "comboBoxComPort";
            comboBoxComPort.Size = new Size(163, 33);
            comboBoxComPort.TabIndex = 8;
            // 
            // Launcher
            // 
            AcceptButton = buttonRun;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 436);
            Controls.Add(comboBoxComPort);
            Controls.Add(labelPort);
            Controls.Add(checkBoxOnline);
            Controls.Add(textBoxPassword);
            Controls.Add(label1);
            Controls.Add(buttonRun);
            Controls.Add(checkBoxParaMode);
            Controls.Add(textBoxServer);
            Controls.Add(labelServer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Launcher";
            Text = "SwimV6Launcher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelServer;
        private TextBox textBoxServer;
        private CheckBox checkBoxParaMode;
        private Button buttonRun;
        private TextBox textBoxPassword;
        private Label label1;
        private CheckBox checkBoxOnline;
        private Label labelPort;
        private ComboBox comboBoxComPort;
    }
}
