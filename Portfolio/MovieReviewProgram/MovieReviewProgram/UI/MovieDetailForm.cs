using MovieReviewProgram.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;

namespace MovieReviewProgram.UI
{
    partial class MovieDetailForm : Form
    {
        int id;
        TMDbClient client;
        MovieApi ma;
        Movie movie;
        public MovieDetailForm(int id, TMDbClient client, MovieApi ma)
        {
            InitializeComponent();
            this.id = id;
            this.client = client;
            this.ma = ma;
        }

        private async void MovieDetailForm_Load(object sender, EventArgs e)
        {
            Movie movie1 = await client.GetMovieAsync(id, MovieMethods.Credits);
            WebClient Downloader = new WebClient();

            Stream ImageStream = Downloader.OpenRead("https://www.themoviedb.org/t/p/w600_and_h900_bestv2" + movie1.PosterPath);

            Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;
            moviePoster.Image = DownloadImage;
            moviePoster.SizeMode = PictureBoxSizeMode.Zoom;
            mName.Text = movie1.Title;
            string director = "";
            foreach (Crew crew in movie1.Credits.Crew)
            {
                if (crew.Job == "Director")
                {
                    director = crew.Name;
                }
                //Console.WriteLine($"{crew.Name} - {crew.Job}");
            }
            mDirector.Text = director;

            List<Genre> genres = movie1.Genres;
            genre.Text = Convert.ToString(genres[0].Name);
            

            releaseDate.Text = movie1.ReleaseDate.ToString();

            string casts = "";
            for (int i = 0; i < 5; i++)
            {
                if (i == 4)
                {
                    casts += string.Format("{0} ({1})", movie1.Credits.Cast[i].Name, movie1.Credits.Cast[i].Character);
                }
                else
                {
                    casts += string.Format("{0} ({1})", movie1.Credits.Cast[i].Name, movie1.Credits.Cast[i].Character) + "\n";
                }
            }
            cast.Text = casts;
            cast.TextAlign = ContentAlignment.TopLeft;

            /*foreach (Cast cast in movie1.Credits.Cast)
            {

                Console.WriteLine($"{cast.Name} - {cast.Character}");
            }*/
        }

        private void windowClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
