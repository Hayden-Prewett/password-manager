namespace PasswordManager
{
    partial class Main
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
            btnAddPassword = new Button();
            lblPasswordManagerTitle = new Label();
            btnQuit = new Button();
            dgvLogins = new DataGridView();
            lblMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLogins).BeginInit();
            SuspendLayout();
            // 
            // btnAddPassword
            // 
            btnAddPassword.Location = new Point(12, 402);
            btnAddPassword.Name = "btnAddPassword";
            btnAddPassword.Size = new Size(202, 36);
            btnAddPassword.TabIndex = 0;
            btnAddPassword.Text = "Add a password";
            btnAddPassword.UseVisualStyleBackColor = true;
            btnAddPassword.Click += btnAddPassword_Click;
            // 
            // lblPasswordManagerTitle
            // 
            lblPasswordManagerTitle.AutoSize = true;
            lblPasswordManagerTitle.Font = new Font("Segoe UI", 15F);
            lblPasswordManagerTitle.Location = new Point(145, 9);
            lblPasswordManagerTitle.Name = "lblPasswordManagerTitle";
            lblPasswordManagerTitle.Size = new Size(226, 35);
            lblPasswordManagerTitle.TabIndex = 4;
            lblPasswordManagerTitle.Text = "Password Manager";
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(316, 402);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(202, 36);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // dgvLogins
            // 
            dgvLogins.AllowUserToAddRows = false;
            dgvLogins.AllowUserToDeleteRows = false;
            dgvLogins.BackgroundColor = SystemColors.Control;
            dgvLogins.BorderStyle = BorderStyle.None;
            dgvLogins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogins.Cursor = Cursors.Hand;
            dgvLogins.Location = new Point(24, 57);
            dgvLogins.Name = "dgvLogins";
            dgvLogins.ReadOnly = true;
            dgvLogins.RowHeadersWidth = 51;
            dgvLogins.Size = new Size(484, 303);
            dgvLogins.TabIndex = 8;
            dgvLogins.CellClick += dgvLogins_CellClick;
            dgvLogins.CellFormatting += dgvLogins_CellFormatting;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(122, 363);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(268, 20);
            lblMessage.TabIndex = 9;
            lblMessage.Text = "Click a password to view, delete or edit";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 450);
            Controls.Add(lblMessage);
            Controls.Add(dgvLogins);
            Controls.Add(btnQuit);
            Controls.Add(lblPasswordManagerTitle);
            Controls.Add(btnAddPassword);
            Name = "Main";
            Text = "Password Manager";
            ((System.ComponentModel.ISupportInitialize)dgvLogins).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddPassword;
        private Label lblPasswordManagerTitle;
        private Button btnQuit;
        private DataGridView dgvLogins;
        private Label lblMessage;
    }
}
