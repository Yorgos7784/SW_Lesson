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
    partial class InstCarForm : MaterialForm
    {
        DaoOracle dao;
        public InstCarForm(DaoOracle dao)
        {
            InitializeComponent();
            this.dao = dao;
        }

        public InstCarForm()
        {
            InitializeComponent();
        }

        private void carOK_Click(object sender, EventArgs e)
        {
            Car car = new Car(carModel.Text, carColor.Text, carCompany.Text, Int32.Parse(carPrice.Text), carYear.Text);
            dao.insertCar(car);
            MessageBox.Show("추가되었습니다", "추가 완료");
            Close();
        }

        private void carCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
