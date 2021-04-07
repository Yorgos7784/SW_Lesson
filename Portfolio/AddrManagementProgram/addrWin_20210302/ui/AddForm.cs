using adressTest0218;
using adressTest0218.control;
using adressTest0218.util;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace addrWin_20210302.ui
{
    partial class AddForm : MaterialForm
    {
        RandomData rand = new RandomData();
        StudentCtrl sc;

        public AddForm(StudentCtrl sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void addOK_Click(object sender, EventArgs e)
        {
            // 입력란이 비어있을 시
            if (addName.Text == "" || addTel.Text == "" || addAddr.Text == "" || addEmail.Text == "")
            {
                string[] textInfo = { addName.Text, addTel.Text, addAddr.Text, addEmail.Text };
                string[] textName = { name.Text, tel.Text, addr.Text, email.Text };
                List<string> textList = new List<string>();
                for (int i = 0; i < 4; i++)
                {
                    if (textInfo[i] == "")
                    {
                        textList.Add(textName[i]);
                        textList.Add(", ");
                    }
                }

                string messageshow = null;
                for (int i = 0; i < (textList.Count) - 1; i++)
                {
                    messageshow += textList[i];
                }

                MessageBox.Show(messageshow + "의 정보를 입력 해주세요.", "데이터 추가");
            }

            else
            {
                sc.getList().Add(new Student(rand.getId(), addName.Text, addTel.Text, addAddr.Text, addEmail.Text));
                MessageBox.Show("추가되었습니다!", "데이터 추가 완료");
                Close();
            }
        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
