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

namespace MovieReviewProgram.UI
{
    partial class SearchPersonForm : Form
    {
        TMDbClient client;
        MovieApi ma;
        List<int> ids = new List<int>();
        public SearchPersonForm(TMDbClient client, MovieApi ma)
        {
            InitializeComponent();
            this.client = client;
            this.ma = ma;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            getPersonList();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void getPersonList()
        {
            // 영화 리스트 초기화
            personSearchList.Items.Clear();
            ids.Clear();

            List<PersonInfo> persons = ma.searchPerson(personInput.Text);
            foreach (PersonInfo person in persons)
            {
                // 불러온 목록 리스트에 추가
                personSearchList.Items.Add(new ListViewItem(new String[] { person.Name }));
                ids.Add(person.Id);
            }
        }

        private void personSearchList_Click(object sender, EventArgs e)
        {
            if (personSearchList.SelectedItems.Count != 0)
            {
                int n = personSearchList.SelectedItems[0].Index;
                int id = ids[n];
                getPersonImage(id);
            }
            else
            {

            }
        }

        public void getPersonImage(int id)
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
                personImage.Image = Image.FromFile("C:/Users/KB/Desktop/SW_Lesson/Portfolio/MovieReviewProgram/MovieReviewProgram/img/NoImage.jpg");
                personImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void personInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                const char ENTER_KEY = (char)Keys.Enter;
                if (e.KeyChar == ENTER_KEY)
                    getPersonList();
            }
            catch (FormatException)
            {

            }
        }
    }
}
