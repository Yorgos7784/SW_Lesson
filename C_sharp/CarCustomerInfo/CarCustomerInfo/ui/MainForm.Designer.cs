
namespace CarCustomerInfo.ui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.carInfoButton = new CxFlatUI.CxFlatRoundButton();
            this.customerInfoButton = new CxFlatUI.CxFlatRoundButton();
            this.infoViewButton = new CxFlatUI.CxFlatRoundButton();
            this.mainHelp = new CxFlatUI.Controls.CxFlatButton();
            this.mainExit = new CxFlatUI.Controls.CxFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(4, 27);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(223, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61882;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Green;
            this.uiSymbolLabel1.TabIndex = 0;
            this.uiSymbolLabel1.Text = "차량/고객 관리 프로그램";
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(40, 67);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(404, 381);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cxFlatPictureBox1.TabIndex = 1;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // carInfoButton
            // 
            this.carInfoButton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.carInfoButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.carInfoButton.Location = new System.Drawing.Point(482, 85);
            this.carInfoButton.Name = "carInfoButton";
            this.carInfoButton.Size = new System.Drawing.Size(124, 39);
            this.carInfoButton.TabIndex = 2;
            this.carInfoButton.Text = "차량 관리";
            this.carInfoButton.TextColor = System.Drawing.Color.White;
            this.carInfoButton.Click += new System.EventHandler(this.carInfoButton_Click);
            // 
            // customerInfoButton
            // 
            this.customerInfoButton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.customerInfoButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.customerInfoButton.Location = new System.Drawing.Point(482, 142);
            this.customerInfoButton.Name = "customerInfoButton";
            this.customerInfoButton.Size = new System.Drawing.Size(124, 39);
            this.customerInfoButton.TabIndex = 2;
            this.customerInfoButton.Text = "고객 정보";
            this.customerInfoButton.TextColor = System.Drawing.Color.White;
            // 
            // infoViewButton
            // 
            this.infoViewButton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.infoViewButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.infoViewButton.Location = new System.Drawing.Point(482, 203);
            this.infoViewButton.Name = "infoViewButton";
            this.infoViewButton.Size = new System.Drawing.Size(124, 39);
            this.infoViewButton.TabIndex = 2;
            this.infoViewButton.Text = "정보 조회";
            this.infoViewButton.TextColor = System.Drawing.Color.White;
            // 
            // mainHelp
            // 
            this.mainHelp.BackColor = System.Drawing.Color.White;
            this.mainHelp.ButtonType = CxFlatUI.ButtonType.Primary;
            this.mainHelp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainHelp.Location = new System.Drawing.Point(553, 382);
            this.mainHelp.Name = "mainHelp";
            this.mainHelp.Size = new System.Drawing.Size(75, 23);
            this.mainHelp.TabIndex = 3;
            this.mainHelp.Text = "도움말";
            this.mainHelp.TextColor = System.Drawing.Color.White;
            this.mainHelp.Click += new System.EventHandler(this.mainHelp_Click);
            // 
            // mainExit
            // 
            this.mainExit.ButtonType = CxFlatUI.ButtonType.Primary;
            this.mainExit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainExit.Location = new System.Drawing.Point(553, 411);
            this.mainExit.Name = "mainExit";
            this.mainExit.Size = new System.Drawing.Size(75, 23);
            this.mainExit.TabIndex = 3;
            this.mainExit.Text = "나가기";
            this.mainExit.TextColor = System.Drawing.Color.White;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.mainHelp);
            this.Controls.Add(this.infoViewButton);
            this.Controls.Add(this.customerInfoButton);
            this.Controls.Add(this.carInfoButton);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private CxFlatUI.CxFlatRoundButton carInfoButton;
        private CxFlatUI.CxFlatRoundButton customerInfoButton;
        private CxFlatUI.CxFlatRoundButton infoViewButton;
        private CxFlatUI.Controls.CxFlatButton mainHelp;
        private CxFlatUI.Controls.CxFlatButton mainExit;
    }
}