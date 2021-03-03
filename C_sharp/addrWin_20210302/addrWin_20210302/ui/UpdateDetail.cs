using adressTest0218.control;
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

namespace addrWin_20210302.ui
{
    public partial class UpdateDetail : MaterialForm
    {
        private int num;
        public UpdateDetail(int num)
        {
            InitializeComponent();
            this.num = num-1;
        }

        private void UpdateDetail_Load(object sender, EventArgs e)
        {
            updateName.Text = StudentCtrl.getInst().getList()[num].Name;
            updateTel.Text = StudentCtrl.getInst().getList()[num].Tel;
            updateAddr.Text = StudentCtrl.getInst().getList()[num].Address;
            updateEmail.Text = StudentCtrl.getInst().getList()[num].Email;
        }

        private void updateCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateConfirm_Click(object sender, EventArgs e)
        {
            StudentCtrl.getInst().updateItem(num, updateName.Text, updateTel.Text, updateAddr.Text, updateEmail.Text);
            MessageBox.Show("수정되었습니다.");
            Close();
        }
    }
}
