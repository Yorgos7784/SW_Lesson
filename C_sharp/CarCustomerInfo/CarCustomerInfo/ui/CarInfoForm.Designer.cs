
namespace CarCustomerInfo.ui
{
    partial class CarInfoForm
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
            this.listView = new System.Windows.Forms.ListView();
            this.Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CarModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CarColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CarCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CarPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CarCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addCarInfo = new Sunny.UI.UISymbolButton();
            this.delCarInfo = new Sunny.UI.UISymbolButton();
            this.updateCarInfo = new Sunny.UI.UISymbolButton();
            this.carInfoExit = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Num,
            this.CarModel,
            this.CarColor,
            this.CarCompany,
            this.CarPrice,
            this.CarCustomer});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 108);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(541, 330);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Num
            // 
            this.Num.Text = "번호";
            this.Num.Width = 40;
            // 
            // CarModel
            // 
            this.CarModel.Text = "모델명";
            this.CarModel.Width = 79;
            // 
            // CarColor
            // 
            this.CarColor.Text = "색상";
            this.CarColor.Width = 98;
            // 
            // CarCompany
            // 
            this.CarCompany.Text = "제조사";
            this.CarCompany.Width = 107;
            // 
            // CarPrice
            // 
            this.CarPrice.Text = "가격";
            this.CarPrice.Width = 105;
            // 
            // CarCustomer
            // 
            this.CarCustomer.Text = "소유 고객";
            this.CarCustomer.Width = 103;
            // 
            // addCarInfo
            // 
            this.addCarInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarInfo.Location = new System.Drawing.Point(587, 90);
            this.addCarInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarInfo.Name = "addCarInfo";
            this.addCarInfo.Size = new System.Drawing.Size(184, 35);
            this.addCarInfo.Symbol = 61543;
            this.addCarInfo.TabIndex = 1;
            this.addCarInfo.Text = "차량 정보 추가";
            this.addCarInfo.Click += new System.EventHandler(this.addCarInfo_Click);
            // 
            // delCarInfo
            // 
            this.delCarInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delCarInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delCarInfo.Location = new System.Drawing.Point(587, 147);
            this.delCarInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.delCarInfo.Name = "delCarInfo";
            this.delCarInfo.Size = new System.Drawing.Size(184, 35);
            this.delCarInfo.Symbol = 61544;
            this.delCarInfo.TabIndex = 1;
            this.delCarInfo.Text = "차량 정보 삭제";
            this.delCarInfo.Click += new System.EventHandler(this.delCarInfo_Click);
            // 
            // updateCarInfo
            // 
            this.updateCarInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateCarInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updateCarInfo.Location = new System.Drawing.Point(587, 204);
            this.updateCarInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.updateCarInfo.Name = "updateCarInfo";
            this.updateCarInfo.Size = new System.Drawing.Size(184, 35);
            this.updateCarInfo.Symbol = 57399;
            this.updateCarInfo.TabIndex = 1;
            this.updateCarInfo.Text = "차량 정보 수정";
            this.updateCarInfo.Click += new System.EventHandler(this.updateCarInfo_Click);
            // 
            // carInfoExit
            // 
            this.carInfoExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carInfoExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carInfoExit.Location = new System.Drawing.Point(587, 371);
            this.carInfoExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.carInfoExit.Name = "carInfoExit";
            this.carInfoExit.Size = new System.Drawing.Size(184, 35);
            this.carInfoExit.Symbol = 61579;
            this.carInfoExit.TabIndex = 1;
            this.carInfoExit.Text = "돌아가기";
            this.carInfoExit.Click += new System.EventHandler(this.carInfoExit_Click);
            // 
            // CarInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.carInfoExit);
            this.Controls.Add(this.updateCarInfo);
            this.Controls.Add(this.delCarInfo);
            this.Controls.Add(this.addCarInfo);
            this.Controls.Add(this.listView);
            this.Name = "CarInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "차량 관리";
            this.Load += new System.EventHandler(this.carInfoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Num;
        private System.Windows.Forms.ColumnHeader CarModel;
        private System.Windows.Forms.ColumnHeader CarColor;
        private System.Windows.Forms.ColumnHeader CarCompany;
        private System.Windows.Forms.ColumnHeader CarPrice;
        private System.Windows.Forms.ColumnHeader CarCustomer;
        private Sunny.UI.UISymbolButton addCarInfo;
        private Sunny.UI.UISymbolButton delCarInfo;
        private Sunny.UI.UISymbolButton updateCarInfo;
        private Sunny.UI.UISymbolButton carInfoExit;
    }
}