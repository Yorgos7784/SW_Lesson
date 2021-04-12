
namespace API_practice
{
    partial class Form2
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
            this.mPoster = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mDirector = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mCast = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // mPoster
            // 
            this.mPoster.Location = new System.Drawing.Point(12, 16);
            this.mPoster.Name = "mPoster";
            this.mPoster.Size = new System.Drawing.Size(354, 413);
            this.mPoster.TabIndex = 0;
            this.mPoster.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(400, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "제목 : ";
            // 
            // mName
            // 
            this.mName.AutoSize = true;
            this.mName.Font = new System.Drawing.Font("굴림", 15F);
            this.mName.Location = new System.Drawing.Point(476, 34);
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(0, 20);
            this.mName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15F);
            this.label3.Location = new System.Drawing.Point(400, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "감독 : ";
            // 
            // mDirector
            // 
            this.mDirector.AutoSize = true;
            this.mDirector.Font = new System.Drawing.Font("굴림", 15F);
            this.mDirector.Location = new System.Drawing.Point(476, 74);
            this.mDirector.Name = "mDirector";
            this.mDirector.Size = new System.Drawing.Size(0, 20);
            this.mDirector.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 15F);
            this.label5.Location = new System.Drawing.Point(400, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "개봉일 : ";
            // 
            // mDate
            // 
            this.mDate.AutoSize = true;
            this.mDate.Font = new System.Drawing.Font("굴림", 15F);
            this.mDate.Location = new System.Drawing.Point(476, 114);
            this.mDate.Name = "mDate";
            this.mDate.Size = new System.Drawing.Size(0, 20);
            this.mDate.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 15F);
            this.label7.Location = new System.Drawing.Point(400, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "출연진 : ";
            // 
            // mCast
            // 
            this.mCast.AutoSize = true;
            this.mCast.Font = new System.Drawing.Font("굴림", 15F);
            this.mCast.Location = new System.Drawing.Point(476, 154);
            this.mCast.Name = "mCast";
            this.mCast.Size = new System.Drawing.Size(0, 20);
            this.mCast.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 458);
            this.Controls.Add(this.mCast);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mDirector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mPoster);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mPoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mDirector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label mCast;
    }
}