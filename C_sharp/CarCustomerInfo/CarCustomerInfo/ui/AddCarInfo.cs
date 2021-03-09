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

namespace CarCustomerInfo.ui
{
    partial class AddCarInfo : MaterialForm
    {
        CarInfoCtrl ctrl;
        RandData rand = new RandData();
        public AddCarInfo(CarInfoCtrl ctrl)
        {
            InitializeComponent();
            this.ctrl = ctrl;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ctrl.addCarInfo(
                addModel.Text,
                addColor.Text,
                addCompany.Text,
                addPrice.Text,
                addName.Text);
            MessageBox.Show("추가되었습니다.", "추가 완료");
            Close();
        }

        private void randButton_Click(object sender, EventArgs e)
        {
            addModel.Text = rand.getModel();
            addColor.Text = rand.getColor ();
            addCompany.Text = rand.getComp();
            addPrice.Text = rand.getPrice();
            addName.Text = rand.getName();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
