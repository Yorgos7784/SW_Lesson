using MovieReviewProgram.API;
using MovieReviewProgram.Model;
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
using TMDbLib.Objects.Search;

namespace MovieReviewProgram.UI
{
    public partial class SearchMovieForm : Form
    {
        TMDbClient client;
        MovieApi ma;
        List<int> ids = new List<int>();
        public SearchMovieForm(TMDbClient client)
        {
            InitializeComponent();
            this.client = client;
            ma = new MovieApi(client);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            movieSearchList.Items.Clear();
            ids.Clear();
            List<MovieInfo> movies = ma.searchMovies(movieInput.Text);
            foreach (MovieInfo movie in movies)
            {
                movieSearchList.Items.Add(new ListViewItem(new String[] { movie.MovieTitle, movie.MovieReleaseDate }));
                ids.Add(movie.MovieId);
            }
        }

        public async void getMoviePoster(int id)
        {
            try
            {
                Movie movie1 = await client.GetMovieAsync(id, MovieMethods.Credits);
                WebClient Downloader = new WebClient();

                Stream ImageStream = Downloader.OpenRead("https://www.themoviedb.org/t/p/w600_and_h900_bestv2" + movie1.PosterPath);

                Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;

                moviePoster.Image = DownloadImage;
                moviePoster.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception)
            {
                //MessageBox.Show("이미지가 없습니다.", "이미지 없음");
                moviePoster.Image = Image.FromFile("C:/Users/KB/Desktop/SW_Lesson/Portfolio/MovieReviewProgram/MovieReviewProgram/img/NoImage.jpg");
                moviePoster.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void movieSearchList_Click(object sender, EventArgs e)
        {
            if (movieSearchList.SelectedItems.Count != 0)
            {
                int n = movieSearchList.SelectedItems[0].Index;
                int id = ids[n];
                getMoviePoster(id);
            }
            else
            {
                MessageBox.Show("선택된 항목이 없습니다.");
            }
        }

        private void movieDetail_Click(object sender, EventArgs e)
        {
            if (movieSearchList.SelectedItems.Count != 0)
            {
                int n = movieSearchList.SelectedItems[0].Index;
                int id = ids[n];
                new MovieDetailForm(id, client, ma).ShowDialog();
            }
            else
            {
                MessageBox.Show("선택된 항목이 없습니다.");
            }
            
        }
    }
}
