
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.createTable = new Sunny.UI.UISymbolButton();
            this.deleteTable = new Sunny.UI.UISymbolButton();
            this.insertData = new Sunny.UI.UISymbolButton();
            this.insertCar = new Sunny.UI.UISymbolButton();
            this.insertSeller = new Sunny.UI.UISymbolButton();
            this.insertCustomer = new Sunny.UI.UISymbolButton();
            this.insertOrder = new Sunny.UI.UISymbolButton();
            this.programExit = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(1, 241);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(836, 279);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cxFlatPictureBox1.TabIndex = 0;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // createTable
            // 
            this.createTable.BackColor = System.Drawing.Color.Transparent;
            this.createTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTable.FillColor = System.Drawing.Color.Transparent;
            this.createTable.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.createTable.Location = new System.Drawing.Point(744, 28);
            this.createTable.MinimumSize = new System.Drawing.Size(1, 1);
            this.createTable.Name = "createTable";
            this.createTable.RectColor = System.Drawing.Color.Silver;
            this.createTable.Size = new System.Drawing.Size(32, 32);
            this.createTable.Style = Sunny.UI.UIStyle.Custom;
            this.createTable.Symbol = 61543;
            this.createTable.TabIndex = 1;
            this.createTable.Click += new System.EventHandler(this.createTable_Click);
            // 
            // deleteTable
            // 
            this.deleteTable.BackColor = System.Drawing.Color.Transparent;
            this.deleteTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteTable.FillColor = System.Drawing.Color.Transparent;
            this.deleteTable.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.deleteTable.Location = new System.Drawing.Point(795, 28);
            this.deleteTable.MinimumSize = new System.Drawing.Size(1, 1);
            this.deleteTable.Name = "deleteTable";
            this.deleteTable.RectColor = System.Drawing.Color.Silver;
            this.deleteTable.Size = new System.Drawing.Size(32, 32);
            this.deleteTable.Style = Sunny.UI.UIStyle.Custom;
            this.deleteTable.Symbol = 61544;
            this.deleteTable.TabIndex = 1;
            this.deleteTable.Click += new System.EventHandler(this.deleteTable_Click);
            // 
            // insertData
            // 
            this.insertData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertData.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertData.Location = new System.Drawing.Point(74, 93);
            this.insertData.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertData.Name = "insertData";
            this.insertData.Size = new System.Drawing.Size(170, 41);
            this.insertData.TabIndex = 2;
            this.insertData.Text = "데이터 추가";
            this.insertData.Click += new System.EventHandler(this.insertData_Click);
            // 
            // insertCar
            // 
            this.insertCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertCar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertCar.Location = new System.Drawing.Point(330, 93);
            this.insertCar.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertCar.Name = "insertCar";
            this.insertCar.Size = new System.Drawing.Size(170, 41);
            this.insertCar.TabIndex = 2;
            this.insertCar.Text = "차량 정보 추가";
            this.insertCar.Click += new System.EventHandler(this.insertCar_Click);
            // 
            // insertSeller
            // 
            this.insertSeller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertSeller.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertSeller.Location = new System.Drawing.Point(74, 167);
            this.insertSeller.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertSeller.Name = "insertSeller";
            this.insertSeller.Size = new System.Drawing.Size(170, 41);
            this.insertSeller.TabIndex = 2;
            this.insertSeller.Text = "판매자 정보 추가";
            this.insertSeller.Click += new System.EventHandler(this.insertSeller_Click);
            // 
            // insertCustomer
            // 
            this.insertCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertCustomer.Location = new System.Drawing.Point(586, 93);
            this.insertCustomer.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertCustomer.Name = "insertCustomer";
            this.insertCustomer.Size = new System.Drawing.Size(170, 41);
            this.insertCustomer.TabIndex = 2;
            this.insertCustomer.Text = "고객 정보 추가";
            this.insertCustomer.Click += new System.EventHandler(this.insertCustomer_Click);
            // 
            // insertOrder
            // 
            this.insertOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertOrder.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertOrder.Location = new System.Drawing.Point(330, 167);
            this.insertOrder.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertOrder.Name = "insertOrder";
            this.insertOrder.Size = new System.Drawing.Size(170, 41);
            this.insertOrder.TabIndex = 2;
            this.insertOrder.Text = "거래 정보 추가";
            this.insertOrder.Click += new System.EventHandler(this.insertOrder_Click);
            // 
            // programExit
            // 
            this.programExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.programExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.programExit.Location = new System.Drawing.Point(586, 167);
            this.programExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.programExit.Name = "programExit";
            this.programExit.Size = new System.Drawing.Size(170, 41);
            this.programExit.TabIndex = 2;
            this.programExit.Text = "프로그램 종료";
            this.programExit.Click += new System.EventHandler(this.programExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 522);
            this.Controls.Add(this.programExit);
            this.Controls.Add(this.insertOrder);
            this.Controls.Add(this.insertSeller);
            this.Controls.Add(this.insertCustomer);
            this.Controls.Add(this.insertCar);
            this.Controls.Add(this.insertData);
            this.Controls.Add(this.deleteTable);
            this.Controls.Add(this.createTable);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "차량 고객 관리 프로그램 v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UISymbolButton createTable;
        private Sunny.UI.UISymbolButton deleteTable;
        private Sunny.UI.UISymbolButton insertData;
        private Sunny.UI.UISymbolButton insertCar;
        private Sunny.UI.UISymbolButton insertSeller;
        private Sunny.UI.UISymbolButton insertCustomer;
        private Sunny.UI.UISymbolButton insertOrder;
        private Sunny.UI.UISymbolButton programExit;
    }
}

