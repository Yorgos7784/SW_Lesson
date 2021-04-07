
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
            this.logInBtn = new Sunny.UI.UISymbolButton();
            this.pwInput = new CxFlatUI.CxFlatTextBox();
            this.idInput = new CxFlatUI.CxFlatTextBox();
            this.signUpExit = new Sunny.UI.UISymbolButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpBtn
            // 
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.signUpBtn.Location = new System.Drawing.Point(262, 355);
            this.signUpBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(100, 35);
            this.signUpBtn.Symbol = 61543;
            this.signUpBtn.TabIndex = 13;
            this.signUpBtn.Text = "Sign Up";
            // 
            // logInBtn
            // 
            this.logInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.logInBtn.Location = new System.Drawing.Point(134, 355);
            this.logInBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(100, 35);
            this.logInBtn.TabIndex = 14;
            this.logInBtn.Text = "Log In";
            // 
            // pwInput
            // 
            this.pwInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pwInput.Hint = "";
            this.pwInput.Location = new System.Drawing.Point(198, 274);
            this.pwInput.MaxLength = 32767;
            this.pwInput.Multiline = false;
            this.pwInput.Name = "pwInput";
            this.pwInput.PasswordChar = '\0';
            this.pwInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pwInput.SelectedText = "";
            this.pwInput.SelectionLength = 0;
            this.pwInput.SelectionStart = 0;
            this.pwInput.Size = new System.Drawing.Size(164, 38);
            this.pwInput.TabIndex = 11;
            this.pwInput.TabStop = false;
            this.pwInput.UseSystemPasswordChar = false;
            // 
            // idInput
            // 
            this.idInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idInput.Hint = "";
            this.idInput.Location = new System.Drawing.Point(198, 216);
            this.idInput.MaxLength = 32767;
            this.idInput.Multiline = false;
            this.idInput.Name = "idInput";
            this.idInput.PasswordChar = '\0';
            this.idInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idInput.SelectedText = "";
            this.idInput.SelectionLength = 0;
            this.idInput.SelectionStart = 0;
            this.idInput.Size = new System.Drawing.Size(164, 38);
            this.idInput.TabIndex = 12;
            this.idInput.TabStop = false;
            this.idInput.UseSystemPasswordChar = false;
            // 
            // signUpExit
            // 
            this.signUpExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpExit.FillColor = System.Drawing.Color.Maroon;
            this.signUpExit.FillHoverColor = System.Drawing.Color.Brown;
            this.signUpExit.FillPressColor = System.Drawing.Color.Maroon;
            this.signUpExit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signUpExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.signUpExit.Location = new System.Drawing.Point(351, 62);
            this.signUpExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.signUpExit.Name = "signUpExit";
            this.signUpExit.RectColor = System.Drawing.Color.Maroon;
            this.signUpExit.RectHoverColor = System.Drawing.Color.Brown;
            this.signUpExit.RectPressColor = System.Drawing.Color.Maroon;
            this.signUpExit.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signUpExit.Size = new System.Drawing.Size(71, 35);
            this.signUpExit.Style = Sunny.UI.UIStyle.Custom;
            this.signUpExit.Symbol = 61457;
            this.signUpExit.TabIndex = 10;
            this.signUpExit.Text = "Exit";
            this.signUpExit.Click += new System.EventHandler(this.signUpExit_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("Newtext Bk BT", 20F, System.Drawing.FontStyle.Bold);
            this.uiLabel3.Location = new System.Drawing.Point(129, 277);
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
            this.uiLabel2.Location = new System.Drawing.Point(134, 219);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(52, 32);
            this.uiLabel2.TabIndex = 8;
            this.uiLabel2.Text = "ID";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Newtext Bk BT", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(115, 82);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(272, 118);
            this.uiLabel1.TabIndex = 9;
            this.uiLabel1.Text = "Log In";
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
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(494, 504);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.pwInput);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.signUpExit);
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
        private Sunny.UI.UISymbolButton logInBtn;
        private CxFlatUI.CxFlatTextBox pwInput;
        private CxFlatUI.CxFlatTextBox idInput;
        private Sunny.UI.UISymbolButton signUpExit;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
    }
}