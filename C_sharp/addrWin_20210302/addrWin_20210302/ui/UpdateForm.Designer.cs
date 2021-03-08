
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.updateGridView = new Sunny.UI.UIDataGridView();
            this.delCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateInput = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.delExit = new Sunny.UI.UISymbolButton();
            this.updateOk = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.updateGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // updateGridView
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.updateGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.updateGridView.BackgroundColor = System.Drawing.Color.White;
            this.updateGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.updateGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.updateGridView.ColumnHeadersHeight = 32;
            this.updateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.updateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delCount,
            this.delName,
            this.delTel,
            this.delAddr,
            this.delEmail});
            this.updateGridView.EnableHeadersVisualStyles = false;
            this.updateGridView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updateGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.updateGridView.Location = new System.Drawing.Point(12, 76);
            this.updateGridView.Name = "updateGridView";
            this.updateGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.updateGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.updateGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.updateGridView.RowTemplate.Height = 29;
            this.updateGridView.SelectedIndex = -1;
            this.updateGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.updateGridView.ShowGridLine = true;
            this.updateGridView.Size = new System.Drawing.Size(578, 400);
            this.updateGridView.TabIndex = 1;
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
            // updateInput
            // 
            this.updateInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateInput.FillColor = System.Drawing.Color.White;
            this.updateInput.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updateInput.Location = new System.Drawing.Point(631, 292);
            this.updateInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateInput.Maximum = 2147483647D;
            this.updateInput.Minimum = -2147483648D;
            this.updateInput.MinimumSize = new System.Drawing.Size(1, 1);
            this.updateInput.Name = "updateInput";
            this.updateInput.Padding = new System.Windows.Forms.Padding(5);
            this.updateInput.Size = new System.Drawing.Size(150, 29);
            this.updateInput.TabIndex = 9;
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
            this.uiSymbolLabel1.TabIndex = 8;
            this.uiSymbolLabel1.Text = "수정할 이름 입력";
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
            this.delExit.TabIndex = 6;
            this.delExit.Text = "돌아가기";
            this.delExit.Click += new System.EventHandler(this.delExit_Click);
            // 
            // updateOk
            // 
            this.updateOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updateOk.Location = new System.Drawing.Point(641, 370);
            this.updateOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.updateOk.Name = "updateOk";
            this.updateOk.Size = new System.Drawing.Size(131, 35);
            this.updateOk.TabIndex = 7;
            this.updateOk.Text = "수정";
            this.updateOk.Click += new System.EventHandler(this.updateOk_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 488);
            this.Controls.Add(this.updateInput);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.delExit);
            this.Controls.Add(this.updateOk);
            this.Controls.Add(this.updateGridView);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 정보 수정";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updateGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView updateGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn delCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn delName;
        private System.Windows.Forms.DataGridViewTextBoxColumn delTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn delAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn delEmail;
        private Sunny.UI.UITextBox updateInput;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolButton delExit;
        private Sunny.UI.UISymbolButton updateOk;
    }
}