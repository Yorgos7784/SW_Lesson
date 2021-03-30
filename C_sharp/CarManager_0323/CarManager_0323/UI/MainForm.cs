using CarManager_0323.DB;
using CarManager_0323.Handler;
using CarManager_0323.Model;
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
        dealHandler oh = new dealHandler();
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
            List<Deal> list = oh.getOrderList();
            if(list[0].Car == null)
            {
                new InstCarForm(dao, oh).ShowDialog();
            }
            else
            {
                MessageBox.Show("차량 정보가 이미 저장되었습니다.", "차량 추가 에러");
                insertCar.FillColor = Color.Brown;
            }
        }

        private void insertCustomer_Click(object sender, EventArgs e)
        {
            List<Deal> list = oh.getOrderList();
            if(list[0].Customer == null)
            {
                new InstCustomerForm(dao, oh).ShowDialog();
            }
            else
            {
                MessageBox.Show("고객 정보가 이미 저장되었습니다.", "고객 추가 에러");
                insertCustomer.FillColor = Color.Brown;
            }
        }

        private void insertSeller_Click(object sender, EventArgs e)
        {
            List<Deal> list = oh.getOrderList();
            if (list[0].Seller == null)
            {
                new InstSellerForm(dao, oh).ShowDialog();
            }
            else
            {
                MessageBox.Show("판매자 정보가 이미 저장되었습니다.", "판매자 추가 에러");
                insertSeller.FillColor = Color.Brown;
            }
        }

        private void insertOrder_Click(object sender, EventArgs e)
        {
            List<Deal> list = oh.getOrderList();
            dao.insertOrder(list[0]);
            oh.dealListClear();
        }

        private void programExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}