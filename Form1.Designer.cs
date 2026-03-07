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
            SuspendLayout();
            // 
            // labelServer
            // 
            labelServer.AutoSize = true;
            labelServer.Location = new Point(48, 23);
            labelServer.Name = "labelServer";
            labelServer.Size = new Size(97, 21);
            labelServer.TabIndex = 0;
            labelServer.Text = "ServerName";
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(174, 20);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(275, 29);
            textBoxServer.TabIndex = 1;
            // 
            // checkBoxParaMode
            // 
            checkBoxParaMode.AutoSize = true;
            checkBoxParaMode.Location = new Point(101, 118);
            checkBoxParaMode.Name = "checkBoxParaMode";
            checkBoxParaMode.Size = new Size(123, 25);
            checkBoxParaMode.TabIndex = 2;
            checkBoxParaMode.Text = "障がい者モード";
            checkBoxParaMode.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(219, 171);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(91, 47);
            buttonRun.TabIndex = 3;
            buttonRun.Text = "Run";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(174, 62);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(275, 29);
            textBoxPassword.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 65);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 4;
            label1.Text = "Password";
            // 
            // Launcher
            // 
            AcceptButton = buttonRun;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 271);
            Controls.Add(textBoxPassword);
            Controls.Add(label1);
            Controls.Add(buttonRun);
            Controls.Add(checkBoxParaMode);
            Controls.Add(textBoxServer);
            Controls.Add(labelServer);
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
    }
}
