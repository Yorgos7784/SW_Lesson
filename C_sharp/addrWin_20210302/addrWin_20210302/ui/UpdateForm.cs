using adressTest0218.control;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace addrWin_20210302.ui
{
    partial class UpdateForm : MaterialForm
    {
        StudentCtrl sc;
        public UpdateForm(StudentCtrl sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void initGridView()
        {
            for (int i = 0; i < sc.getList().Count; i++)
            {
                updateGridView.Rows.Add(new string[]
                { (i + 1).ToString(),
                    sc.getList()[i].Name,
                    sc.getList()[i].Tel,
                    sc.getList()[i].Address,
                    sc.getList()[i].Email });
            }

            int count = updateGridView.Rows.Count - 1;
            updateGridView.FirstDisplayedScrollingRowIndex = count;
            updateGridView.CurrentCell = updateGridView.Rows[count - 1].Cells[0];
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            initGridView();
        }

        private void updateOk_Click(object sender, EventArgs e)
        {
            int count = 0;
            string name = updateInput.Text;
            string tel = null;

            for (int i = 0; i < sc.getList().Count; i++)
            {
                if (name == sc.getList()[i].Name)
                {
                    tel = sc.getList()[i].Tel;
                    count++;
                }
            }

            if (count == 1)
            {
                new UpdateDetail(name, tel, sc).ShowDialog();
                updateGridView.Rows.Clear();
                initGridView();
            }

            else if (count == 0)
                MessageBox.Show("일치하는 이름이 없습니다.", "일치하는 이름 없음");

            else
            {
                string inputTel = MainForm.myInputBox("수정할 사람의 전화번호를 입력하세요", "데이터 수정", "");
                bool telChecker = false;
                for (int i = 0; i < sc.getList().Count; i++)
                {
                    if (inputTel == sc.getList()[i].Tel)
                        telChecker = true;
                }
                if (telChecker)
                {
                    for (int i = 0; i < sc.getList().Count; i++)
                    {
                        if (name == sc.getList()[i].Name && sc.getList()[i].Tel == inputTel)
                        {
                            new UpdateDetail(name, inputTel, sc).ShowDialog();
                            updateGridView.Rows.Clear();
                            initGridView();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("없는 데이터입니다.", "데이터 존재하지 않음");
                }
            }
        }

        private void delExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
