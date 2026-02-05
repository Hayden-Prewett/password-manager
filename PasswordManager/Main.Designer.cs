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
            loginsDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)loginsDataGrid).BeginInit();
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
            lblPasswordManagerTitle.Location = new Point(177, 19);
            lblPasswordManagerTitle.Name = "lblPasswordManagerTitle";
            lblPasswordManagerTitle.Size = new Size(226, 35);
            lblPasswordManagerTitle.TabIndex = 4;
            lblPasswordManagerTitle.Text = "Password Manager";
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(365, 402);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(202, 36);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // loginsDataGrid
            // 
            loginsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            loginsDataGrid.Location = new Point(12, 68);
            loginsDataGrid.Name = "loginsDataGrid";
            loginsDataGrid.RowHeadersWidth = 51;
            loginsDataGrid.Size = new Size(555, 303);
            loginsDataGrid.TabIndex = 8;
            loginsDataGrid.CellContentClick += loginsDataGrid_CellContentClick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 450);
            Controls.Add(loginsDataGrid);
            Controls.Add(btnQuit);
            Controls.Add(lblPasswordManagerTitle);
            Controls.Add(btnAddPassword);
            Name = "Main";
            Text = "Password Manager";
            ((System.ComponentModel.ISupportInitialize)loginsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddPassword;
        private Label lblPasswordManagerTitle;
        private Button btnQuit;
        private DataGridView loginsDataGrid;
    }
}
