using CarManager_0323.DB;
using CarManager_0323.Model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager_0323.UI
{
    partial class InstCustomerForm : MaterialForm
    {
        DaoOracle dao;
        public InstCustomerForm()
        {
            InitializeComponent();
        }

        public InstCustomerForm(DaoOracle dao)
        {
            InitializeComponent();
            this.dao = dao;
        }

        private void cusOK_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(cusName.Text, cusTel.Text, cusAddr.Text, cusEmail.Text);
            dao.insertCustomer(customer);
            MessageBox.Show("추가되었습니다", "추가 완료");
            Close();
        }

        private void cusCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
