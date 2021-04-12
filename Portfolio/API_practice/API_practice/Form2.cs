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

namespace API_practice
{
    public partial class Form2 : Form
    {
        int id;
        TMDbClient client;
        public Form2(int id, TMDbClient client)
        {
            InitializeComponent();
            this.id = id;
            this.client = client;
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            Movie movie1 = await client.GetMovieAsync(id, MovieMethods.Credits);
            WebClient Downloader = new WebClient();

            Stream ImageStream = Downloader.OpenRead("https://www.themoviedb.org/t/p/w600_and_h900_bestv2" + movie1.PosterPath);

            Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;
            mPoster.Image = DownloadImage;
            mPoster.SizeMode = PictureBoxSizeMode.Zoom;
            mName.Text = movie1.Title;
            string diretor = "";
            foreach (Crew crew in movie1.Credits.Crew)
            {
                if(crew.Job == "Director")
                {
                    diretor = crew.Name;
                }
                //Console.WriteLine($"{crew.Name} - {crew.Job}");
            }

            mDirector.Text = diretor;
            mDate.Text = movie1.ReleaseDate.ToString();
            for (int i = 0; i < 5; i++)
            {
                if(i == 4)
                {
                    mCast.Text += string.Format("{0} ({1})", movie1.Credits.Cast[i].Name, movie1.Credits.Cast[i].Character);
                }
                else
                {
                    mCast.Text += string.Format("{0} ({1})", movie1.Credits.Cast[i].Name, movie1.Credits.Cast[i].Character) + "\n";
                }
            }
            foreach (Cast cast in movie1.Credits.Cast)
            {
                
                Console.WriteLine($"{cast.Name} - {cast.Character}");
            }
            /*for (int i = 0; i < movie.Credits.Cast.Count; i++)
            {
                if (i == movie.Credits.Cast.Count - 1)
                    mCast.Text += string.Format("{0} ({1})", movie.Credits.Cast[i].Name, movie.Credits.Cast[i].Character);
                else
                    mCast.Text += string.Format("{0} ({1})", movie.Credits.Cast[i].Name, movie.Credits.Cast[i].Character) + ", ";
            }*/
        }
    }
}
