
namespace addrWin_20210302.ui
{
    partial class delForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.delGridView = new Sunny.UI.UIDataGridView();
            this.delCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delOk = new Sunny.UI.UISymbolButton();
            this.delExit = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.delInput = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.delGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // delGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.delGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.delGridView.BackgroundColor = System.Drawing.Color.White;
            this.delGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.delGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.delGridView.ColumnHeadersHeight = 32;
            this.delGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.delGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delCount,
            this.delName,
            this.delTel,
            this.delAddr,
            this.delEmail});
            this.delGridView.EnableHeadersVisualStyles = false;
            this.delGridView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.delGridView.Location = new System.Drawing.Point(12, 76);
            this.delGridView.Name = "delGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.delGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.delGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.delGridView.RowTemplate.Height = 29;
            this.delGridView.SelectedIndex = -1;
            this.delGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.delGridView.ShowGridLine = true;
            this.delGridView.Size = new System.Drawing.Size(578, 400);
            this.delGridView.TabIndex = 0;
            // 
            // delCount
            // 
            this.delCount.HeaderText = "번 호";
            this.delCount.Name = "delCount";
            this.delCount.Width = 60;
            // 
            // delName
            // 
            this.delName.HeaderText = "이 름";
            this.delName.Name = "delName";
            this.delName.Width = 80;
            // 
            // delTel
            // 
            this.delTel.HeaderText = "전 화";
            this.delTel.Name = "delTel";
            // 
            // delAddr
            // 
            this.delAddr.HeaderText = "주 소";
            this.delAddr.Name = "delAddr";
            this.delAddr.Width = 150;
            // 
            // delEmail
            // 
            this.delEmail.HeaderText = "이메일";
            this.delEmail.Name = "delEmail";
            this.delEmail.Width = 130;
            // 
            // delOk
            // 
            this.delOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delOk.Location = new System.Drawing.Point(641, 370);
            this.delOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.delOk.Name = "delOk";
            this.delOk.Size = new System.Drawing.Size(131, 35);
            this.delOk.TabIndex = 1;
            this.delOk.Text = "삭제";
            this.delOk.Click += new System.EventHandler(this.delOk_Click);
            // 
            // delExit
            // 
            this.delExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delExit.Location = new System.Drawing.Point(641, 417);
            this.delExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.delExit.Name = "delExit";
            this.delExit.Size = new System.Drawing.Size(131, 35);
            this.delExit.Symbol = 61453;
            this.delExit.TabIndex = 1;
            this.delExit.Text = "돌아가기";
            this.delExit.Click += new System.EventHandler(this.delExit_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(621, 251);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(170, 39);
            this.uiSymbolLabel1.Symbol = 61530;
            this.uiSymbolLabel1.TabIndex = 4;
            this.uiSymbolLabel1.Text = "삭제할 이름 입력";
            // 
            // delInput
            // 
            this.delInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.delInput.FillColor = System.Drawing.Color.White;
            this.delInput.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delInput.Location = new System.Drawing.Point(631, 292);
            this.delInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delInput.Maximum = 2147483647D;
            this.delInput.Minimum = -2147483648D;
            this.delInput.MinimumSize = new System.Drawing.Size(1, 1);
            this.delInput.Name = "delInput";
            this.delInput.Padding = new System.Windows.Forms.Padding(5);
            this.delInput.Size = new System.Drawing.Size(150, 29);
            this.delInput.TabIndex = 5;
            // 
            // delForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 488);
            this.Controls.Add(this.delInput);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.delExit);
            this.Controls.Add(this.delOk);
            this.Controls.Add(this.delGridView);
            this.Name = "delForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 정보 삭제";
            this.Load += new System.EventHandler(this.delForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.delGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView delGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn delCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn delName;
        private System.Windows.Forms.DataGridViewTextBoxColumn delTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn delAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn delEmail;
        private Sunny.UI.UISymbolButton delOk;
        private Sunny.UI.UISymbolButton delExit;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox delInput;
    }
}