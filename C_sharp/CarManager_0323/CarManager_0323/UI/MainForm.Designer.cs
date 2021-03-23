
namespace CarManager_0323
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
            this.createTBBtn = new Sunny.UI.UIButton();
            this.dropTBBtn = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // createTBBtn
            // 
            this.createTBBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTBBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.createTBBtn.Location = new System.Drawing.Point(557, 193);
            this.createTBBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.createTBBtn.Name = "createTBBtn";
            this.createTBBtn.Size = new System.Drawing.Size(100, 35);
            this.createTBBtn.TabIndex = 0;
            this.createTBBtn.Text = "테이블 생성";
            this.createTBBtn.Click += new System.EventHandler(this.createTBBtn_Click);
            // 
            // dropTBBtn
            // 
            this.dropTBBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropTBBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dropTBBtn.Location = new System.Drawing.Point(557, 269);
            this.dropTBBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.dropTBBtn.Name = "dropTBBtn";
            this.dropTBBtn.Size = new System.Drawing.Size(100, 35);
            this.dropTBBtn.TabIndex = 0;
            this.dropTBBtn.Text = "테이블 삭제";
            this.dropTBBtn.Click += new System.EventHandler(this.dropTBBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dropTBBtn);
            this.Controls.Add(this.createTBBtn);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "차량 관리 프로그램 v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton createTBBtn;
        private Sunny.UI.UIButton dropTBBtn;
    }
}

