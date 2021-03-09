
namespace addrWin_20210302.ui
{
    partial class UpdateForm
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
            this.upList = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updateEmail = new Sunny.UI.UITextBox();
            this.updateAddr = new Sunny.UI.UITextBox();
            this.updateTel = new Sunny.UI.UITextBox();
            this.updateName = new Sunny.UI.UITextBox();
            this.updateCancel = new Sunny.UI.UISymbolButton();
            this.updateOK = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // upList
            // 
            this.upList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.upList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.name,
            this.tel,
            this.addr,
            this.email});
            this.upList.FullRowSelect = true;
            this.upList.HideSelection = false;
            this.upList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.upList.Location = new System.Drawing.Point(12, 69);
            this.upList.Name = "upList";
            this.upList.Size = new System.Drawing.Size(794, 137);
            this.upList.TabIndex = 4;
            this.upList.UseCompatibleStateImageBehavior = false;
            this.upList.View = System.Windows.Forms.View.Details;
            this.upList.SelectedIndexChanged += new System.EventHandler(this.upList_SelectedIndexChanged);
            // 
            // num
            // 
            this.num.Text = "번호";
            this.num.Width = 40;
            // 
            // name
            // 
            this.name.Text = "이름";
            // 
            // tel
            // 
            this.tel.Text = "전화";
            this.tel.Width = 100;
            // 
            // addr
            // 
            this.addr.Text = "주소";
            this.addr.Width = 200;
            // 
            // email
            // 
            this.email.Text = "이메일";
            this.email.Width = 200;
            // 
            // updateEmail
            // 
            this.updateEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateEmail.FillColor = System.Drawing.Color.White;
            this.updateEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updateEmail.Location = new System.Drawing.Point(306, 415);
            this.updateEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateEmail.Maximum = 2147483647D;
            this.updateEmail.Minimum = -2147483648D;
            this.updateEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.updateEmail.Name = "updateEmail";
            this.updateEmail.Padding = new System.Windows.Forms.Padding(5);
            this.updateEmail.Size = new System.Drawing.Size(308, 29);
            this.updateEmail.TabIndex = 20;
            // 
            // updateAddr
            // 
            this.updateAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateAddr.FillColor = System.Drawing.Color.White;
            this.updateAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updateAddr.Location = new System.Drawing.Point(306, 355);
            this.updateAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateAddr.Maximum = 2147483647D;
            this.updateAddr.Minimum = -2147483648D;
            this.updateAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.updateAddr.Name = "updateAddr";
            this.updateAddr.Padding = new System.Windows.Forms.Padding(5);
            this.updateAddr.Size = new System.Drawing.Size(308, 29);
            this.updateAddr.TabIndex = 21;
            // 
            // updateTel
            // 
            this.updateTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateTel.FillColor = System.Drawing.Color.White;
            this.updateTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updateTel.Location = new System.Drawing.Point(306, 295);
            this.updateTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateTel.Maximum = 2147483647D;
            this.updateTel.Minimum = -2147483648D;
            this.updateTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.updateTel.Name = "updateTel";
            this.updateTel.Padding = new System.Windows.Forms.Padding(5);
            this.updateTel.Size = new System.Drawing.Size(308, 29);
            this.updateTel.TabIndex = 22;
            // 
            // updateName
            // 
            this.updateName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateName.FillColor = System.Drawing.Color.White;
            this.updateName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updateName.Location = new System.Drawing.Point(306, 235);
            this.updateName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateName.Maximum = 2147483647D;
            this.updateName.Minimum = -2147483648D;
            this.updateName.MinimumSize = new System.Drawing.Size(1, 1);
            this.updateName.Name = "updateName";
            this.updateName.Padding = new System.Windows.Forms.Padding(5);
            this.updateName.Size = new System.Drawing.Size(308, 29);
            this.updateName.TabIndex = 23;
            // 
            // updateCancel
            // 
            this.updateCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updateCancel.Location = new System.Drawing.Point(429, 486);
            this.updateCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.updateCancel.Name = "updateCancel";
            this.updateCancel.Size = new System.Drawing.Size(131, 35);
            this.updateCancel.Symbol = 61453;
            this.updateCancel.TabIndex = 18;
            this.updateCancel.Text = "취소";
            this.updateCancel.Click += new System.EventHandler(this.updateCancel_Click);
            // 
            // updateOK
            // 
            this.updateOK.BackColor = System.Drawing.Color.Transparent;
            this.updateOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updateOK.Location = new System.Drawing.Point(274, 486);
            this.updateOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.updateOK.Name = "updateOK";
            this.updateOK.Size = new System.Drawing.Size(131, 35);
            this.updateOK.TabIndex = 19;
            this.updateOK.Text = "수정";
            this.updateOK.Click += new System.EventHandler(this.updateOK_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(205, 410);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(86, 38);
            this.uiSymbolLabel1.Symbol = 61664;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.uiSymbolLabel1.TabIndex = 14;
            this.uiSymbolLabel1.Text = "메일";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(205, 350);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(86, 38);
            this.uiSymbolLabel2.Symbol = 61461;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.uiSymbolLabel2.TabIndex = 15;
            this.uiSymbolLabel2.Text = "주소";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(205, 290);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(86, 38);
            this.uiSymbolLabel3.Symbol = 62112;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.uiSymbolLabel3.TabIndex = 16;
            this.uiSymbolLabel3.Text = "전화";
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(205, 230);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(86, 38);
            this.uiSymbolLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel4.Symbol = 61447;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.uiSymbolLabel4.TabIndex = 17;
            this.uiSymbolLabel4.Text = "이름";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 542);
            this.Controls.Add(this.updateEmail);
            this.Controls.Add(this.updateAddr);
            this.Controls.Add(this.updateTel);
            this.Controls.Add(this.updateName);
            this.Controls.Add(this.updateCancel);
            this.Controls.Add(this.updateOK);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.upList);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 정보 수정";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView upList;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader tel;
        private System.Windows.Forms.ColumnHeader addr;
        private System.Windows.Forms.ColumnHeader email;
        private Sunny.UI.UITextBox updateEmail;
        private Sunny.UI.UITextBox updateAddr;
        private Sunny.UI.UITextBox updateTel;
        private Sunny.UI.UITextBox updateName;
        private Sunny.UI.UISymbolButton updateCancel;
        private Sunny.UI.UISymbolButton updateOK;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
    }
}