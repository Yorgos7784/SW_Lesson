using MovieReviewProgram.API;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;

namespace MovieReviewProgram.UI
{
    partial class MovieDetailForm : Form
    {
        int id;
        MovieApi ma;
        public MovieDetailForm(int id, MovieApi ma)
        {
            InitializeComponent();
            this.id = id;
            this.ma = ma;
        }

        private async void MovieDetailForm_Load(object sender, EventArgs e)
        {
            // 영화 전체 정보 불러오기
            Movie movie1 = await ma.getMovieAsync(id);

            // 영화 포스터
            setImage();

            // 영화 제목
            mName.Text = movie1.Title;

            // 영화 감독
            setDirector(movie1);

            // 영화 장르
            List<Genre> genres = movie1.Genres;
            genre.Text = Convert.ToString(genres[0].Name);

            // 영화 개봉일
            releaseDate.Text = ma.getDate(movie1.ReleaseDate.ToString());

            // 줄거리
            overView.Text = movie1.Overview;
            overView.TextAlign = ContentAlignment.TopLeft;

            // 영화 출연진
            setCast(movie1);

        }

        public void setImage()
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
                moviePoster.Image = ma.noImage();
                moviePoster.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        public void setDirector(Movie movie1)
        {
            try
            {
                string director = "";
                // 전체 스텝들 중 감독인 사람 이름 불러오기
                // 여러명이면 첫번쨰 감독만 불러오기
                foreach (Crew crew in movie1.Credits.Crew)
                {
                    if (crew.Job == "Director")
                    {
                        director = crew.Name;
                        break;
                    }
                }
                mDirector.Text = director;
            }
            catch (Exception)
            {
                mDirector.Text = "Unknown";
            }

        }

        public void setCast(Movie movie1)
        {
            List<Cast> casts = movie1.Credits.Cast;
            foreach (Cast cast in casts)
            {
                castList.Rows.Add(cast.Name, cast.Character);
            }

        }

        private void windowClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutAc_Click(object sender, EventArgs e)
        {
            try
            {
                string acName = castList.Rows[castList.SelectedRows[0].Index].Cells[0].Value.ToString();
                Console.WriteLine(acName);
                int id = ma.searchPersonId(acName);
                new PersonDetailForm(id, ma).ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("선택된 항목이 없습니다.", "선택한 항목 없음");
            }
        }

        private void mDirector_Click(object sender, EventArgs e)
        {
            int id = ma.searchPersonId(mDirector.Text);
            new PersonDetailForm(id, ma).ShowDialog();
        }

        private void mDirector_MouseLeave(object sender, EventArgs e)
        {
            mDirector.ForeColor = Color.DodgerBlue;
            mDirector.Cursor = Cursors.Default;
        }

        private void mDirector_MouseEnter(object sender, EventArgs e)
        {
            mDirector.ForeColor = Color.LightSkyBlue;
            mDirector.Cursor = Cursors.Hand;
        }
    }
}
