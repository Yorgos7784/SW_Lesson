﻿
namespace MovieReviewProgram.UI
{
    partial class signUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signUpForm));
            this.signUpBtn = new Sunny.UI.UISymbolButton();
            this.ExitBtn = new Sunny.UI.UISymbolButton();
            this.pwInput = new CxFlatUI.CxFlatTextBox();
            this.idInput = new CxFlatUI.CxFlatTextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.pwCheck = new CxFlatUI.CxFlatTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpBtn
            // 
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.signUpBtn.Location = new System.Drawing.Point(134, 379);
            this.signUpBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(100, 35);
            this.signUpBtn.Symbol = 61543;
            this.signUpBtn.TabIndex = 13;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ExitBtn.Location = new System.Drawing.Point(262, 379);
            this.ExitBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(100, 35);
            this.ExitBtn.Symbol = 61453;
            this.ExitBtn.TabIndex = 14;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pwInput
            // 
            this.pwInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pwInput.Hint = "";
            this.pwInput.Location = new System.Drawing.Point(198, 238);
            this.pwInput.MaxLength = 32767;
            this.pwInput.Multiline = false;
            this.pwInput.Name = "pwInput";
            this.pwInput.PasswordChar = '\0';
            this.pwInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pwInput.SelectedText = "";
            this.pwInput.SelectionLength = 0;
            this.pwInput.SelectionStart = 0;
            this.pwInput.Size = new System.Drawing.Size(164, 38);
            this.pwInput.TabIndex = 4;
            this.pwInput.TabStop = false;
            this.pwInput.UseSystemPasswordChar = false;
            // 
            // idInput
            // 
            this.idInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idInput.Hint = "";
            this.idInput.Location = new System.Drawing.Point(198, 169);
            this.idInput.MaxLength = 32767;
            this.idInput.Multiline = false;
            this.idInput.Name = "idInput";
            this.idInput.PasswordChar = '\0';
            this.idInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idInput.SelectedText = "";
            this.idInput.SelectionLength = 0;
            this.idInput.SelectionStart = 0;
            this.idInput.Size = new System.Drawing.Size(164, 38);
            this.idInput.TabIndex = 3;
            this.idInput.TabStop = false;
            this.idInput.UseSystemPasswordChar = false;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("Newtext Bk BT", 20F, System.Drawing.FontStyle.Bold);
            this.uiLabel3.Location = new System.Drawing.Point(101, 241);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(63, 32);
            this.uiLabel3.TabIndex = 7;
            this.uiLabel3.Text = "PW";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Newtext Bk BT", 20F, System.Drawing.FontStyle.Bold);
            this.uiLabel2.Location = new System.Drawing.Point(106, 172);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(52, 32);
            this.uiLabel2.TabIndex = 8;
            this.uiLabel2.Text = "ID";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Newtext Bk BT", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(106, 68);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(290, 73);
            this.uiLabel1.TabIndex = 9;
            this.uiLabel1.Text = "Sign Up";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(-2, -63);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(503, 671);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 6;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("Newtext Bk BT", 20F, System.Drawing.FontStyle.Bold);
            this.uiLabel4.Location = new System.Drawing.Point(73, 292);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(119, 66);
            this.uiLabel4.TabIndex = 7;
            this.uiLabel4.Text = "PW Again";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pwCheck
            // 
            this.pwCheck.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pwCheck.Hint = "";
            this.pwCheck.Location = new System.Drawing.Point(198, 307);
            this.pwCheck.MaxLength = 32767;
            this.pwCheck.Multiline = false;
            this.pwCheck.Name = "pwCheck";
            this.pwCheck.PasswordChar = '\0';
            this.pwCheck.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pwCheck.SelectedText = "";
            this.pwCheck.SelectionLength = 0;
            this.pwCheck.SelectionStart = 0;
            this.pwCheck.Size = new System.Drawing.Size(164, 38);
            this.pwCheck.TabIndex = 5;
            this.pwCheck.TabStop = false;
            this.pwCheck.UseSystemPasswordChar = false;
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 504);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.pwCheck);
            this.Controls.Add(this.pwInput);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton signUpBtn;
        private Sunny.UI.UISymbolButton ExitBtn;
        private CxFlatUI.CxFlatTextBox pwInput;
        private CxFlatUI.CxFlatTextBox idInput;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UILabel uiLabel4;
        private CxFlatUI.CxFlatTextBox pwCheck;
    }
}