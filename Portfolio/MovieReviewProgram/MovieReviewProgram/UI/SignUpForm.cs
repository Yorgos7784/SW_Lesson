﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieReviewProgram.UI
{
    public partial class signUpForm : Form
    {
        public signUpForm()
        {
            InitializeComponent();
        }

        private void signUpExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
