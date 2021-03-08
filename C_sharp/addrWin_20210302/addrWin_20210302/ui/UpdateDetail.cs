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
    partial class UpdateDetail : MaterialForm
    {
        private string inputname;
        private string inputtel;
        public int num;
        StudentCtrl sc;

        public UpdateDetail(string name, string tel, StudentCtrl sc)
        {
            InitializeComponent();
            this.inputname = name;
            this.inputtel = tel;
            this.sc = sc;
        }

        private void UpdateDetail_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < sc.getList().Count; i++)
            {
                if(sc.getList()[i].Name == inputname && sc.getList()[i].Tel== inputtel)
                {
                    num = i;
                    updateName.Text = sc.getList()[i].Name;
                    updateTel.Text = sc.getList()[i].Tel;
                    updateAddr.Text = sc.getList()[i].Address;
                    updateEmail.Text = sc.getList()[i].Email;
                }
            }
        }

        private void updateCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateConfirm_Click(object sender, EventArgs e)
        {
            sc.updateItem(num, updateName.Text, updateTel.Text, updateAddr.Text, updateEmail.Text);
            MessageBox.Show("수정되었습니다.", "데이터 수정 완료");
            Close();
        }
    }
}
