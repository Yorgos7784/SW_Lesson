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
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;

namespace API_practice
{
    public partial class Form1 : Form
    {
        TMDbClient client = new TMDbClient("e1505e132578f77683ee1878346d1255");

        public Form1()
        {
            InitializeComponent();
        }

        public List<int> searchMovies(string movieName)
        {
            List<int> mIds = new List<int>();
            SearchContainer<SearchMovie> results = client.SearchMovieAsync(movieName).Result;
            Console.WriteLine($"Got {results.Results.Count:N0} of {results.TotalResults:N0} results");
            foreach (SearchMovie result in results.Results)
            {
                Console.WriteLine(result.Title + " : " + result.Id);
                movieList.Items.Add(new ListViewItem(new String[] { result.Title, result.ReleaseDate.ToString() }));
                mIds.Add(result.Id);
            }
            Console.WriteLine();
            return mIds;
        }

        private void searching_Click(object sender, EventArgs e)
        {
            if(mNameInput.Text == "")
            {
                MessageBox.Show("입력창을 확인해 주세요.", "입력 오류");

            }
            else
            {
                searchMovies(mNameInput.Text);

            }
            /*try
            {
                searchMovies(mNameInput.Text);
            }
            catch (AggregateException)
            {
                MessageBox.Show("입력창을 확인해 주세요.", "입력 오류");
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*try
            {
                int id = getId(searchMovies(mNameInput.Text));
                new Form2(id, client).ShowDialog();
            }
            catch (AggregateException)
            {
                MessageBox.Show("선택된 항목이 없습니다.", "입력 오류");
            }*/
            if (movieList.SelectedItems.Count != 0)
            {
                int id = getId(searchMovies(mNameInput.Text));
                new Form2(id, client).ShowDialog();
            }
            else
            {
                MessageBox.Show("선택된 항목이 없습니다.");
            }

        }

        public int getId(List<int> mIds)
        {
            int id = 0;
            if (movieList.SelectedItems.Count != 0)
            {
                int n = movieList.SelectedItems[0].Index;
                id = mIds[n];
            }
            else
            {
                MessageBox.Show("선택된 항목이 없습니다.");
            }
            return id;
        }
    }
}
