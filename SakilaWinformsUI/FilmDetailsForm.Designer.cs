namespace SakilaWinformsUI
{
    partial class FilmDetailsForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.LanguageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TitleLabel.Location = new System.Drawing.Point(15, 9);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(415, 65);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "label2";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.BackColor = System.Drawing.Color.White;
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DescriptionLabel.Location = new System.Drawing.Point(15, 156);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(415, 96);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description";
            // 
            // DurationLabel
            // 
            this.DurationLabel.BackColor = System.Drawing.Color.White;
            this.DurationLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DurationLabel.Location = new System.Drawing.Point(471, 193);
            this.DurationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(109, 24);
            this.DurationLabel.TabIndex = 5;
            this.DurationLabel.Text = "label5";
            this.DurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RatingLabel
            // 
            this.RatingLabel.BackColor = System.Drawing.Color.White;
            this.RatingLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RatingLabel.Location = new System.Drawing.Point(471, 228);
            this.RatingLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(109, 24);
            this.RatingLabel.TabIndex = 7;
            this.RatingLabel.Text = "label7";
            this.RatingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SakilaWinformsUI.Properties.Resources.MV5BMTY2Njk3MTAzM15BMl5BanBnXkFtZTgwMTY5Mzk4NjE___V1_SY1000_CR0_0_669_1000_AL_;
            this.pictureBox1.Location = new System.Drawing.Point(439, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CategoryLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryLabel.Location = new System.Drawing.Point(94, 85);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(60, 24);
            this.CategoryLabel.TabIndex = 9;
            this.CategoryLabel.Text = "label1";
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LanguageLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LanguageLabel.Location = new System.Drawing.Point(278, 85);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(60, 24);
            this.LanguageLabel.TabIndex = 10;
            this.LanguageLabel.Text = "label1";
            this.LanguageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FilmDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 261);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FilmDetailsForm";
            this.Text = "Film Details - Sakila";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label LanguageLabel;
    }
}