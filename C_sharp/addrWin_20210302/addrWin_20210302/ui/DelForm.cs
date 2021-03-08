using adressTest0218.control;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace addrWin_20210302.ui
{
    partial class delForm : MaterialForm
    {
        StudentCtrl sc;

        public delForm(StudentCtrl sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void delForm_Load(object sender, EventArgs e)
        {
            initGridView();
        }

        // 존재하는 데이터 보기
        private void initGridView()
        {
            for (int i = 0; i < sc.getList().Count; i++)
            {
                delGridView.Rows.Add(new string[]
                { (i + 1).ToString(),
                    sc.getList()[i].Name,
                    sc.getList()[i].Tel,
                    sc.getList()[i].Address,
                    sc.getList()[i].Email });
            }

            int count = delGridView.Rows.Count - 1;
            delGridView.FirstDisplayedScrollingRowIndex = count;
            delGridView.CurrentCell = delGridView.Rows[count - 1].Cells[0];
        }


        private void delOk_Click(object sender, EventArgs e)
        {
            // 입력받은 이름
            string delName = delInput.Text;
            int count = sc.counter(delName);

            if (count == 1)
            {
                DialogResult delItemdr = MainForm.getDialogResult(delName + "의 정보를 삭제하시겠습니까?", "데이터 삭제");
                if (delItemdr == DialogResult.Yes)
                {
                    sc.delItem(delName);
                    MessageBox.Show("삭제되었습니다.", "데이터 삭제 완료");
                    if (sc.getList().Count < 1)
                    {
                        MessageBox.Show("데이터가 없습니다.", "데이터 없음");
                        Close();
                    }
                    else
                    {
                        delGridView.Rows.Clear();
                        initGridView();
                    }
                }
                else if (delItemdr == DialogResult.No)
                    MessageBox.Show("취소되었습니다.", "데이터 삭제 취소");
            }

            else if(count > 1)
            {
                string delTel = MainForm.myInputBox("삭제할 사람의 전화번호를 입력하세요.", "데이터 삭제", "");
                bool telChecker = false;
                for (int i = 0; i < sc.getList().Count; i++)
                {
                    if (delTel == sc.getList()[i].Tel)
                        telChecker = true;
                }
                if (telChecker)
                {
                    for (int i = 0; i < sc.getList().Count; i++)
                    {
                        if (delName == sc.getList()[i].Name && sc.getList()[i].Tel == delTel)
                        {
                            DialogResult delItemdr = MainForm.getDialogResult(delName + "의 정보를 삭제하시겠습니까?", "데이터 삭제");
                            if (delItemdr == DialogResult.Yes)
                            {
                                sc.delItem(delName, delTel);
                                MessageBox.Show("삭제되었습니다.", "데이터 삭제 완료");

                                if (sc.getList().Count < 1)
                                {
                                    MessageBox.Show("데이터가 없습니다.", "데이터 없음");
                                    Close();
                                }

                                else
                                {
                                    delGridView.Rows.Clear();
                                    initGridView();
                                }
                            }
                            else if (delItemdr == DialogResult.No)
                                MessageBox.Show("취소되었습니다.", "데이터 삭제 취소");
                        }
                    }
                }
                else
                    MessageBox.Show("없는 데이터입니다.", "데이터 존재하지 않음" );
            }
            else if(count == 0)
                MessageBox.Show("없는 데이터입니다.", "데이터 존재하지 않음");
        }

        private void delExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}