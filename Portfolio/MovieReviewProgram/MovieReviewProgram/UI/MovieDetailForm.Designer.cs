
namespace MovieReviewProgram.UI
{
    partial class MovieDetailForm
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
            this.windowClose = new Sunny.UI.UISymbolButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.moviePoster = new CxFlatUI.CxFlatPictureBox();
            this.mName = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.mDirector = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.genre = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.releaseDate = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.cast = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.mReview = new Sunny.UI.UILabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // windowClose
            // 
            this.windowClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowClose.FillColor = System.Drawing.Color.Brown;
            this.windowClose.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.windowClose.FillPressColor = System.Drawing.Color.Maroon;
            this.windowClose.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.windowClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.windowClose.IsCircle = true;
            this.windowClose.Location = new System.Drawing.Point(745, 6);
            this.windowClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.windowClose.Name = "windowClose";
            this.windowClose.RectColor = System.Drawing.Color.Brown;
            this.windowClose.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.windowClose.RectPressColor = System.Drawing.Color.Maroon;
            this.windowClose.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.windowClose.Size = new System.Drawing.Size(38, 35);
            this.windowClose.Style = Sunny.UI.UIStyle.Custom;
            this.windowClose.Symbol = 61453;
            this.windowClose.TabIndex = 2;
            this.windowClose.Click += new System.EventHandler(this.windowClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.windowClose);
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Font = new System.Drawing.Font("굵은안상수체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 48);
            this.panel1.TabIndex = 3;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.uiLabel1.Location = new System.Drawing.Point(18, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(196, 48);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "인생은 영화처럼";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // moviePoster
            // 
            this.moviePoster.Location = new System.Drawing.Point(19, 95);
            this.moviePoster.Name = "moviePoster";
            this.moviePoster.Size = new System.Drawing.Size(350, 525);
            this.moviePoster.TabIndex = 4;
            this.moviePoster.TabStop = false;
            // 
            // mName
            // 
            this.mName.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mName.Location = new System.Drawing.Point(410, 76);
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(323, 76);
            this.mName.TabIndex = 5;
            this.mName.Text = "Movie Title";
            this.mName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(412, 164);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(89, 30);
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "Director : ";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mDirector
            // 
            this.mDirector.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mDirector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mDirector.Location = new System.Drawing.Point(491, 164);
            this.mDirector.Name = "mDirector";
            this.mDirector.Size = new System.Drawing.Size(250, 30);
            this.mDirector.TabIndex = 6;
            this.mDirector.Text = "Director";
            this.mDirector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(412, 194);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(73, 30);
            this.uiLabel4.TabIndex = 6;
            this.uiLabel4.Text = "Genre : ";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genre
            // 
            this.genre.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.genre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.genre.Location = new System.Drawing.Point(475, 194);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(269, 30);
            this.genre.TabIndex = 6;
            this.genre.Text = "Genre";
            this.genre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.Location = new System.Drawing.Point(412, 224);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(133, 30);
            this.uiLabel6.TabIndex = 6;
            this.uiLabel6.Text = "Release Date : ";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // releaseDate
            // 
            this.releaseDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.releaseDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.releaseDate.Location = new System.Drawing.Point(527, 224);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(213, 30);
            this.releaseDate.TabIndex = 6;
            this.releaseDate.Text = "Rlease Date";
            this.releaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(412, 254);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(57, 30);
            this.uiLabel8.TabIndex = 6;
            this.uiLabel8.Text = "Cast : ";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cast
            // 
            this.cast.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cast.Location = new System.Drawing.Point(464, 260);
            this.cast.Name = "cast";
            this.cast.Size = new System.Drawing.Size(269, 129);
            this.cast.TabIndex = 6;
            this.cast.Text = "Cast";
            this.cast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(412, 404);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(73, 30);
            this.uiLabel3.TabIndex = 6;
            this.uiLabel3.Text = "Review";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mReview
            // 
            this.mReview.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mReview.Location = new System.Drawing.Point(412, 458);
            this.mReview.Name = "mReview";
            this.mReview.Size = new System.Drawing.Size(347, 179);
            this.mReview.TabIndex = 6;
            this.mReview.Text = "Review";
            this.mReview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MovieDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 666);
            this.Controls.Add(this.mDirector);
            this.Controls.Add(this.mReview);
            this.Controls.Add(this.cast);
            this.Controls.Add(this.releaseDate);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.mName);
            this.Controls.Add(this.moviePoster);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MovieDetailForm";
            this.Load += new System.EventHandler(this.MovieDetailForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton windowClose;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UILabel uiLabel1;
        private CxFlatUI.CxFlatPictureBox moviePoster;
        private Sunny.UI.UILabel mName;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel mDirector;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel genre;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel releaseDate;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel cast;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel mReview;
    }
}