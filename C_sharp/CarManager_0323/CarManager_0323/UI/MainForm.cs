using CarManager_0323.DB;
using CarManager_0323.UI;
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

        private void createTable_Click(object sender, EventArgs e)
        {
            dao.makeTables();
        }

        private void deleteTable_Click(object sender, EventArgs e)
        {
            dao.dropTables();
        }

        private void insertData_Click(object sender, EventArgs e)
        {
            dao.insertDatas();
        }

        private void insertCar_Click(object sender, EventArgs e)
        {
            new InstCarForm(dao).ShowDialog();
        }

        private void insertCustomer_Click(object sender, EventArgs e)
        {
            new InstCustomerForm(dao).ShowDialog();
        }

        private void insertSeller_Click(object sender, EventArgs e)
        {
            new InstSellerForm(dao).ShowDialog();
        }

        private void insertOrder_Click(object sender, EventArgs e)
        {

        }

        private void programExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
