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
        public MainForm()
        {
            InitializeComponent();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cxFlatButton1_Click(object sender, EventArgs e)
        {
            new SearchMovieForm(client).ShowDialog();
        }
    }
}
