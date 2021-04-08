
namespace MovieReviewProgram
{
    partial class LogInForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.programExit = new Sunny.UI.UISymbolButton();
            this.idInput = new CxFlatUI.CxFlatTextBox();
            this.pwInput = new CxFlatUI.CxFlatTextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.logInBtn = new Sunny.UI.UISymbolButton();
            this.signUpBtn = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(-2, -63);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(503, 671);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 0;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Newtext Bk BT", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(115, 82);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(272, 118);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "Log In";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // programExit
            // 
            this.programExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.programExit.FillColor = System.Drawing.Color.Maroon;
            this.programExit.FillHoverColor = System.Drawing.Color.Brown;
            this.programExit.FillPressColor = System.Drawing.Color.Maroon;
            this.programExit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.programExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.programExit.Location = new System.Drawing.Point(351, 62);
            this.programExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.programExit.Name = "programExit";
            this.programExit.RectColor = System.Drawing.Color.Maroon;
            this.programExit.RectHoverColor = System.Drawing.Color.Brown;
            this.programExit.RectPressColor = System.Drawing.Color.Maroon;
            this.programExit.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.programExit.Size = new System.Drawing.Size(71, 35);
            this.programExit.Style = Sunny.UI.UIStyle.Custom;
            this.programExit.Symbol = 61457;
            this.programExit.TabIndex = 2;
            this.programExit.Text = "Exit";
            this.programExit.Click += new System.EventHandler(this.programExit_Click);
            // 
            // idInput
            // 
            this.idInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idInput.Hint = "";
            this.idInput.Location = new System.Drawing.Point(198, 216);
            this.idInput.MaxLength = 32767;
            this.idInput.Multiline = false;
            this.idInput.Name = "idInput";
            this.idInput.PasswordChar = '\0';
            this.idInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idInput.SelectedText = "";
            this.idInput.SelectionLength = 0;
            this.idInput.SelectionStart = 0;
            this.idInput.Size = new System.Drawing.Size(164, 38);
            this.idInput.TabIndex = 1;
            this.idInput.TabStop = false;
            this.idInput.UseSystemPasswordChar = false;
            // 
            // pwInput
            // 
            this.pwInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pwInput.Hint = "";
            this.pwInput.Location = new System.Drawing.Point(198, 274);
            this.pwInput.MaxLength = 32767;
            this.pwInput.Multiline = false;
            this.pwInput.Name = "pwInput";
            this.pwInput.PasswordChar = '\0';
            this.pwInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pwInput.SelectedText = "";
            this.pwInput.SelectionLength = 0;
            this.pwInput.SelectionStart = 0;
            this.pwInput.Size = new System.Drawing.Size(164, 38);
            this.pwInput.TabIndex = 2;
            this.pwInput.TabStop = false;
            this.pwInput.UseSystemPasswordChar = false;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Newtext Bk BT", 20F, System.Drawing.FontStyle.Bold);
            this.uiLabel2.Location = new System.Drawing.Point(134, 219);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(52, 32);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "ID";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("Newtext Bk BT", 20F, System.Drawing.FontStyle.Bold);
            this.uiLabel3.Location = new System.Drawing.Point(129, 277);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(63, 32);
            this.uiLabel3.TabIndex = 1;
            this.uiLabel3.Text = "PW";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logInBtn
            // 
            this.logInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.logInBtn.Location = new System.Drawing.Point(134, 355);
            this.logInBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(100, 35);
            this.logInBtn.TabIndex = 4;
            this.logInBtn.Text = "Log In";
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.signUpBtn.Location = new System.Drawing.Point(262, 355);
            this.signUpBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(100, 35);
            this.signUpBtn.Symbol = 61543;
            this.signUpBtn.TabIndex = 4;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 504);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.pwInput);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.programExit);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LonInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolButton programExit;
        private CxFlatUI.CxFlatTextBox idInput;
        private CxFlatUI.CxFlatTextBox pwInput;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UISymbolButton logInBtn;
        private Sunny.UI.UISymbolButton signUpBtn;
    }
}

