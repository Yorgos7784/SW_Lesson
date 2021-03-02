using adressTest0218;
using adressTest0218.control;
using adressTest0218.util;
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
    partial class AddForm : MaterialForm
    {
        StudentCtrl sc;
        static Random r = new Random();
        RandomData rand = new RandomData(r);
        public AddForm(StudentCtrl sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void addOK_Click(object sender, EventArgs e)
        {
            if (addName.Text == "" || addTel.Text == "" || addAddr.Text == "" || addEmail.Text == "")
            {
                string[] textInfo = { addName.Text, addTel.Text, addAddr.Text, addEmail.Text };
                string[] textName = { name.Text, tel.Text, addr.Text, email.Text };
                List<string> textList= new List<string>();
                for (int i = 0; i < 4; i++)
                {
                    if(textInfo[i] == "")
                    {
                        if(i < 3)
                        {
                            textList.Add(textName[i]);
                            textList.Add(", ");
                        }
                        else
                        {
                            textList.Add(textName[i]);
                        }
                    }
                }
                string messageshow = null;
                for (int i = 0; i < textList.Count; i++)
                {
                    messageshow += textList[i];
                }

                MessageBox.Show(messageshow + "의 정보를 입력 해주세요.");
            }
            else
            {
                sc.getList().Add(new Student(rand.getId(), addName.Text, addTel.Text, addAddr.Text, addEmail.Text));
                MessageBox.Show("추가되었습니다!");
                Close();
            }
        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
