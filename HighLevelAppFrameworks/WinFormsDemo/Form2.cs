using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDemo.Movies;

namespace WinFormsDemo
{
    public partial class Form2 : Form
    {
        private MoviesContext context = null;

        public Form2(int yearOfBirth = 1960)
        {
            InitializeComponent();
            context = new MoviesContext();
            if (yearOfBirth < NudMovieYear.Minimum || yearOfBirth > NudMovieYear.Maximum)
                yearOfBirth = (int)NudMovieYear.Minimum;
            NudMovieYear.Value = yearOfBirth;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Movie> movies =
                context.Movies.Where(m => ((DateTime)(m.ReleaseDate)).Year
                    == (int)NudMovieYear.Value).OrderByDescending(m => m.Revenue).ToList();
            MoviesDGV.DataSource = movies;
        }

        private void LoadMoviesButton_Click(object sender, EventArgs e)
        {
            List<Movie> movies =
                context.Movies.Where(m => ((DateTime)(m.ReleaseDate)).Year
                    == (int)NudMovieYear.Value).OrderByDescending(m => m.Revenue).ToList();
            //List<Movie> movies =
            //    context.Movies.ToList();
            MoviesDGV.DataSource = movies;
        }

        private void NudMovieYear_ValueChanged(object sender, EventArgs e)
        {
            LoadMoviesButton_Click(sender, e);
        }
    }
}
