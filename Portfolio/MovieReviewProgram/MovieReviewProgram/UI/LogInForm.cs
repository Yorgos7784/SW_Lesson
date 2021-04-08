using MovieReviewProgram.Model;
using MovieReviewProgram.Oracle;
using MovieReviewProgram.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieReviewProgram
{
    public partial class LogInForm : Form
    {
        DaoOracle oracle;
        List<User> users;
        public LogInForm()
        {
            InitializeComponent();
            oracle = new DaoOracle();
            users = oracle.selectUsers();
        }

        private void programExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LonInForm_Load(object sender, EventArgs e)
        {
            //oracle.makeUserTable();
            //oracle.insertUser(new User("ghkd7784", "whysoserious7784"));
        }

        private void dropTable_Click(object sender, EventArgs e)
        {
            oracle.dropTables("LOGIN_T");
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            new signUpForm(oracle, users).ShowDialog();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            bool checker = false;
            foreach (var item in users)
            {
                if(item.Id == idInput.Text && item.Pw == pwInput.Text)
                    checker = true;
            }

            if(checker == true)
            {
                MessageBox.Show("로그인 성공!");
                new MainForm().ShowDialog();
            }

            else
                MessageBox.Show("아이디 또는 비밀번호가 틀립니다.");
        }
    }
}
