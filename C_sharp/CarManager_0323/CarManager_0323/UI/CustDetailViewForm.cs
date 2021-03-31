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
    partial class CustDetailViewForm : MaterialForm
    {
        string cus_name;
        DaoOracle oracle;

        public CustDetailViewForm()
        {
            InitializeComponent();
        }
        
        public CustDetailViewForm(DaoOracle oracle, string cus_name)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.cus_name = cus_name;
        }

        private void CustDetailViewForm_Load(object sender, EventArgs e)
        {
            int count = oracle.cusCount("CUSTOMER_T", cus_name);
            if(count == 1)
            {
                Customer customer = oracle.selectCustomer(cus_name);
                cusName.Text = customer.Name;
                cusTel.Text = customer.Tel;
                cusAddr.Text = customer.Addr;
                cusEmail.Text = customer.Email;
            }

            else
            {

            }
        }
    }
}
