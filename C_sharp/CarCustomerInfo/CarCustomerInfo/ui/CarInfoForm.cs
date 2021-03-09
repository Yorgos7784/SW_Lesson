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

namespace CarCustomerInfo.ui
{
    partial class CarInfoForm : MaterialForm
    {
        CarInfoCtrl ctrl;
        public CarInfoForm(CarInfoCtrl ctrl)
        {
            InitializeComponent();
            this.ctrl = ctrl;
        }

        private void initListView()
        {
           for (int i = 0; i < ctrl.getList().Count; i++)
            {
                listView.Items.Add(new ListViewItem(new string[]
                { (i + 1).ToString(),
                    ctrl.getList()[i].Model,
                    ctrl.getList()[i].Color,
                    ctrl.getList()[i].Company,
                    ctrl.getList()[i].Price,
                    ctrl.getList()[i].Customer.Name
                })); ;
            }

            setRowColor(listView, Color.White, Color.Gainsboro);
            if (listView.Items.Count > 0)
            {
                int index = listView.Items.Count - 1;
                listView.Items[index].Focused = true;
                listView.EnsureVisible(index);
            }
        }

        private void setRowColor(ListView list, Color color1, Color color2)
        {
            foreach (ListViewItem item in list.Items)
            {
                if ((item.Index % 2) == 0)
                    item.BackColor = color1;
                else
                    item.BackColor = color2;
            }
        }

        private void carInfoForm_Load(object sender, EventArgs e)
        {
            initListView();
        }

        private void resetList()
        {
            listView.Items.Clear();
            initListView();
        }

        private void carInfoExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addCarInfo_Click(object sender, EventArgs e)
        {
            new AddCarInfo(ctrl).ShowDialog();
            resetList();
        }

        private void delCarInfo_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 0)
            {
                int n = listView.SelectedItems[0].Index;
                string model= listView.Items[n].SubItems[1].Text;
                string name = listView.Items[n].SubItems[5].Text;
                DialogResult viewDeldr = MainForm.getDialogResult("선택한 데이터를 삭제하시겠습니까?", "데이터 삭제");
                if (viewDeldr == DialogResult.Yes)
                {
                    ctrl.delCarInfo(model, name);
                    MessageBox.Show("삭제되었습니다.", "데이터 삭제 완료");
                    resetList();
                }
                else if (viewDeldr == DialogResult.No)
                {
                    MessageBox.Show("취소되었습니다.", "데이터 삭제 취소");
                }
            }
        }

        private void updateCarInfo_Click(object sender, EventArgs e)
        {
            resetList();
        }
    }
}
