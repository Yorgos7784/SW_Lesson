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
    partial class InstSellerForm : MaterialForm
    {
        DaoOracle dao;
        public InstSellerForm()
        {
            InitializeComponent();
        }

        public InstSellerForm(DaoOracle dao)
        {
            InitializeComponent();
            this.dao = dao;
        }

        private void sellerOK_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller(sellerName.Text, sellerTel.Text, sellerEmail.Text, sellerGrade.Text, sellerDerijum.Text); ;
            dao.insertSeller(seller);
            MessageBox.Show("추가되었습니다", "추가 완료");
            Close();
        }

        private void sellerCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
