using CarManager_0323.DB;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager_0323.UI
{
    partial class SellerDetailViewForm : MaterialForm
    {
        string sName;
        DaoOracle oracle;
        
        public SellerDetailViewForm(DaoOracle oracle, string sName)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.sName = sName;
        }
    }
}
