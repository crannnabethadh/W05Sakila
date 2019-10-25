using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace SakilaWinformsUI
{
    public partial class MainForm : Form
    {
        const string connectionString = "Server=localhost;Database=sakila;Uid=client;Pwd=$3cr3t3t";

        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(connectionString);

            string sql = $"SELECT title FROM film WHERE title LIKE '%{SearchTextBox.Text}%'VORDER BY title";
            var result = cnn.Query<string>(sql).ToList();
            ResultsListBox.DataSource = result;
            RecordsFoundlabel.Text = $"{result.Count} records found";
            cnn.Close();
        }
    }
}
