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

        public void ShowLoginInfo(string website)
        {
            lblTest.Text = website;
        }

        private void btnRemovePassword_Click(object sender, EventArgs e)
        {
            // open 'are you sure' message then remove password
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // show the ChangePassword window
            var ChangePassword = new ChangePassword();
            ChangePassword.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // close application
            System.Windows.Forms.Application.Exit();
        }
    }
}
