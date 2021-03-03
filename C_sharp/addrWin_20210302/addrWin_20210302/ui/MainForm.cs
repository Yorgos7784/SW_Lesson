using addrWin_20210302.ui;
using adressTest0218.control;
using adressTest0218.view;
using MaterialSkin.Controls;
using System;
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
            new AddForm().ShowDialog();
        }

        private void addrAddRand_Click(object sender, EventArgs e)
        {
            string cnt = myInputBox("랜덤 데이터를 생성할 갯수를 입력하세요", "랜덤 데이터 생성", "0");
            if (cnt == "") return;
            StudentCtrl.getInst().randData(Convert.ToInt32(cnt));
            MessageBox.Show("추가되었습니다!");
        }

        private void addrView_Click(object sender, EventArgs e)
        {
            if(StudentCtrl.getInst().getList().Count < 1)
            {
                MessageBox.Show("데이터가 없습니다.");
            }
            else
            {
                //StudentCtrl.getInst().viewItem();
                new viewForm().ShowDialog();
            }
        }

        private void addrDel_Click(object sender, EventArgs e)
        {
            if (StudentCtrl.getInst().getList().Count < 1)
            {
                MessageBox.Show("데이터가 없습니다.");
            }
            else
            {
                //StudentCtrl.getInst().delItem();
                new delForm().ShowDialog();
            }
            
        }

        private void addrDelAll_Click(object sender, EventArgs e)
        {
            StudentCtrl.getInst().delItemAll();
            MessageBox.Show("삭제되었습니다.");
        }

        private void addrUpdt_Click(object sender, EventArgs e)
        {
            if (StudentCtrl.getInst().getList().Count < 1)
            {
                MessageBox.Show("데이터가 없습니다.");
            }
            else
            {
                //StudentCtrl.getInst().delItem();
                new UpdateForm().ShowDialog();
            }
        }

        private string myInputBox(string title, string body, string prompt)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(title, body, prompt, -1, -1);
            return input;
        }
    }
}
