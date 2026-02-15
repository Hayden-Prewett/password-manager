namespace PasswordManager
{
    partial class LoginInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRemovePassword = new Button();
            btnChangePassword = new Button();
            btnQuit = new Button();
            lblTest = new Label();
            SuspendLayout();
            // 
            // btnRemovePassword
            // 
            btnRemovePassword.Location = new Point(272, 388);
            btnRemovePassword.Name = "btnRemovePassword";
            btnRemovePassword.Size = new Size(236, 36);
            btnRemovePassword.TabIndex = 5;
            btnRemovePassword.Text = "Remove this password";
            btnRemovePassword.UseVisualStyleBackColor = true;
            btnRemovePassword.Click += btnRemovePassword_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(12, 388);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(236, 36);
            btnChangePassword.TabIndex = 4;
            btnChangePassword.Text = "Change this password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(537, 388);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(236, 36);
            btnQuit.TabIndex = 6;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Location = new Point(498, 151);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(33, 20);
            lblTest.TabIndex = 7;
            lblTest.Text = "test";
            // 
            // LoginInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTest);
            Controls.Add(btnQuit);
            Controls.Add(btnRemovePassword);
            Controls.Add(btnChangePassword);
            Name = "LoginInfo";
            Text = "LoginInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemovePassword;
        private Button btnChangePassword;
        private Button btnQuit;
        private Label lblTest;
    }
}