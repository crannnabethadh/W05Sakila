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
        const string staffConnectionString = "Server=localhost;Database=sakila;Uid=staff;Pwd=$up3r$3cr3t";
        Staff staffMember;

        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //tabControl1.SelectTab(tabPage2);
            foreach (Control control in tabPage2.Controls)
                control.Enabled = false;
            UsernameTextBox.Focus();
            UsernameTextBox.SelectAll();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(connectionString);
            string sql = string.Empty;
            if (MatchWholeWordCheckBox.Checked)
            {
                sql = $"SELECT film.film_id, title, description, length, rating, language.name as languageName, category.name as categoryName FROM" +
                    $" film JOIN film_category ON film.film_id=film_category.film_id JOIN category ON film_category.category_id=category.category_id" +
                    $" JOIN language ON film.language_id=language.language_id WHERE title LIKE '% {SearchTextBox.Text} %'" +
                    $"OR title LIKE '% {SearchTextBox.Text}' OR title LIKE '{SearchTextBox.Text} %' ORDER BY title";
            }
            else
            {
                sql = $"SELECT film.film_id, title, description, length, rating, language.name as languageName, category.name as categoryName FROM" +
                    $" film JOIN film_category ON film.film_id=film_category.film_id JOIN category ON film_category.category_id=category.category_id" +
                    $" JOIN language ON film.language_id=language.language_id WHERE title LIKE '%{SearchTextBox.Text}%' ORDER BY title";
            }
            var films = cnn.Query<Film>(sql).ToList();
            ResultsListBox.DataSource = films;
            ResultsListBox.DisplayMember = "title";
            RecordsFoundlabel.Text = $"{films.Count} records found";
            cnn.Close();
        }

        private void ResultsListBox_DoubleClick(object sender, EventArgs e)
        {
            FilmDetailsForm filmDetailsForm = new FilmDetailsForm(ResultsListBox.SelectedItem as Film);
            filmDetailsForm.ShowDialog(this);
        }

        private void UpdateStaffEmailBbutton_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(staffConnectionString);
            string sql = $"UPDATE staff SET email='{EmailTextBox.Text}' WHERE staff_id=2";
            cnn.Execute(sql);
            cnn.Close();
            MessageBox.Show("Your email address has been updated!", "Sakila staff", MessageBoxButtons.OK);
            EmailTextBox.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "guest")
            {
                if (PasswordTextBox.Text == "123")
                {
                    LoginButton.Visible = false;
                    LogoutButton.Visible = true;
                    UsernameTextBox.Enabled = false;
                    PasswordTextBox.Enabled = false;
                    tabControl1.SelectedTab = tabPage2;
                    foreach (Control control in tabPage2.Controls)
                        control.Enabled = true;
                }
                else
                {
                    ErrorLoginLabel.Visible = true;
                }
            }
            else
            {
                // Connect to db as staff
                MySqlConnection cnn = new MySqlConnection(staffConnectionString);
                string sql = $"SELECT staff_id, first_name, last_name, email, username FROM staff" +
                    $" WHERE username='{UsernameTextBox.Text}'";
                try
                {
                    staffMember = cnn.Query<Staff>(sql).FirstOrDefault();
                    if (PasswordTextBox.Text == "456")
                    {
                        LoginButton.Visible = false;
                        LogoutButton.Visible = true;
                        UsernameTextBox.Enabled = false;
                        PasswordTextBox.Enabled = false;
                        tabControl1.SelectedTab = tabPage2;
                        foreach (Control control in tabPage2.Controls)
                            control.Enabled = true;
                        RestrictedAreaPictureBox.Visible = false;
                        label5.Visible = true;
                        EmailTextBox.Visible = true;
                        UpdateStaffEmailBbutton.Visible = true;
                        StaffLastnameLabel.Text = $"Mr. {staffMember.last_name}";
                        StaffLastnameLabel.Visible = true;

                    }
                    else
                    {
                        ErrorLoginLabel.Visible = true;
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    ErrorLoginLabel.Visible = true;
                }
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPage2.Controls)
                control.Enabled = false;
            LogoutButton.Visible = false;
            LoginButton.Visible = true;
            UsernameTextBox.Enabled = true;
            PasswordTextBox.Enabled = true;
            UsernameTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
            staffMember = null;
            RestrictedAreaPictureBox.Visible = true;
            label5.Visible = false;
            EmailTextBox.Visible = false;
            UpdateStaffEmailBbutton.Visible = false;
            StaffLastnameLabel.Text = string.Empty;
            StaffLastnameLabel.Visible = false;
        }
    }
}
