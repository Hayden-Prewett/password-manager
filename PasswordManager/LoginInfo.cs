using System;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class LoginInfo : Form
    {
        // class variables to store website, username and password
        private readonly string _website;
        private readonly string _username;
        private readonly string _password;

        public LoginInfo(string website, string username, string password)
        {
            InitializeComponent();
            // assign website, username and password class variables
            _website = website;
            _username = username;
            _password = password;

            // display the login info to the user
            ShowLoginInfo(_website, _username, _password);
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
            // close form
            this.Close();
        }

        private void btnEditLogin_Click(object sender, EventArgs e)
        {
            // Show the ChangePassword form and
            // pass the stored website/username/password
            var changePassword = new ChangePassword(_website, _username, _password);
            changePassword.Show();
        }

        private void btnDeleteLogin_Click(object sender, EventArgs e)
        {
            // Ask for confirmation, then delete the record from the data base
        }
    }
}
