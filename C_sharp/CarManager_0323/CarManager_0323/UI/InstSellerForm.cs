using CarManager_0323.DB;
using CarManager_0323.Handler;
using CarManager_0323.Model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarManager_0323.UI
{
    partial class InstSellerForm : MaterialForm
    {
        DaoOracle dao;
        List<Deal> list;
        
        public InstSellerForm()
        {
            InitializeComponent();
        }

        public InstSellerForm(DaoOracle dao)
        {
            InitializeComponent();
            this.dao = dao;
        }

        public InstSellerForm(DaoOracle dao, List<Deal> list)
        {
            InitializeComponent();
            this.dao = dao;
            this.list = list;
        }

        private void sellerOK_Click(object sender, EventArgs e)
        {
            if (sellerName.Text == "" || sellerTel.Text == "" || sellerEmail.Text == "" || sellerGrade.Text == "" || sellerDerijum.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n값을 입력해주세요.", "누락된 정보");
            }

            else
            {
                Seller seller = new Seller(sellerName.Text, sellerTel.Text, sellerEmail.Text, sellerGrade.Text, sellerDerijum.Text);
                dao.insertSeller(seller, list);
                Close();
            }
        }

        private void sellerCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
