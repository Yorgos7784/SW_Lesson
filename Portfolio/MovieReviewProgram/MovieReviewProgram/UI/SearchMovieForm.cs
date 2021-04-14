using MovieReviewProgram.API;
using MovieReviewProgram.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;

namespace MovieReviewProgram.UI
{
    partial class SearchMovieForm : Form
    {
        MovieApi ma;
        List<int> ids = new List<int>();

        public SearchMovieForm(MovieApi ma)
        {
            InitializeComponent();
            this.ma = ma;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            getMovieList();
        }

        public void getMovieList()
        {
            try
            {
                // 영화 리스트 초기화
                movieSearchList.Items.Clear();
                ids.Clear();

                // 검색한 영화 목록 불러오기
                List<MovieInfo> movies = ma.searchMovies(movieInput.Text);
                foreach (MovieInfo movie in movies)
                {
                    // 불러온 목록 리스트에 추가
                    movieSearchList.Items.Add(new ListViewItem(new String[] { movie.MovieTitle, movie.MovieReleaseDate }));
                    ids.Add(movie.MovieId);
                }
            }
            catch (Exception e)
            {
                LogWriter.PrintLog("getMovieList");
                LogWriter.PrintLog(e.Message);
                LogWriter.PrintLog(e.StackTrace);
            }
        }

        public void getMoviePoster(int id)
        {
            try
            {
                // 포스터 불러오기
                Bitmap DownloadImage = ma.getMovieImage(id);
                moviePoster.Image = DownloadImage;
                moviePoster.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception)
            {
                // 이미지가 존재하지 않을때
                //MessageBox.Show("이미지가 없습니다.", "이미지 없음");
                moviePoster.Image = Image.FromFile("C:/Users/KB/Desktop/SW_Lesson/Portfolio/MovieReviewProgram/MovieReviewProgram/img/NoImage.jpg");
                moviePoster.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        // 리스트에서 선택한 영화 불러오기
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
                
            }
        }

        // 선택한 영화 상세항목
        private void movieDetail_Click(object sender, EventArgs e)
        {
            
            if (movieSearchList.SelectedItems.Count != 0)
            {
                int n = movieSearchList.SelectedItems[0].Index;
                int id = ids[n];
                new MovieDetailForm(id, ma).ShowDialog();
            }
            else
            {
                MessageBox.Show("선택된 항목이 없습니다.", "선택한 항목 없음");
            }
        }

        private void movieInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                const char ENTER_KEY = (char)Keys.Enter;
                if (e.KeyChar == ENTER_KEY)
                    getMovieList();
            }
            catch (FormatException)
            {

            }
        }
    }
}
