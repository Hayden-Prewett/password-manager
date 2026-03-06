using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class ChangePassword : Form
    {
        private readonly string _website;
        private readonly string _username;
        private readonly string _password;
        public ChangePassword(string website, string username, string password)
        {
            InitializeComponent();
            _website = website;
            _username = username;
            _password = password;
               
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // Applies the changes to the record
            // Assign variables
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmNewPassword.Text;
            string filePath = @"..\..\..\testDB.csv";

            // Make the changes in the file:
            // Read all the lines from the csv and store as list
            List<string> lines = File.ReadLines(filePath).ToList();

            // Loop through the file until website and username is found
            // Note: website and username act as a composite key.
            //       A proper key should be used in the future.
            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i]; // the current line
                string[] parts = line.Split(","); // split the line into its values

                // Check if the line is correct based on username and password
                if (parts[0].Trim() == _website && parts[1].Trim() == _username)
                {
                    // Record found! Replace the password field with the new one
                    // Note: Validation will come later. For now, the confirm new password does nothing
                    parts[2] = newPassword;
                    lines[i] = string.Join(",", parts); // forms the line again using comma
                    break;
                }
            }

            // Write all the lines back to the CSV, including updated one
            File.WriteAllLines(filePath, lines);

            // Output success message
            MessageBox.Show("Password successfully updated!", "Success");
        }
    }
}
