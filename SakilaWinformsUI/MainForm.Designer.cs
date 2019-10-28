﻿namespace SakilaWinformsUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RecordsFoundlabel = new System.Windows.Forms.Label();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.MatchWholeWordCheckBox = new System.Windows.Forms.CheckBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RestrictedAreaPictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.UpdateStaffEmailBbutton = new System.Windows.Forms.Button();
            this.ErrorLoginLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.StaffLastnameLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestrictedAreaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 50);
            this.tabControl1.Location = new System.Drawing.Point(0, 105);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 400);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.LogoutButton);
            this.tabPage1.Controls.Add(this.ErrorLoginLabel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.PasswordTextBox);
            this.tabPage1.Controls.Add(this.LoginButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.UsernameTextBox);
            this.tabPage1.Location = new System.Drawing.Point(160, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(488, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MatchWholeWordCheckBox);
            this.tabPage2.Controls.Add(this.RecordsFoundlabel);
            this.tabPage2.Controls.Add(this.ResultsListBox);
            this.tabPage2.Controls.Add(this.SearchTextBox);
            this.tabPage2.Controls.Add(this.FindButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(160, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(488, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Films";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RecordsFoundlabel
            // 
            this.RecordsFoundlabel.AutoSize = true;
            this.RecordsFoundlabel.Location = new System.Drawing.Point(12, 52);
            this.RecordsFoundlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RecordsFoundlabel.Name = "RecordsFoundlabel";
            this.RecordsFoundlabel.Size = new System.Drawing.Size(112, 18);
            this.RecordsFoundlabel.TabIndex = 4;
            this.RecordsFoundlabel.Text = "0 records found";
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.ItemHeight = 18;
            this.ResultsListBox.Location = new System.Drawing.Point(15, 74);
            this.ResultsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(431, 292);
            this.ResultsListBox.TabIndex = 3;
            this.ResultsListBox.DoubleClick += new System.EventHandler(this.ResultsListBox_DoubleClick);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(87, 14);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(217, 24);
            this.SearchTextBox.TabIndex = 2;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(334, 11);
            this.FindButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(112, 32);
            this.FindButton.TabIndex = 1;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.UpdateStaffEmailBbutton);
            this.tabPage3.Controls.Add(this.EmailTextBox);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.RestrictedAreaPictureBox);
            this.tabPage3.Location = new System.Drawing.Point(160, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(488, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Staff";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAKILA FILMS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MatchWholeWordCheckBox
            // 
            this.MatchWholeWordCheckBox.AutoSize = true;
            this.MatchWholeWordCheckBox.Location = new System.Drawing.Point(298, 51);
            this.MatchWholeWordCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MatchWholeWordCheckBox.Name = "MatchWholeWordCheckBox";
            this.MatchWholeWordCheckBox.Size = new System.Drawing.Size(148, 22);
            this.MatchWholeWordCheckBox.TabIndex = 5;
            this.MatchWholeWordCheckBox.Text = "Match whole word";
            this.MatchWholeWordCheckBox.UseVisualStyleBackColor = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(100, 80);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(194, 29);
            this.UsernameTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 99;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 98;
            this.label4.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(100, 136);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(194, 29);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(100, 188);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(194, 41);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RestrictedAreaPictureBox
            // 
            this.RestrictedAreaPictureBox.Image = global::SakilaWinformsUI.Properties.Resources._71QIwIAtQGL__SX425_;
            this.RestrictedAreaPictureBox.Location = new System.Drawing.Point(3, 42);
            this.RestrictedAreaPictureBox.Name = "RestrictedAreaPictureBox";
            this.RestrictedAreaPictureBox.Size = new System.Drawing.Size(417, 299);
            this.RestrictedAreaPictureBox.TabIndex = 0;
            this.RestrictedAreaPictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            this.label5.Visible = false;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(72, 57);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(348, 29);
            this.EmailTextBox.TabIndex = 2;
            this.EmailTextBox.Visible = false;
            // 
            // UpdateStaffEmailBbutton
            // 
            this.UpdateStaffEmailBbutton.Location = new System.Drawing.Point(299, 105);
            this.UpdateStaffEmailBbutton.Name = "UpdateStaffEmailBbutton";
            this.UpdateStaffEmailBbutton.Size = new System.Drawing.Size(121, 36);
            this.UpdateStaffEmailBbutton.TabIndex = 3;
            this.UpdateStaffEmailBbutton.Text = "Update";
            this.UpdateStaffEmailBbutton.UseVisualStyleBackColor = true;
            this.UpdateStaffEmailBbutton.Visible = false;
            this.UpdateStaffEmailBbutton.Click += new System.EventHandler(this.UpdateStaffEmailBbutton_Click);
            // 
            // ErrorLoginLabel
            // 
            this.ErrorLoginLabel.AutoSize = true;
            this.ErrorLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLoginLabel.Location = new System.Drawing.Point(79, 254);
            this.ErrorLoginLabel.Name = "ErrorLoginLabel";
            this.ErrorLoginLabel.Size = new System.Drawing.Size(251, 24);
            this.ErrorLoginLabel.TabIndex = 97;
            this.ErrorLoginLabel.Text = "Wrong credentials. Try again";
            this.ErrorLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLoginLabel.Visible = false;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(100, 188);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(194, 41);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Visible = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // StaffLastnameLabel
            // 
            this.StaffLastnameLabel.AutoSize = true;
            this.StaffLastnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffLastnameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.StaffLastnameLabel.Location = new System.Drawing.Point(167, 78);
            this.StaffLastnameLabel.Name = "StaffLastnameLabel";
            this.StaffLastnameLabel.Size = new System.Drawing.Size(51, 20);
            this.StaffLastnameLabel.TabIndex = 2;
            this.StaffLastnameLabel.Text = "label6";
            this.StaffLastnameLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.FindButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(652, 505);
            this.Controls.Add(this.StaffLastnameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sakila";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestrictedAreaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RecordsFoundlabel;
        private System.Windows.Forms.CheckBox MatchWholeWordCheckBox;
        private System.Windows.Forms.PictureBox RestrictedAreaPictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button UpdateStaffEmailBbutton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ErrorLoginLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label StaffLastnameLabel;
    }
}

