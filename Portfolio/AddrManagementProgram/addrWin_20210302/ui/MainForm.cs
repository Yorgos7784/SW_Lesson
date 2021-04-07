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
    }
}
