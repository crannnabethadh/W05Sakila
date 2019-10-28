using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SakilaWinformsUI
{
    public partial class FilmDetailsForm : Form
    {
        public FilmDetailsForm(Film film)
        {
            InitializeComponent();
            TitleLabel.Text = film.title;
            DescriptionLabel.Text = film.description;
            DurationLabel.Text = film.length.ToString() + "'";
            if (film.rating == "R" || film.rating == "NC-17")
                RatingLabel.ForeColor = Color.Red;
            RatingLabel.Text = film.rating;
            LanguageLabel.Text = film.languageName;
            CategoryLabel.Text = film.categoryName;
        }
    }
}
