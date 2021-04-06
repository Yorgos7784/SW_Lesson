using MovieReviewProgram.Model;
using MovieReviewProgram.Oracle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieReviewProgram
{
    public partial class LonInForm : Form
    {
        DaoOracle oracle;
        public LonInForm()
        {
            InitializeComponent();
            oracle = new DaoOracle();
        }

        private void programExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LonInForm_Load(object sender, EventArgs e)
        {
            oracle.makeUserTable();
        }

        private void dropTable_Click(object sender, EventArgs e)
        {
            oracle.dropTables("USER_TABLE", "USER_TABLE_SEQUENCE");
        }
    }
}
