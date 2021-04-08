using MovieReviewProgram.Model;
using MovieReviewProgram.Oracle;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovieReviewProgram.UI
{
    partial class signUpForm : Form
    {
        DaoOracle oracle;
        List<User> users;
        public signUpForm()
        {
            InitializeComponent();
        }

        public signUpForm(DaoOracle oracle, List<User> users)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.users = users;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            User user = new User(idInput.Text, pwInput.Text);
            if (pwInput.Text == pwCheck.Text)
            {
                bool checker = true;
                for (int i = 0; i < users.Count; i++)
                {
                    if(users[i].Id == user.Id)
                        checker = false;
                }

                if (checker == true)
                {
                    oracle.insertUser(user);
                    Close();
                }
                else
                    MessageBox.Show("중복되는 아이디가 있습니다.", "아이디 중복");
            }
            else
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "비밀번호 오류");
        }
    }
}
