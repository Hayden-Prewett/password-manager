using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class AddPassword : Form
    {
        public AddPassword()
        {
            InitializeComponent();
        }

        private void btnApplyAddPassword_Click(object sender, EventArgs e)
        {
            // take the inputs into variables
            string website = txtWebsite.Text;
            string username = txtUsernameInput.Text;
            string password = txtPassword.Text;

            // add to the file
            // encryption will be added later
            string filePath = @"..\..\..\testDB.csv";

            
            StreamWriter streamWriter = new StreamWriter(filePath,true);
            streamWriter.WriteLine($"{website},{username},{password}"); // add line to the file
            streamWriter.Close();

            // close the AddPassword form (window)
            Close();
        }
    }
}
