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
    public partial class UpdateForm : MaterialForm
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void initGridView()
        {
            for (int i = 0; i < StudentCtrl.getInst().getList().Count; i++)
            {
                updateGridView.Rows.Add(new string[]
                { (i + 1).ToString(),
                    StudentCtrl.getInst().getList()[i].Name,
                    StudentCtrl.getInst().getList()[i].Tel,
                    StudentCtrl.getInst().getList()[i].Address,
                    StudentCtrl.getInst().getList()[i].Email });
            }

            int count = updateGridView.Rows.Count - 1;
            updateGridView.FirstDisplayedScrollingRowIndex = count;
            updateGridView.CurrentCell = updateGridView.Rows[count - 1].Cells[0];
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            initGridView();
        }

        private void updateOk_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(updateInput.Text);
            if(num > StudentCtrl.getInst().getList().Count || num < 1)
            {
                MessageBox.Show("없는 정보입니다.");
            }
            else
            {
                new UpdateDetail(num).ShowDialog();
                updateGridView.Rows.Clear();
                initGridView();
            }
        }

        private void delExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
