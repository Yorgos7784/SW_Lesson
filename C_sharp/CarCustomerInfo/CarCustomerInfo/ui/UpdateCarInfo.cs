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
    partial class UpdateCarInfo : MaterialForm
    {
        CarInfoCtrl ctrl;
        private string name;
        private string model;
        List<Car> carList;
        int updateNum = 0;
        public UpdateCarInfo()
        {
            InitializeComponent();
        }

        public UpdateCarInfo(string model, string name, CarInfoCtrl ctrl)
        {
            InitializeComponent();
            this.model = model;
            this.name = name;
            this.ctrl = ctrl;
            carList = ctrl.getList();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateCarInfo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < carList.Count; i++)
            {
                if(carList[i].Model == model && carList[i].Customer.Name == name)
                {
                    updateModel.Text = carList[i].Model;
                    updateColor.Text = carList[i].Color;
                    updateCompany.Text = carList[i].Company;
                    updatePrice.Text = carList[i].Price;
                    updateName.Text = carList[i].Customer.Name;
                    updateNum = i;
                }
            }
        }
    }
}
