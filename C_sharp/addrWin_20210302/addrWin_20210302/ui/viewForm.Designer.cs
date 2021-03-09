
namespace addrWin_20210302.ui
{
    partial class viewForm
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
            this.viewExit = new Sunny.UI.UISymbolButton();
            this.viewUpdateButton = new Sunny.UI.UISymbolButton();
            this.viewDelButton = new Sunny.UI.UISymbolButton();
            this.viewAddButton = new Sunny.UI.UISymbolButton();
            this.viewRandData = new Sunny.UI.UISymbolButton();
            this.viewDelAll = new Sunny.UI.UISymbolButton();
            this.listView = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // viewExit
            // 
            this.viewExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewExit.Location = new System.Drawing.Point(681, 408);
            this.viewExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewExit.Name = "viewExit";
            this.viewExit.Size = new System.Drawing.Size(131, 35);
            this.viewExit.TabIndex = 2;
            this.viewExit.Text = "돌아가기";
            this.viewExit.Click += new System.EventHandler(this.viewExti_Click);
            // 
            // viewUpdateButton
            // 
            this.viewUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewUpdateButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewUpdateButton.Location = new System.Drawing.Point(681, 346);
            this.viewUpdateButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewUpdateButton.Name = "viewUpdateButton";
            this.viewUpdateButton.Size = new System.Drawing.Size(131, 35);
            this.viewUpdateButton.Symbol = 61508;
            this.viewUpdateButton.TabIndex = 2;
            this.viewUpdateButton.Text = "수정";
            this.viewUpdateButton.Click += new System.EventHandler(this.update_Click);
            // 
            // viewDelButton
            // 
            this.viewDelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewDelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.viewDelButton.FillHoverColor = System.Drawing.Color.Red;
            this.viewDelButton.FillPressColor = System.Drawing.Color.Maroon;
            this.viewDelButton.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.viewDelButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewDelButton.Location = new System.Drawing.Point(681, 222);
            this.viewDelButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewDelButton.Name = "viewDelButton";
            this.viewDelButton.Size = new System.Drawing.Size(131, 35);
            this.viewDelButton.Style = Sunny.UI.UIStyle.Custom;
            this.viewDelButton.Symbol = 61544;
            this.viewDelButton.TabIndex = 2;
            this.viewDelButton.Text = "삭제";
            this.viewDelButton.Click += new System.EventHandler(this.del_Click);
            // 
            // viewAddButton
            // 
            this.viewAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAddButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.viewAddButton.FillHoverColor = System.Drawing.Color.Lime;
            this.viewAddButton.FillPressColor = System.Drawing.Color.Green;
            this.viewAddButton.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.viewAddButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewAddButton.Location = new System.Drawing.Point(681, 98);
            this.viewAddButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewAddButton.Name = "viewAddButton";
            this.viewAddButton.Size = new System.Drawing.Size(131, 35);
            this.viewAddButton.Style = Sunny.UI.UIStyle.Custom;
            this.viewAddButton.Symbol = 61543;
            this.viewAddButton.TabIndex = 2;
            this.viewAddButton.Text = "추가";
            this.viewAddButton.Click += new System.EventHandler(this.add_Click);
            // 
            // viewRandData
            // 
            this.viewRandData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewRandData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.viewRandData.FillHoverColor = System.Drawing.Color.Lime;
            this.viewRandData.FillPressColor = System.Drawing.Color.Green;
            this.viewRandData.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.viewRandData.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewRandData.Location = new System.Drawing.Point(681, 160);
            this.viewRandData.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewRandData.Name = "viewRandData";
            this.viewRandData.Size = new System.Drawing.Size(131, 35);
            this.viewRandData.Style = Sunny.UI.UIStyle.Custom;
            this.viewRandData.Symbol = 61543;
            this.viewRandData.TabIndex = 2;
            this.viewRandData.Text = "랜덤 추가";
            this.viewRandData.Click += new System.EventHandler(this.addRand_Click);
            // 
            // viewDelAll
            // 
            this.viewDelAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewDelAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.viewDelAll.FillHoverColor = System.Drawing.Color.Red;
            this.viewDelAll.FillPressColor = System.Drawing.Color.Maroon;
            this.viewDelAll.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.viewDelAll.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewDelAll.Location = new System.Drawing.Point(681, 284);
            this.viewDelAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewDelAll.Name = "viewDelAll";
            this.viewDelAll.Size = new System.Drawing.Size(131, 35);
            this.viewDelAll.Style = Sunny.UI.UIStyle.Custom;
            this.viewDelAll.Symbol = 61544;
            this.viewDelAll.TabIndex = 2;
            this.viewDelAll.Text = "전체 삭제";
            this.viewDelAll.Click += new System.EventHandler(this.delAll_Click);
            // 
            // listView
            // 
            this.listView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.name,
            this.tel,
            this.addr,
            this.email});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView.Location = new System.Drawing.Point(11, 72);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(644, 407);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
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
            // viewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 488);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.viewDelAll);
            this.Controls.Add(this.viewRandData);
            this.Controls.Add(this.viewAddButton);
            this.Controls.Add(this.viewDelButton);
            this.Controls.Add(this.viewUpdateButton);
            this.Controls.Add(this.viewExit);
            this.Name = "viewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 데이터 보기";
            this.Load += new System.EventHandler(this.viewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton viewExit;
        private Sunny.UI.UISymbolButton viewUpdateButton;
        private Sunny.UI.UISymbolButton viewDelButton;
        private Sunny.UI.UISymbolButton viewAddButton;
        private Sunny.UI.UISymbolButton viewRandData;
        private Sunny.UI.UISymbolButton viewDelAll;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader tel;
        private System.Windows.Forms.ColumnHeader addr;
        private System.Windows.Forms.ColumnHeader email;
    }
}