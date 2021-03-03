using adressTest0218.control;
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

namespace addrWin_20210302.ui
{
    public partial class delForm : MaterialForm
    {
        public delForm()
        {
            InitializeComponent();
        }

        private void delForm_Load(object sender, EventArgs e)
        {
            initGridView();
        }

        private void initGridView()
        {
            for (int i = 0; i < StudentCtrl.getInst().getList().Count; i++)
            {
                delGridView.Rows.Add(new string[]
                { (i + 1).ToString(),
                    StudentCtrl.getInst().getList()[i].Name,
                    StudentCtrl.getInst().getList()[i].Tel,
                    StudentCtrl.getInst().getList()[i].Address,
                    StudentCtrl.getInst().getList()[i].Email });
            }

            int count = delGridView.Rows.Count - 1;
            delGridView.FirstDisplayedScrollingRowIndex = count;
            delGridView.CurrentCell = delGridView.Rows[count - 1].Cells[0];
        }

        private void delOk_Click(object sender, EventArgs e)
        {
            StudentCtrl.getInst().delItem(delInput.Text);
            MessageBox.Show("삭제되었습니다.");
            delGridView.Rows.Clear();
            initGridView();
        }

        private void delExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}