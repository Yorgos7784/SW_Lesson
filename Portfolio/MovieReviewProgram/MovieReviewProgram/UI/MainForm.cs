using MovieReviewProgram.API;
using MovieReviewProgram.Common;
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
    public partial class MainForm : Form
    {
        TMDbClient client = new TMDbClient("e1505e132578f77683ee1878346d1255");
        MovieApi ma;
        public MainForm()
        {
            InitializeComponent();
            ma = new MovieApi(client);
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchMovieBtn_Click(object sender, EventArgs e)
        {
            new SearchMovieForm(ma).ShowDialog();
        }

        private void searchTvBtn_Click(object sender, EventArgs e)
        {
            new SearchTVForm(ma).ShowDialog();
        }

        private void searchPersonBtn_Click(object sender, EventArgs e)
        {
            new SearchPersonForm(ma).ShowDialog();
        }

        private void uiImageButton2_Click(object sender, EventArgs e)
        {
            DataManager.Save();
            Application.Exit();
        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created By Yorgos 2021.04.14");
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                const char ESC_KEY = (char)Keys.Escape;
                if (e.KeyChar == ESC_KEY)
                    Application.Exit();
            }
            catch (FormatException)
            {

            }
        }

        private void favoriteMovieBtn_Click(object sender, EventArgs e)
        {
            new FavoriteForm(ma).ShowDialog();
        }
    }
}
