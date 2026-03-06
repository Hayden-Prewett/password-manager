using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class LoginInfo : Form
    {
        public LoginInfo() // the login information and options for one specific login when selected
        {
            InitializeComponent();
        }

        public void ShowLoginInfo(string website, string username, string password)
        {
            // display the login information for a given website
            lblWebsite.Text = $"Website: {website}";
            lblUsername.Text = $"Username: {username}";
            lblPassword.Text = $"Password: {password}";

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // close application
            System.Windows.Forms.Application.Exit();
        }

        private void btnEditLogin_Click(object sender, EventArgs e)
        {
            // Allow the user to edit the login
        }

        private void btnDeleteLogin_Click(object sender, EventArgs e)
        {
            // Ask for confirmation, then delete the record from the data base
        }
    }
}
