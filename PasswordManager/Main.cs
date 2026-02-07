///////////////////////////
// Project Name: Password Manager
// Author: Hayden Prewett
// Created: 15/1/2026
///////////////////////////

using System.Data;

namespace PasswordManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadData();
        }

        // Functions //
        private void LoadData()
        {
            // load data into the DataTable
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Website");
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("Password");
            string filePath = @"..\..\..\testDB.csv"; // The path for the testDB.csv

            // initialise StreamReader file handling
            StreamReader streamReader = new StreamReader(filePath);
            string[] database = new string[File.ReadAllLines(filePath).Length];
            while (!streamReader.EndOfStream)
            {
                // split at commas
                database = streamReader.ReadLine().Split(',');
                // add to datatable
                dataTable.Rows.Add(database[0], database[1], database[2]);
            }
            loginsDataGrid.DataSource = dataTable;
            streamReader.Close();
        }


        // Event handling //
        void btnAddPassword_Click(object sender, EventArgs e)
        {
            // When the Add Password button is clicked, open AddPassword form
            var AddPassword = new AddPassword();
            AddPassword.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // end execution
            System.Windows.Forms.Application.Exit();
        }

        private void loginsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // when a cell is clicked
            var LoginInfo = new LoginInfo();
            LoginInfo.Show();
        }
    }
}
