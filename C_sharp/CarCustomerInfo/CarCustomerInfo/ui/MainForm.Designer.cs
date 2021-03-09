
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
            this.cxFlatRoundButton1 = new CxFlatUI.CxFlatRoundButton();
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
            this.uiSymbolLabel1.Size = new System.Drawing.Size(180, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61882;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Green;
            this.uiSymbolLabel1.TabIndex = 0;
            this.uiSymbolLabel1.Text = "차량 관리 프로그램";
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
            // cxFlatRoundButton1
            // 
            this.cxFlatRoundButton1.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatRoundButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatRoundButton1.Location = new System.Drawing.Point(469, 80);
            this.cxFlatRoundButton1.Name = "cxFlatRoundButton1";
            this.cxFlatRoundButton1.Size = new System.Drawing.Size(100, 100);
            this.cxFlatRoundButton1.TabIndex = 2;
            this.cxFlatRoundButton1.Text = "cxFlatRoundButton1";
            this.cxFlatRoundButton1.TextColor = System.Drawing.Color.White;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cxFlatRoundButton1);
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
        private CxFlatUI.CxFlatRoundButton cxFlatRoundButton1;
    }
}