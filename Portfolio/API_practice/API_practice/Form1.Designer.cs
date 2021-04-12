
namespace API_practice
{
    partial class Form1
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
            this.movieList = new System.Windows.Forms.ListView();
            this.mName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mRelease = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mNameInput = new System.Windows.Forms.TextBox();
            this.searching = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // movieList
            // 
            this.movieList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mName,
            this.mRelease});
            this.movieList.FullRowSelect = true;
            this.movieList.HideSelection = false;
            this.movieList.Location = new System.Drawing.Point(12, 12);
            this.movieList.Name = "movieList";
            this.movieList.Size = new System.Drawing.Size(579, 426);
            this.movieList.TabIndex = 0;
            this.movieList.UseCompatibleStateImageBehavior = false;
            this.movieList.View = System.Windows.Forms.View.Details;
            // 
            // mName
            // 
            this.mName.Text = "영화 제목";
            this.mName.Width = 120;
            // 
            // mRelease
            // 
            this.mRelease.Text = "개봉날짜";
            this.mRelease.Width = 120;
            // 
            // mNameInput
            // 
            this.mNameInput.Location = new System.Drawing.Point(624, 36);
            this.mNameInput.Name = "mNameInput";
            this.mNameInput.Size = new System.Drawing.Size(153, 21);
            this.mNameInput.TabIndex = 1;
            // 
            // searching
            // 
            this.searching.Location = new System.Drawing.Point(639, 75);
            this.searching.Name = "searching";
            this.searching.Size = new System.Drawing.Size(123, 35);
            this.searching.TabIndex = 2;
            this.searching.Text = "Search";
            this.searching.UseVisualStyleBackColor = true;
            this.searching.Click += new System.EventHandler(this.searching_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Detail";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searching);
            this.Controls.Add(this.mNameInput);
            this.Controls.Add(this.movieList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView movieList;
        private System.Windows.Forms.ColumnHeader mName;
        private System.Windows.Forms.ColumnHeader mRelease;
        private System.Windows.Forms.TextBox mNameInput;
        private System.Windows.Forms.Button searching;
        private System.Windows.Forms.Button button2;
    }
}