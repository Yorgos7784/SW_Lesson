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
    public partial class MainForm : MaterialForm
    {
        CarInfoCtrl ctrl = new CarInfoCtrl();

        public MainForm()
        {
            InitializeComponent();
        }

        private void mainHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("차량/고객 괸리 프로그램\n" +
                "2021.03.09 by Yorgos\n" +
                "v 1.0000", "프로그램 정보");
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void carInfoButton_Click(object sender, EventArgs e)
        {
            new CarInfoForm(ctrl).ShowDialog();
        }

        public static DialogResult getDialogResult(string body, string title)
        {
            DialogResult dr = MessageBox.Show(body, title, MessageBoxButtons.YesNo);
            return dr;
        }
    }
}
