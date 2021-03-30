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
        dealHandler oh;
        public InstSellerForm()
        {
            InitializeComponent();
        }

        public InstSellerForm(DaoOracle dao)
        {
            InitializeComponent();
            this.dao = dao;
        }
        
        public InstSellerForm(DaoOracle dao, dealHandler oh)
        {
            InitializeComponent();
            this.dao = dao;
            this.oh = oh;
        }

        private void sellerOK_Click(object sender, EventArgs e)
        {
            if (sellerName.Text == "" || sellerTel.Text == "" || sellerEmail.Text == "" || sellerGrade.Text == "" || sellerDerijum.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n값을 입력해주세요.", "누락된 정보");
            }

            else
            {
                List<Deal> list = oh.getOrderList();
                Seller seller = new Seller(sellerName.Text, sellerTel.Text, sellerEmail.Text, sellerGrade.Text, sellerDerijum.Text);
                if(list[0].Seller == null)
                {
                    list[0].Seller = seller;
                    dao.insertSeller(seller);
                    Close();
                }
                else
                {
                    MessageBox.Show("판매자 정보가 이미 저장되었습니다.", "판매자 추가 에러");
                    Close();
                }
            }
        }

        private void sellerCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
