namespace PasswordManager
{
    partial class ChangePassword
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
            this.txtNewPassword = new TextBox();
            txtConfirmNewPassword = new TextBox();
            lblCurrentPassword = new Label();
            lblNewPassword = new Label();
            lblConfirmNewPassword = new Label();
            btnApply = new Button();
            SuspendLayout();
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new Point(181, 73);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new Size(199, 27);
            this.txtNewPassword.TabIndex = 0;
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Location = new Point(181, 122);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Size = new Size(199, 27);
            txtConfirmNewPassword.TabIndex = 1;
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Location = new Point(12, 26);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(127, 20);
            lblCurrentPassword.TabIndex = 2;
            lblCurrentPassword.Text = "Current password:";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(12, 76);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(109, 20);
            lblNewPassword.TabIndex = 3;
            lblNewPassword.Text = "New password:";
            // 
            // lblConfirmNewPassword
            // 
            lblConfirmNewPassword.AutoSize = true;
            lblConfirmNewPassword.Location = new Point(12, 125);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Size = new Size(163, 20);
            lblConfirmNewPassword.TabIndex = 4;
            lblConfirmNewPassword.Text = "Confirm new password:";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(217, 190);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(163, 29);
            btnApply.TabIndex = 5;
            btnApply.Text = "Apply changes";
            btnApply.UseVisualStyleBackColor = true;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 231);
            Controls.Add(btnApply);
            Controls.Add(lblConfirmNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(lblCurrentPassword);
            Controls.Add(txtConfirmNewPassword);
            Controls.Add(this.txtNewPassword);
            Name = "ChangePassword";
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewPassword;
        private TextBox txtConfirmNewPassword;
        private Label lblCurrentPassword;
        private Label lblNewPassword;
        private Label lblConfirmNewPassword;
        private Button btnApply;
    }
}