
namespace addrWin_20210302.ui
{
    partial class UpdateDetail
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
            this.updateEmail = new Sunny.UI.UITextBox();
            this.updateAddr = new Sunny.UI.UITextBox();
            this.updateTel = new Sunny.UI.UITextBox();
            this.updateName = new Sunny.UI.UITextBox();
            this.updateCancel = new Sunny.UI.UISymbolButton();
            this.updateConfirm = new Sunny.UI.UISymbolButton();
            this.email = new Sunny.UI.UISymbolLabel();
            this.addr = new Sunny.UI.UISymbolLabel();
            this.tel = new Sunny.UI.UISymbolLabel();
            this.name = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // updateEmail
            // 
            this.updateEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateEmail.FillColor = System.Drawing.Color.White;
            this.updateEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updateEmail.Location = new System.Drawing.Point(120, 276);
            this.updateEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateEmail.Maximum = 2147483647D;
            this.updateEmail.Minimum = -2147483648D;
            this.updateEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.updateEmail.Name = "updateEmail";
            this.updateEmail.Padding = new System.Windows.Forms.Padding(5);
            this.updateEmail.Size = new System.Drawing.Size(308, 29);
            this.updateEmail.TabIndex = 10;
            // 
            // updateAddr
            // 
            this.updateAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateAddr.FillColor = System.Drawing.Color.White;
            this.updateAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updateAddr.Location = new System.Drawing.Point(120, 216);
            this.updateAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateAddr.Maximum = 2147483647D;
            this.updateAddr.Minimum = -2147483648D;
            this.updateAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.updateAddr.Name = "updateAddr";
            this.updateAddr.Padding = new System.Windows.Forms.Padding(5);
            this.updateAddr.Size = new System.Drawing.Size(308, 29);
            this.updateAddr.TabIndex = 11;
            // 
            // updateTel
            // 
            this.updateTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateTel.FillColor = System.Drawing.Color.White;
            this.updateTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updateTel.Location = new System.Drawing.Point(120, 156);
            this.updateTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateTel.Maximum = 2147483647D;
            this.updateTel.Minimum = -2147483648D;
            this.updateTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.updateTel.Name = "updateTel";
            this.updateTel.Padding = new System.Windows.Forms.Padding(5);
            this.updateTel.Size = new System.Drawing.Size(308, 29);
            this.updateTel.TabIndex = 12;
            // 
            // updateName
            // 
            this.updateName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateName.FillColor = System.Drawing.Color.White;
            this.updateName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updateName.Location = new System.Drawing.Point(120, 96);
            this.updateName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateName.Maximum = 2147483647D;
            this.updateName.Minimum = -2147483648D;
            this.updateName.MinimumSize = new System.Drawing.Size(1, 1);
            this.updateName.Name = "updateName";
            this.updateName.Padding = new System.Windows.Forms.Padding(5);
            this.updateName.Size = new System.Drawing.Size(308, 29);
            this.updateName.TabIndex = 13;
            // 
            // updateCancel
            // 
            this.updateCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updateCancel.Location = new System.Drawing.Point(239, 347);
            this.updateCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.updateCancel.Name = "updateCancel";
            this.updateCancel.Size = new System.Drawing.Size(131, 35);
            this.updateCancel.Symbol = 61453;
            this.updateCancel.TabIndex = 8;
            this.updateCancel.Text = "취소";
            this.updateCancel.Click += new System.EventHandler(this.updateCancel_Click);
            // 
            // updateConfirm
            // 
            this.updateConfirm.BackColor = System.Drawing.Color.Transparent;
            this.updateConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateConfirm.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updateConfirm.Location = new System.Drawing.Point(84, 347);
            this.updateConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.updateConfirm.Name = "updateConfirm";
            this.updateConfirm.Size = new System.Drawing.Size(131, 35);
            this.updateConfirm.TabIndex = 9;
            this.updateConfirm.Text = "수정";
            this.updateConfirm.Click += new System.EventHandler(this.updateConfirm_Click);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.email.Location = new System.Drawing.Point(19, 271);
            this.email.MinimumSize = new System.Drawing.Size(1, 1);
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.email.Size = new System.Drawing.Size(86, 38);
            this.email.Symbol = 61664;
            this.email.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.email.TabIndex = 4;
            this.email.Text = "메일";
            // 
            // addr
            // 
            this.addr.BackColor = System.Drawing.Color.Transparent;
            this.addr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addr.Location = new System.Drawing.Point(19, 211);
            this.addr.MinimumSize = new System.Drawing.Size(1, 1);
            this.addr.Name = "addr";
            this.addr.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.addr.Size = new System.Drawing.Size(86, 38);
            this.addr.Symbol = 61461;
            this.addr.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.addr.TabIndex = 5;
            this.addr.Text = "주소";
            // 
            // tel
            // 
            this.tel.BackColor = System.Drawing.Color.Transparent;
            this.tel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tel.Location = new System.Drawing.Point(19, 151);
            this.tel.MinimumSize = new System.Drawing.Size(1, 1);
            this.tel.Name = "tel";
            this.tel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.tel.Size = new System.Drawing.Size(86, 38);
            this.tel.Symbol = 62112;
            this.tel.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.tel.TabIndex = 6;
            this.tel.Text = "전화";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.name.Location = new System.Drawing.Point(19, 91);
            this.name.MinimumSize = new System.Drawing.Size(1, 1);
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.name.Size = new System.Drawing.Size(86, 38);
            this.name.Symbol = 61447;
            this.name.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.name.TabIndex = 7;
            this.name.Text = "이름";
            // 
            // UpdateDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 414);
            this.Controls.Add(this.updateEmail);
            this.Controls.Add(this.updateAddr);
            this.Controls.Add(this.updateTel);
            this.Controls.Add(this.updateName);
            this.Controls.Add(this.updateCancel);
            this.Controls.Add(this.updateConfirm);
            this.Controls.Add(this.email);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.name);
            this.Name = "UpdateDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "데이터 수정";
            this.Load += new System.EventHandler(this.UpdateDetail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox updateEmail;
        private Sunny.UI.UITextBox updateAddr;
        private Sunny.UI.UITextBox updateTel;
        private Sunny.UI.UITextBox updateName;
        private Sunny.UI.UISymbolButton updateCancel;
        private Sunny.UI.UISymbolButton updateConfirm;
        private Sunny.UI.UISymbolLabel email;
        private Sunny.UI.UISymbolLabel addr;
        private Sunny.UI.UISymbolLabel tel;
        private Sunny.UI.UISymbolLabel name;
    }
}