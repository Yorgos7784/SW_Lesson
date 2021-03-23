using CarManager_0323.DB;
using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager_0323
{
    partial class MainForm : MaterialForm
    {
        DaoOracle dao = new DaoOracle();

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void createTBBtn_Click(object sender, EventArgs e)
        {
            dao.makeTables();
        }

        private void dropTBBtn_Click(object sender, EventArgs e)
        {
            dao.dropTables();
        }
    }
}
