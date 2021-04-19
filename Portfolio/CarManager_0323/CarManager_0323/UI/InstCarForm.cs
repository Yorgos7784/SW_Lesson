using CarManager_0323.DB;
using CarManager_0323.Handler;
using CarManager_0323.Model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarManager_0323.UI
{
    partial class InstCarForm : MaterialForm
    {
        DaoOracle dao;
        List<Deal> list;
        public InstCarForm(DaoOracle dao)
        {
            InitializeComponent();
            this.dao = dao;
        }

        public InstCarForm(DaoOracle dao, List<Deal> list)
        {
            InitializeComponent();
            this.dao = dao;
            this.list = list;
        }

        public InstCarForm()
        {
            InitializeComponent();
        }

        private void carOK_Click(object sender, EventArgs e)
        {
            if (carModel.Text == "" || carColor.Text == "" || carCompany.Text == "" || carPrice.Text == "" || carYear.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n값을 입력해주세요.", "누락된 정보");
            }

            else
            {
                try
                {
                    Car car = new Car(carModel.Text, carColor.Text, carCompany.Text, Int32.Parse(carPrice.Text), carYear.Text);
                    dao.insertCar(car, list);
                    Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("잘못된 숫자 입력방식 입니다.", "잘못된 입력방식");
                }

            }
        }

        private void carCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
