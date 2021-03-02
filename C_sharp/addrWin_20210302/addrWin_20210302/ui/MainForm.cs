using addrWin_20210302.ui;
using adressTest0218.control;
using adressTest0218.view;
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

namespace addrWin_20210302
{
    public partial class MainForm : MaterialForm
    {
        MyMenu menu = new MyMenu();
        StudentCtrl sc = new StudentCtrl();

        public MainForm()
        {
            InitializeComponent();
        }

        private void addrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addrHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update 2021.03.02. by Yorgos7784");
        }

        private void addrAdd_Click(object sender, EventArgs e)
        {
            // sc.addItem();
            new AddForm(sc).ShowDialog();
        }

        private void addrAddRand_Click(object sender, EventArgs e)
        {
            sc.randData();
        }

        private void addrView_Click(object sender, EventArgs e)
        {
            sc.viewItem();
        }

        private void addrDel_Click(object sender, EventArgs e)
        {
            sc.delItem();
        }

        private void addrDelAll_Click(object sender, EventArgs e)
        {
            sc.delItemAll();
        }

        private void addrUpdt_Click(object sender, EventArgs e)
        {

        }
    }
}
