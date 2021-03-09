
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
            this.addrView = new CxFlatUI.CxFlatSimpleButton();
            this.programTitle = new Sunny.UI.UISymbolLabel();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.addrHelp = new CxFlatUI.CxFlatSimpleButton();
            this.addrExit = new CxFlatUI.CxFlatSimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addrView
            // 
            this.addrView.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrView.Location = new System.Drawing.Point(401, 146);
            this.addrView.Name = "addrView";
            this.addrView.Size = new System.Drawing.Size(168, 62);
            this.addrView.TabIndex = 6;
            this.addrView.Text = "주소록 관리";
            this.addrView.TextColor = System.Drawing.Color.White;
            this.addrView.Click += new System.EventHandler(this.addrView_Click);
            // 
            // programTitle
            // 
            this.programTitle.BackColor = System.Drawing.Color.Transparent;
            this.programTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.programTitle.ForeColor = System.Drawing.Color.White;
            this.programTitle.Location = new System.Drawing.Point(1, 27);
            this.programTitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.programTitle.Name = "programTitle";
            this.programTitle.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.programTitle.Size = new System.Drawing.Size(250, 35);
            this.programTitle.Style = Sunny.UI.UIStyle.Custom;
            this.programTitle.Symbol = 62142;
            this.programTitle.SymbolColor = System.Drawing.Color.Gold;
            this.programTitle.TabIndex = 7;
            this.programTitle.Text = "주소록 관리 프로그램 v1.0";
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(-10, 68);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(405, 418);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cxFlatPictureBox1.TabIndex = 8;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // addrHelp
            // 
            this.addrHelp.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrHelp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrHelp.Location = new System.Drawing.Point(401, 238);
            this.addrHelp.Name = "addrHelp";
            this.addrHelp.Size = new System.Drawing.Size(168, 62);
            this.addrHelp.TabIndex = 6;
            this.addrHelp.Text = "프로그램 정보";
            this.addrHelp.TextColor = System.Drawing.Color.White;
            this.addrHelp.Click += new System.EventHandler(this.addrHelp_Click);
            // 
            // addrExit
            // 
            this.addrExit.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrExit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrExit.Location = new System.Drawing.Point(401, 330);
            this.addrExit.Name = "addrExit";
            this.addrExit.Size = new System.Drawing.Size(168, 62);
            this.addrExit.TabIndex = 6;
            this.addrExit.Text = "종료";
            this.addrExit.TextColor = System.Drawing.Color.White;
            this.addrExit.Click += new System.EventHandler(this.addrExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 488);
            this.Controls.Add(this.programTitle);
            this.Controls.Add(this.addrExit);
            this.Controls.Add(this.addrHelp);
            this.Controls.Add(this.addrView);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CxFlatUI.CxFlatSimpleButton addrView;
        private Sunny.UI.UISymbolLabel programTitle;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private CxFlatUI.CxFlatSimpleButton addrHelp;
        private CxFlatUI.CxFlatSimpleButton addrExit;
    }
}

