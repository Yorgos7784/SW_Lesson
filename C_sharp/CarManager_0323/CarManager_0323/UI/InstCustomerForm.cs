using CarManager_0323.DB;
using CarManager_0323.Handler;
using CarManager_0323.Model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarManager_0323.UI
{
    partial class InstCustomerForm : MaterialForm
    {
        DaoOracle dao;
        dealHandler oh;
        public InstCustomerForm()
        {
            InitializeComponent();
        }

        public InstCustomerForm(DaoOracle dao)
        {
            InitializeComponent();
            this.dao = dao;
        }
        
        public InstCustomerForm(DaoOracle dao, dealHandler oh)
        {
            InitializeComponent();
            this.dao = dao;
            this.oh = oh;
        }

        private void cusOK_Click(object sender, EventArgs e)
        {
            if (cusName.Text == "" || cusTel.Text == "" || cusAddr.Text == "" || cusEmail.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n값을 입력해주세요.", "누락된 정보");
            }
            else
            {
                List<Deal> list = oh.getOrderList();
                Customer customer = new Customer(cusName.Text, cusTel.Text, cusAddr.Text, cusEmail.Text);
                if(list[0].Customer == null)
                {
                    list[0].Customer = customer;
                    dao.insertCustomer(customer);
                    Close();
                }
                else
                {
                    MessageBox.Show("고객 정보가 이미 저장되었습니다.", "고객 추가 에러");
                    Close();
                }
            }
            
        }

        private void cusCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
