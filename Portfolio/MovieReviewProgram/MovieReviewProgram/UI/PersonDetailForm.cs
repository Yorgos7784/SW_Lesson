using MovieReviewProgram.API;
using MovieReviewProgram.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.People;

namespace MovieReviewProgram.UI
{
    partial class PersonDetailForm : Form
    {
        int id;
        MovieApi ma;
        List<MovieInfo> movies = new List<MovieInfo>();
        public PersonDetailForm(int id, MovieApi ma)
        {
            InitializeComponent();
            this.id = id;
            this.ma = ma;
        }

        private async void PersonDetailForm_Load(object sender, EventArgs e)
        {
            Person person = await ma.getPersonAsync(id);
            Console.WriteLine(person.KnownForDepartment);
            setImage();
            personName.Text = person.Name;
            birth.Text = ma.getDate(person.Birthday.ToString());
            place.Text = person.PlaceOfBirth;
            biography.Text = person.Biography;
            biography.TextAlign = ContentAlignment.TopLeft;
            setKnownFor(person);
        }

        public void setImage()
        {
            try
            {
                // 포스터 불러오기
                Bitmap DownloadImage = ma.getPersonImage(id);
                personImage.Image = DownloadImage;
                personImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception)
            {
                // 이미지가 존재하지 않을때
                //MessageBox.Show("이미지가 없습니다.", "이미지 없음");
                personImage.Image = ma.noImage();
                personImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        public void setKnownFor(Person person)
        {
            if(person.KnownForDepartment == "Acting")
            {
                List<MovieRole> roles = person.MovieCredits.Cast;
                foreach (var role in roles)
                {
                    knownList.Rows.Add(role.Title, role.Character, role.ReleaseDate);
                    movies.Add(new MovieInfo(role.Id, role.Title, role.ReleaseDate.ToString()));
                }
            }

            else
            {
                List<MovieJob> roles = person.MovieCredits.Crew;
                foreach (var role in roles)
                {
                    knownList.Rows.Add(role.Title, role.Job, role.ReleaseDate);
                    movies.Add(new MovieInfo(role.Id, role.Title, role.ReleaseDate.ToString()));
                }
            }
            DataGridViewColumn col = knownList.Columns[2];
            knownList.Sort(col, ListSortDirection.Descending);
        }

        private void windowClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutAc_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                string mName = knownList.Rows[knownList.SelectedRows[0].Index].Cells[0].Value.ToString();
                foreach (var movie in movies)
                {
                    if(movie.MovieTitle == mName)
                    {
                        id = movie.MovieId;
                    }
                }
                new MovieDetailForm(id, ma).ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("선택된 항목이 없습니다.", "선택한 항목 없음");
            }
        }
    }
}