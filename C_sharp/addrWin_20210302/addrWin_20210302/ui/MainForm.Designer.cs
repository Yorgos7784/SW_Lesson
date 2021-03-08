
namespace addrWin_20210302
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addrAdd = new CxFlatUI.CxFlatSimpleButton();
            this.addrView = new CxFlatUI.CxFlatSimpleButton();
            this.addrAddRand = new CxFlatUI.CxFlatSimpleButton();
            this.addrDel = new CxFlatUI.CxFlatSimpleButton();
            this.addrDelAll = new CxFlatUI.CxFlatSimpleButton();
            this.addrUpdt = new CxFlatUI.CxFlatSimpleButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.addrHelp = new Sunny.UI.UISymbolButton();
            this.addrExit = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addrAdd
            // 
            this.addrAdd.BackColor = System.Drawing.Color.White;
            this.addrAdd.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrAdd.Location = new System.Drawing.Point(395, 154);
            this.addrAdd.Name = "addrAdd";
            this.addrAdd.Size = new System.Drawing.Size(168, 62);
            this.addrAdd.TabIndex = 6;
            this.addrAdd.Text = "주소록 추가";
            this.addrAdd.TextColor = System.Drawing.Color.White;
            this.addrAdd.Click += new System.EventHandler(this.addrAdd_Click);
            // 
            // addrView
            // 
            this.addrView.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrView.Location = new System.Drawing.Point(395, 330);
            this.addrView.Name = "addrView";
            this.addrView.Size = new System.Drawing.Size(168, 62);
            this.addrView.TabIndex = 6;
            this.addrView.Text = "정보 보기";
            this.addrView.TextColor = System.Drawing.Color.White;
            this.addrView.Click += new System.EventHandler(this.addrView_Click);
            // 
            // addrAddRand
            // 
            this.addrAddRand.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrAddRand.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrAddRand.Location = new System.Drawing.Point(395, 242);
            this.addrAddRand.Name = "addrAddRand";
            this.addrAddRand.Size = new System.Drawing.Size(168, 62);
            this.addrAddRand.TabIndex = 6;
            this.addrAddRand.Text = "주소록 랜덤 추가";
            this.addrAddRand.TextColor = System.Drawing.Color.White;
            this.addrAddRand.Click += new System.EventHandler(this.addrAddRand_Click);
            // 
            // addrDel
            // 
            this.addrDel.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrDel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrDel.Location = new System.Drawing.Point(583, 154);
            this.addrDel.Name = "addrDel";
            this.addrDel.Size = new System.Drawing.Size(168, 62);
            this.addrDel.TabIndex = 6;
            this.addrDel.Text = "주소록 정보 삭제";
            this.addrDel.TextColor = System.Drawing.Color.White;
            this.addrDel.Click += new System.EventHandler(this.addrDel_Click);
            // 
            // addrDelAll
            // 
            this.addrDelAll.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrDelAll.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrDelAll.Location = new System.Drawing.Point(583, 242);
            this.addrDelAll.Name = "addrDelAll";
            this.addrDelAll.Size = new System.Drawing.Size(168, 62);
            this.addrDelAll.TabIndex = 6;
            this.addrDelAll.Text = "전체 삭제";
            this.addrDelAll.TextColor = System.Drawing.Color.White;
            this.addrDelAll.Click += new System.EventHandler(this.addrDelAll_Click);
            // 
            // addrUpdt
            // 
            this.addrUpdt.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrUpdt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrUpdt.Location = new System.Drawing.Point(583, 330);
            this.addrUpdt.Name = "addrUpdt";
            this.addrUpdt.Size = new System.Drawing.Size(168, 62);
            this.addrUpdt.TabIndex = 6;
            this.addrUpdt.Text = "주소록 수정";
            this.addrUpdt.TextColor = System.Drawing.Color.White;
            this.addrUpdt.Click += new System.EventHandler(this.addrUpdt_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(1, 27);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(250, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 62142;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Gold;
            this.uiSymbolLabel1.TabIndex = 7;
            this.uiSymbolLabel1.Text = "주소록 관리 프로그램 v1.0";
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(-10, 91);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(405, 366);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 8;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // addrHelp
            // 
            this.addrHelp.BackColor = System.Drawing.Color.Transparent;
            this.addrHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrHelp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addrHelp.FillHoverColor = System.Drawing.Color.White;
            this.addrHelp.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addrHelp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addrHelp.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addrHelp.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addrHelp.IsCircle = true;
            this.addrHelp.Location = new System.Drawing.Point(725, 27);
            this.addrHelp.MinimumSize = new System.Drawing.Size(1, 1);
            this.addrHelp.Name = "addrHelp";
            this.addrHelp.RectColor = System.Drawing.Color.Transparent;
            this.addrHelp.RectDisableColor = System.Drawing.Color.Transparent;
            this.addrHelp.RectHoverColor = System.Drawing.Color.Transparent;
            this.addrHelp.RectPressColor = System.Drawing.Color.Transparent;
            this.addrHelp.RectSelectedColor = System.Drawing.Color.Transparent;
            this.addrHelp.Size = new System.Drawing.Size(35, 35);
            this.addrHelp.Style = Sunny.UI.UIStyle.Custom;
            this.addrHelp.Symbol = 61736;
            this.addrHelp.SymbolSize = 25;
            this.addrHelp.TabIndex = 9;
            this.addrHelp.Click += new System.EventHandler(this.addrHelp_Click);
            // 
            // addrExit
            // 
            this.addrExit.BackColor = System.Drawing.Color.Transparent;
            this.addrExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addrExit.FillHoverColor = System.Drawing.Color.White;
            this.addrExit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addrExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addrExit.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addrExit.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addrExit.IsCircle = true;
            this.addrExit.Location = new System.Drawing.Point(771, 27);
            this.addrExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.addrExit.Name = "addrExit";
            this.addrExit.RectColor = System.Drawing.Color.Transparent;
            this.addrExit.RectDisableColor = System.Drawing.Color.Transparent;
            this.addrExit.RectHoverColor = System.Drawing.Color.Transparent;
            this.addrExit.RectPressColor = System.Drawing.Color.Transparent;
            this.addrExit.RectSelectedColor = System.Drawing.Color.Transparent;
            this.addrExit.Size = new System.Drawing.Size(35, 35);
            this.addrExit.Style = Sunny.UI.UIStyle.Custom;
            this.addrExit.Symbol = 61457;
            this.addrExit.SymbolSize = 25;
            this.addrExit.TabIndex = 9;
            this.addrExit.Click += new System.EventHandler(this.addrExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 488);
            this.Controls.Add(this.addrExit);
            this.Controls.Add(this.addrHelp);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.addrUpdt);
            this.Controls.Add(this.addrDelAll);
            this.Controls.Add(this.addrDel);
            this.Controls.Add(this.addrAddRand);
            this.Controls.Add(this.addrView);
            this.Controls.Add(this.addrAdd);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatSimpleButton addrAdd;
        private CxFlatUI.CxFlatSimpleButton addrView;
        private CxFlatUI.CxFlatSimpleButton addrAddRand;
        private CxFlatUI.CxFlatSimpleButton addrDel;
        private CxFlatUI.CxFlatSimpleButton addrDelAll;
        private CxFlatUI.CxFlatSimpleButton addrUpdt;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UISymbolButton addrHelp;
        private Sunny.UI.UISymbolButton addrExit;
    }
}

