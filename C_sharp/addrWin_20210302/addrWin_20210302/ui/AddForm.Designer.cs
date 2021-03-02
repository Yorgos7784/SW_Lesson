
namespace addrWin_20210302.ui
{
    partial class AddForm
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
            this.name = new Sunny.UI.UISymbolLabel();
            this.tel = new Sunny.UI.UISymbolLabel();
            this.addr = new Sunny.UI.UISymbolLabel();
            this.email = new Sunny.UI.UISymbolLabel();
            this.addOK = new Sunny.UI.UISymbolButton();
            this.addCancel = new Sunny.UI.UISymbolButton();
            this.addName = new Sunny.UI.UITextBox();
            this.addTel = new Sunny.UI.UITextBox();
            this.addAddr = new Sunny.UI.UITextBox();
            this.addEmail = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.name.Location = new System.Drawing.Point(99, 103);
            this.name.MinimumSize = new System.Drawing.Size(1, 1);
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.name.Size = new System.Drawing.Size(86, 38);
            this.name.Style = Sunny.UI.UIStyle.Custom;
            this.name.Symbol = 61447;
            this.name.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.name.TabIndex = 0;
            this.name.Text = "이름";
            // 
            // tel
            // 
            this.tel.BackColor = System.Drawing.Color.Transparent;
            this.tel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tel.Location = new System.Drawing.Point(99, 163);
            this.tel.MinimumSize = new System.Drawing.Size(1, 1);
            this.tel.Name = "tel";
            this.tel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.tel.Size = new System.Drawing.Size(86, 38);
            this.tel.Symbol = 62112;
            this.tel.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.tel.TabIndex = 0;
            this.tel.Text = "전화";
            // 
            // addr
            // 
            this.addr.BackColor = System.Drawing.Color.Transparent;
            this.addr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addr.Location = new System.Drawing.Point(99, 223);
            this.addr.MinimumSize = new System.Drawing.Size(1, 1);
            this.addr.Name = "addr";
            this.addr.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.addr.Size = new System.Drawing.Size(86, 38);
            this.addr.Symbol = 61461;
            this.addr.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.addr.TabIndex = 0;
            this.addr.Text = "주소";
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.email.Location = new System.Drawing.Point(99, 283);
            this.email.MinimumSize = new System.Drawing.Size(1, 1);
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.email.Size = new System.Drawing.Size(86, 38);
            this.email.Symbol = 61664;
            this.email.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.email.TabIndex = 0;
            this.email.Text = "메일";
            // 
            // addOK
            // 
            this.addOK.BackColor = System.Drawing.Color.Transparent;
            this.addOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addOK.Location = new System.Drawing.Point(164, 359);
            this.addOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.addOK.Name = "addOK";
            this.addOK.Size = new System.Drawing.Size(131, 35);
            this.addOK.TabIndex = 2;
            this.addOK.Text = "추가";
            this.addOK.Click += new System.EventHandler(this.addOK_Click);
            // 
            // addCancel
            // 
            this.addCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCancel.Location = new System.Drawing.Point(319, 359);
            this.addCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCancel.Name = "addCancel";
            this.addCancel.Size = new System.Drawing.Size(131, 35);
            this.addCancel.Symbol = 61453;
            this.addCancel.TabIndex = 2;
            this.addCancel.Text = "취소";
            this.addCancel.Click += new System.EventHandler(this.addCancel_Click);
            // 
            // addName
            // 
            this.addName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addName.FillColor = System.Drawing.Color.White;
            this.addName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addName.Location = new System.Drawing.Point(200, 108);
            this.addName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addName.Maximum = 2147483647D;
            this.addName.Minimum = -2147483648D;
            this.addName.MinimumSize = new System.Drawing.Size(1, 1);
            this.addName.Name = "addName";
            this.addName.Padding = new System.Windows.Forms.Padding(5);
            this.addName.Size = new System.Drawing.Size(308, 29);
            this.addName.TabIndex = 3;
            // 
            // addTel
            // 
            this.addTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addTel.FillColor = System.Drawing.Color.White;
            this.addTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addTel.Location = new System.Drawing.Point(200, 168);
            this.addTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addTel.Maximum = 2147483647D;
            this.addTel.Minimum = -2147483648D;
            this.addTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addTel.Name = "addTel";
            this.addTel.Padding = new System.Windows.Forms.Padding(5);
            this.addTel.Size = new System.Drawing.Size(308, 29);
            this.addTel.TabIndex = 3;
            // 
            // addAddr
            // 
            this.addAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addAddr.FillColor = System.Drawing.Color.White;
            this.addAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addAddr.Location = new System.Drawing.Point(200, 228);
            this.addAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addAddr.Maximum = 2147483647D;
            this.addAddr.Minimum = -2147483648D;
            this.addAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.addAddr.Name = "addAddr";
            this.addAddr.Padding = new System.Windows.Forms.Padding(5);
            this.addAddr.Size = new System.Drawing.Size(308, 29);
            this.addAddr.TabIndex = 3;
            // 
            // addEmail
            // 
            this.addEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addEmail.FillColor = System.Drawing.Color.White;
            this.addEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addEmail.Location = new System.Drawing.Point(200, 288);
            this.addEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmail.Maximum = 2147483647D;
            this.addEmail.Minimum = -2147483648D;
            this.addEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.addEmail.Name = "addEmail";
            this.addEmail.Padding = new System.Windows.Forms.Padding(5);
            this.addEmail.Size = new System.Drawing.Size(308, 29);
            this.addEmail.TabIndex = 3;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 452);
            this.Controls.Add(this.addEmail);
            this.Controls.Add(this.addAddr);
            this.Controls.Add(this.addTel);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.addCancel);
            this.Controls.Add(this.addOK);
            this.Controls.Add(this.email);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.name);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 데이터 추가";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel name;
        private Sunny.UI.UISymbolLabel tel;
        private Sunny.UI.UISymbolLabel addr;
        private Sunny.UI.UISymbolLabel email;
        private Sunny.UI.UISymbolButton addOK;
        private Sunny.UI.UISymbolButton addCancel;
        private Sunny.UI.UITextBox addName;
        private Sunny.UI.UITextBox addTel;
        private Sunny.UI.UITextBox addAddr;
        private Sunny.UI.UITextBox addEmail;
    }
}