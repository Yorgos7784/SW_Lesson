using CarManager_0323.DB;
using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager_0323
{
    partial class MainForm : MaterialForm
    {
        DaoOracle dao = new DaoOracle();

        public MainForm()
        {
            InitializeComponent();
        }
        
    }
}
