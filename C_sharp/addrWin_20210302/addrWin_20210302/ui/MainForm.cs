using addrWin_20210302.ui;
using adressTest0218.control;
using adressTest0218.view;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            //initFont();
        }

        // 나가기 버튼
        private void addrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 정보보기 버튼
        private void addrHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update 2021.03.09 by Yorgos7784", "프로그램 정보");
        }

        // 데이터 보기
        private void addrView_Click(object sender, EventArgs e)
        {
            new viewForm(sc).ShowDialog();
        }
        
        // 메시지 입력 박스
        public static string myInputBox(string body, string title, string prompt)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(body, title, prompt, -1, -1);
            return input;
        }

        // 예/아니오 메시지 박스
        public static DialogResult getDialogResult(string body, string title)
        {
            DialogResult dr = MessageBox.Show(body, title, MessageBoxButtons.YesNo);
            return dr;
        }

        // 외부 폰트 적용
        private void initFont()
        {
            PrivateFontCollection pFont = new PrivateFontCollection();
            pFont.AddFontFile("Cinema.ttf");
            Font font = new Font(pFont.Families[0], 12f);
            addrView.Font = font;
            addrHelp.Font = font;
            addrExit.Font = font;
            programTitle.Font = font;
        }

        /*// 데이터 추가
        private void addrAdd_Click(object sender, EventArgs e)
        {
            // sc.addItem();
            new AddForm(sc).ShowDialog();
        }

        // 랜덤 데이터 추가
        private void addrAddRand_Click(object sender, EventArgs e)
        {
            string cnt = myInputBox("랜덤 데이터를 생성할 갯수를 입력하세요", "랜덤 데이터 생성", "0");
            if (cnt == "") return;
            //StudentCtrl.getInst().randData(Convert.ToInt32(cnt));
            sc.randData(Convert.ToInt32(cnt));
            MessageBox.Show("추가되었습니다!", "랜덤 데이터 추가 완료");
        }

        // 데이터 삭제
        private void addrDel_Click(object sender, EventArgs e)
        {
            if (sc.getList().Count < 1)
            {
                MessageBox.Show("데이터가 없습니다.", "데이터 없음");
            }
            else
            {
                //StudentCtrl.getInst().delItem();
                new delForm(sc).ShowDialog();
            }

        }

        // 데이터 전체 삭제
        private void addrDelAll_Click(object sender, EventArgs e)
        {
            DialogResult delAlldr = getDialogResult("전체 데이터를 삭제하시겠습니까?", "데이터 삭제");
            if (delAlldr == DialogResult.Yes)
            {
                sc.delItemAll();
                MessageBox.Show("삭제되었습니다.", "삭제 완료");
            }
            else if (delAlldr == DialogResult.No)
            {
                MessageBox.Show("취소되었습니다.", "데이터 삭제 취소");
            }
        }

        // 데이터 수정
        private void addrUpdt_Click(object sender, EventArgs e)
        {
            if (sc.getList().Count < 1)
            {
                MessageBox.Show("데이터가 없습니다.", "데이터 없음");
            }
            else
            {
                //StudentCtrl.getInst().delItem();
                new UpdateForm(sc).ShowDialog();
            }
        }*/
    }
}
