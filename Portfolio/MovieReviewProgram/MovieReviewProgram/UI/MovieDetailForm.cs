using MovieReviewProgram.API;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Reviews;

namespace MovieReviewProgram.UI
{
    partial class MovieDetailForm : Form
    {
        int id;
        TMDbClient client;
        MovieApi ma;
        public MovieDetailForm(int id, TMDbClient client, MovieApi ma)
        {
            InitializeComponent();
            this.id = id;
            this.client = client;
            this.ma = ma;
        }

        private async void MovieDetailForm_Load(object sender, EventArgs e)
        {
            // 영화 전체 정보 불러오기
            Movie movie1 = await ma.getMovieAsync(id);

            // 영화 포스터
            setImage(movie1);

            // 영화 제목
            mName.Text = movie1.Title;

            // 영화 감독
            setDirector(movie1);

            // 영화 장르
            List<Genre> genres = movie1.Genres;
            genre.Text = Convert.ToString(genres[0].Name);

            // 영화 개봉일
            releaseDate.Text = movie1.ReleaseDate.ToString();

            // 영화 출연진
            setCast(movie1);

            // 영화 리뷰
            setReviews(movie1);
        }


        public void setImage(Movie movie1)
        {
            Bitmap DownloadImage = ma.getMovieImage(movie1);
            moviePoster.Image = DownloadImage;
            moviePoster.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void setDirector(Movie movie1)
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

        public void setCast(Movie movie1)
        {
            string casts = "";
            for (int i = 0; i < 5; i++)
            {
                if (i == 4)
                    casts += string.Format("{0} ({1})", movie1.Credits.Cast[i].Name, movie1.Credits.Cast[i].Character);
                else
                    casts += string.Format("{0} ({1})", movie1.Credits.Cast[i].Name, movie1.Credits.Cast[i].Character) + "\n";
            }
            cast.Text = casts;
            cast.TextAlign = ContentAlignment.TopLeft;
        }

        public void setReviews(Movie movie1)
        {
            List<ReviewBase> reviews = movie1.Reviews.Results;
            foreach (ReviewBase item in reviews)
            {
                Console.WriteLine(item.Content + "\n");
            }

            string review = string.Empty;
            if (reviews.Count < 3)
            {
                for (int i = 0; i < reviews.Count; i++)
                {
                    string contents = "";
                    for (int j = 0; j < 100; j++)
                    {
                        if (j == 99)
                            contents += reviews[i].Content[j] + "...";
                        else
                            contents += reviews[i].Content[j];
                    }
                    if (i == 2)
                        review += "- " + contents;
                    else
                        review += "- " + contents + "\n\n";
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    string contents = "";
                    for (int j = 0; j < 100; j++)
                    {
                        if (j == 99)
                            contents += reviews[i].Content[j] + "...";
                        else
                            contents += reviews[i].Content[j];
                    }
                    if (i == 2)
                        review += "- " + contents;
                    else
                        review += "- " + contents + "\n\n";
                }
            }
            mReview.Text = review;
            mReview.TextAlign = ContentAlignment.TopLeft;
        }

        private void windowClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
