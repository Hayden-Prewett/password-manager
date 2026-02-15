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
            btnEditLogin = new Button();
            btnQuit = new Button();
            lblWebsite = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            btnDeleteLogin = new Button();
            SuspendLayout();
            // 
            // btnEditLogin
            // 
            btnEditLogin.Location = new Point(12, 180);
            btnEditLogin.Name = "btnEditLogin";
            btnEditLogin.Size = new Size(383, 36);
            btnEditLogin.TabIndex = 4;
            btnEditLogin.Text = "Edit this login";
            btnEditLogin.UseVisualStyleBackColor = true;
            btnEditLogin.Click += btnEditLogin_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(224, 326);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(171, 36);
            btnQuit.TabIndex = 6;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblWebsite
            // 
            lblWebsite.AutoSize = true;
            lblWebsite.Location = new Point(48, 35);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(62, 20);
            lblWebsite.TabIndex = 7;
            lblWebsite.Text = "Website";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(48, 86);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(48, 135);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password";
            // 
            // btnDeleteLogin
            // 
            btnDeleteLogin.Location = new Point(12, 245);
            btnDeleteLogin.Name = "btnDeleteLogin";
            btnDeleteLogin.Size = new Size(383, 36);
            btnDeleteLogin.TabIndex = 10;
            btnDeleteLogin.Text = "Delete this login";
            btnDeleteLogin.UseVisualStyleBackColor = true;
            btnDeleteLogin.Click += btnDeleteLogin_Click;
            // 
            // LoginInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 374);
            Controls.Add(btnDeleteLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblWebsite);
            Controls.Add(btnQuit);
            Controls.Add(btnEditLogin);
            Name = "LoginInfo";
            Text = "LoginInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemovePassword;
        private Button btnEditLogin;
        private Button btnQuit;
        private Label lblWebsite;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnDeleteLogin;
    }
}