
namespace CarManager_0323.UI
{
    partial class InstCarForm
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
            this.carPrice = new Sunny.UI.UITextBox();
            this.carCompany = new Sunny.UI.UITextBox();
            this.carColor = new Sunny.UI.UITextBox();
            this.carModel = new Sunny.UI.UITextBox();
            this.carCancel = new Sunny.UI.UISymbolButton();
            this.carOK = new Sunny.UI.UISymbolButton();
            this.email = new Sunny.UI.UISymbolLabel();
            this.addr = new Sunny.UI.UISymbolLabel();
            this.tel = new Sunny.UI.UISymbolLabel();
            this.name = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.carYear = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // carPrice
            // 
            this.carPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carPrice.FillColor = System.Drawing.Color.White;
            this.carPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carPrice.Location = new System.Drawing.Point(128, 288);
            this.carPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carPrice.Maximum = 2147483647D;
            this.carPrice.Minimum = -2147483648D;
            this.carPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.carPrice.Name = "carPrice";
            this.carPrice.Padding = new System.Windows.Forms.Padding(5);
            this.carPrice.Size = new System.Drawing.Size(308, 29);
            this.carPrice.TabIndex = 10;
            // 
            // carCompany
            // 
            this.carCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carCompany.FillColor = System.Drawing.Color.White;
            this.carCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carCompany.Location = new System.Drawing.Point(128, 230);
            this.carCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carCompany.Maximum = 2147483647D;
            this.carCompany.Minimum = -2147483648D;
            this.carCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.carCompany.Name = "carCompany";
            this.carCompany.Padding = new System.Windows.Forms.Padding(5);
            this.carCompany.Size = new System.Drawing.Size(308, 29);
            this.carCompany.TabIndex = 11;
            // 
            // carColor
            // 
            this.carColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carColor.FillColor = System.Drawing.Color.White;
            this.carColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carColor.Location = new System.Drawing.Point(128, 172);
            this.carColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carColor.Maximum = 2147483647D;
            this.carColor.Minimum = -2147483648D;
            this.carColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.carColor.Name = "carColor";
            this.carColor.Padding = new System.Windows.Forms.Padding(5);
            this.carColor.Size = new System.Drawing.Size(308, 29);
            this.carColor.TabIndex = 12;
            // 
            // carModel
            // 
            this.carModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carModel.FillColor = System.Drawing.Color.White;
            this.carModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carModel.Location = new System.Drawing.Point(128, 114);
            this.carModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carModel.Maximum = 2147483647D;
            this.carModel.Minimum = -2147483648D;
            this.carModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.carModel.Name = "carModel";
            this.carModel.Padding = new System.Windows.Forms.Padding(5);
            this.carModel.Size = new System.Drawing.Size(308, 29);
            this.carModel.TabIndex = 13;
            // 
            // carCancel
            // 
            this.carCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carCancel.Location = new System.Drawing.Point(252, 419);
            this.carCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.carCancel.Name = "carCancel";
            this.carCancel.Size = new System.Drawing.Size(131, 35);
            this.carCancel.Symbol = 61453;
            this.carCancel.TabIndex = 8;
            this.carCancel.Text = "취소";
            this.carCancel.Click += new System.EventHandler(this.carCancel_Click);
            // 
            // carOK
            // 
            this.carOK.BackColor = System.Drawing.Color.Transparent;
            this.carOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carOK.Location = new System.Drawing.Point(97, 419);
            this.carOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.carOK.Name = "carOK";
            this.carOK.Size = new System.Drawing.Size(131, 35);
            this.carOK.TabIndex = 9;
            this.carOK.Text = "추가";
            this.carOK.Click += new System.EventHandler(this.carOK_Click);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.email.Location = new System.Drawing.Point(27, 283);
            this.email.MinimumSize = new System.Drawing.Size(1, 1);
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.email.Size = new System.Drawing.Size(86, 38);
            this.email.Symbol = 57587;
            this.email.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.email.TabIndex = 4;
            this.email.Text = "가격";
            // 
            // addr
            // 
            this.addr.BackColor = System.Drawing.Color.Transparent;
            this.addr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addr.Location = new System.Drawing.Point(27, 225);
            this.addr.MinimumSize = new System.Drawing.Size(1, 1);
            this.addr.Name = "addr";
            this.addr.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.addr.Size = new System.Drawing.Size(86, 38);
            this.addr.Symbol = 61573;
            this.addr.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.addr.TabIndex = 5;
            this.addr.Text = "제조사";
            // 
            // tel
            // 
            this.tel.BackColor = System.Drawing.Color.Transparent;
            this.tel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tel.Location = new System.Drawing.Point(27, 167);
            this.tel.MinimumSize = new System.Drawing.Size(1, 1);
            this.tel.Name = "tel";
            this.tel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.tel.Size = new System.Drawing.Size(86, 38);
            this.tel.Symbol = 61947;
            this.tel.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.tel.TabIndex = 6;
            this.tel.Text = "색상";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.name.Location = new System.Drawing.Point(27, 109);
            this.name.MinimumSize = new System.Drawing.Size(1, 1);
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.name.Size = new System.Drawing.Size(86, 38);
            this.name.Style = Sunny.UI.UIStyle.Custom;
            this.name.Symbol = 61881;
            this.name.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.name.TabIndex = 7;
            this.name.Text = "모델명";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(27, 341);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(86, 38);
            this.uiSymbolLabel1.Symbol = 61747;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.uiSymbolLabel1.TabIndex = 4;
            this.uiSymbolLabel1.Text = "연식";
            // 
            // carYear
            // 
            this.carYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carYear.FillColor = System.Drawing.Color.White;
            this.carYear.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carYear.Location = new System.Drawing.Point(128, 346);
            this.carYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carYear.Maximum = 2147483647D;
            this.carYear.Minimum = -2147483648D;
            this.carYear.MinimumSize = new System.Drawing.Size(1, 1);
            this.carYear.Name = "carYear";
            this.carYear.Padding = new System.Windows.Forms.Padding(5);
            this.carYear.Size = new System.Drawing.Size(308, 29);
            this.carYear.TabIndex = 10;
            // 
            // InstCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 501);
            this.Controls.Add(this.carYear);
            this.Controls.Add(this.carPrice);
            this.Controls.Add(this.carCompany);
            this.Controls.Add(this.carColor);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.carCancel);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.carOK);
            this.Controls.Add(this.email);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.name);
            this.Name = "InstCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "차량 정보 추가";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox carPrice;
        private Sunny.UI.UITextBox carCompany;
        private Sunny.UI.UITextBox carColor;
        private Sunny.UI.UITextBox carModel;
        private Sunny.UI.UISymbolButton carCancel;
        private Sunny.UI.UISymbolButton carOK;
        private Sunny.UI.UISymbolLabel email;
        private Sunny.UI.UISymbolLabel addr;
        private Sunny.UI.UISymbolLabel tel;
        private Sunny.UI.UISymbolLabel name;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox carYear;
    }
}