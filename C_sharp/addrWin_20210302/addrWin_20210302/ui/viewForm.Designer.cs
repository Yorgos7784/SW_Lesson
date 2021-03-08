
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listView = new System.Windows.Forms.ListView();
            this.listCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listAddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gridView = new Sunny.UI.UIDataGridView();
            this.viewExit = new Sunny.UI.UISymbolButton();
            this.viewUpdateButton = new Sunny.UI.UISymbolButton();
            this.viewDelButton = new Sunny.UI.UISymbolButton();
            this.viewAddButton = new Sunny.UI.UISymbolButton();
            this.gridCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listCount,
            this.listName,
            this.listTel,
            this.listAddr,
            this.listEmail});
            this.listView.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 74);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(794, 162);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // listCount
            // 
            this.listCount.Text = "번 호";
            this.listCount.Width = 45;
            // 
            // listName
            // 
            this.listName.Text = "이 름";
            this.listName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listName.Width = 80;
            // 
            // listTel
            // 
            this.listTel.Text = "전 화";
            this.listTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listTel.Width = 171;
            // 
            // listAddr
            // 
            this.listAddr.Text = "주 소";
            this.listAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listAddr.Width = 248;
            // 
            // listEmail
            // 
            this.listEmail.Text = "이메일";
            this.listEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listEmail.Width = 232;
            // 
            // gridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.BackgroundColor = System.Drawing.Color.White;
            this.gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridView.ColumnHeadersHeight = 32;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridCount,
            this.gridName,
            this.gridTel,
            this.gridAddr,
            this.gridEmail});
            this.gridView.EnableHeadersVisualStyles = false;
            this.gridView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gridView.Location = new System.Drawing.Point(12, 247);
            this.gridView.Name = "gridView";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.gridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridView.RowTemplate.Height = 29;
            this.gridView.SelectedIndex = -1;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.ShowGridLine = true;
            this.gridView.Size = new System.Drawing.Size(794, 162);
            this.gridView.TabIndex = 1;
            // 
            // viewExit
            // 
            this.viewExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewExit.Location = new System.Drawing.Point(574, 431);
            this.viewExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewExit.Name = "viewExit";
            this.viewExit.Size = new System.Drawing.Size(131, 35);
            this.viewExit.TabIndex = 2;
            this.viewExit.Text = "확인";
            this.viewExit.Click += new System.EventHandler(this.viewExti_Click);
            // 
            // viewUpdateButton
            // 
            this.viewUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewUpdateButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewUpdateButton.Location = new System.Drawing.Point(420, 431);
            this.viewUpdateButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewUpdateButton.Name = "viewUpdateButton";
            this.viewUpdateButton.Size = new System.Drawing.Size(131, 35);
            this.viewUpdateButton.TabIndex = 2;
            this.viewUpdateButton.Text = "수정";
            this.viewUpdateButton.Click += new System.EventHandler(this.update_Click);
            // 
            // viewDelButton
            // 
            this.viewDelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewDelButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewDelButton.Location = new System.Drawing.Point(266, 431);
            this.viewDelButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewDelButton.Name = "viewDelButton";
            this.viewDelButton.Size = new System.Drawing.Size(131, 35);
            this.viewDelButton.TabIndex = 2;
            this.viewDelButton.Text = "삭제";
            this.viewDelButton.Click += new System.EventHandler(this.del_Click);
            // 
            // viewAddButton
            // 
            this.viewAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAddButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewAddButton.Location = new System.Drawing.Point(112, 431);
            this.viewAddButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewAddButton.Name = "viewAddButton";
            this.viewAddButton.Size = new System.Drawing.Size(131, 35);
            this.viewAddButton.TabIndex = 2;
            this.viewAddButton.Text = "추가";
            this.viewAddButton.Click += new System.EventHandler(this.add_Click);
            // 
            // gridCount
            // 
            this.gridCount.HeaderText = "번 호";
            this.gridCount.Name = "gridCount";
            this.gridCount.Width = 60;
            // 
            // gridName
            // 
            this.gridName.HeaderText = "이 름";
            this.gridName.Name = "gridName";
            this.gridName.Width = 80;
            // 
            // gridTel
            // 
            this.gridTel.HeaderText = "전 화";
            this.gridTel.Name = "gridTel";
            this.gridTel.Width = 150;
            // 
            // gridAddr
            // 
            this.gridAddr.HeaderText = "주 소";
            this.gridAddr.Name = "gridAddr";
            this.gridAddr.Width = 250;
            // 
            // gridEmail
            // 
            this.gridEmail.HeaderText = "이메일";
            this.gridEmail.Name = "gridEmail";
            this.gridEmail.Width = 200;
            // 
            // viewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 488);
            this.Controls.Add(this.viewAddButton);
            this.Controls.Add(this.viewDelButton);
            this.Controls.Add(this.viewUpdateButton);
            this.Controls.Add(this.viewExit);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.listView);
            this.Name = "viewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 데이터 보기";
            this.Load += new System.EventHandler(this.viewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private Sunny.UI.UIDataGridView gridView;
        private Sunny.UI.UISymbolButton viewExit;
        private System.Windows.Forms.ColumnHeader listCount;
        private System.Windows.Forms.ColumnHeader listName;
        private System.Windows.Forms.ColumnHeader listTel;
        private System.Windows.Forms.ColumnHeader listAddr;
        private System.Windows.Forms.ColumnHeader listEmail;
        private Sunny.UI.UISymbolButton viewUpdateButton;
        private Sunny.UI.UISymbolButton viewDelButton;
        private Sunny.UI.UISymbolButton viewAddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmail;
    }
}