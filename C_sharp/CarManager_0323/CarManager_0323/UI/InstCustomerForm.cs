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
        List<Deal> list;
        public InstCustomerForm()
        {
            InitializeComponent();
        }

        public InstCustomerForm(DaoOracle dao)
        {
            InitializeComponent();
            this.dao = dao;
        }

        public InstCustomerForm(DaoOracle dao, List<Deal> list)
        {
            InitializeComponent();
            this.dao = dao;
            this.list = list;
        }

        private void cusOK_Click(object sender, EventArgs e)
        {
            if (cusName.Text == "" || cusTel.Text == "" || cusAddr.Text == "" || cusEmail.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n값을 입력해주세요.", "누락된 정보");
            }
            else
            {
                Customer customer = new Customer(cusName.Text, cusTel.Text, cusAddr.Text, cusEmail.Text);
                dao.insertCustomer(customer, list);
                Close();
            }

        }

        private void cusCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
