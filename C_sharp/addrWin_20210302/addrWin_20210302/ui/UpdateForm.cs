using adressTest0218.control;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace addrWin_20210302.ui
{
    partial class UpdateForm : MaterialForm
    {
        StudentCtrl sc;
        private int updateNum = 0;
        
        public UpdateForm(StudentCtrl sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            initListView();
        }

        private void updateCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateOK_Click(object sender, EventArgs e)
        {
            sc.updateItem(updateNum, updateName.Text, updateTel.Text, updateAddr.Text, updateEmail.Text);
            MessageBox.Show("수정되었습니다.", "데이터 수정 완료");
            resetList();
        }

        private void initListView()
        {
            for (int i = 0; i < sc.getList().Count; i++)
            {
                upList.Items.Add(new ListViewItem(new string[]
                { (i + 1).ToString(),
                    sc.getList()[i].Name,
                    sc.getList()[i].Tel,
                    sc.getList()[i].Address,
                    sc.getList()[i].Email }));
            }

            setRowColor(upList, Color.White, Color.Gainsboro);

            if (upList.Items.Count > 0)
            {
                int index = upList.Items.Count - 1;
                upList.Items[index].Focused = true;
                upList.EnsureVisible(index);
            }
        }

        private void setRowColor(ListView list, Color color1, Color color2)
        {
            foreach (ListViewItem item in list.Items)
            {
                if ((item.Index % 2) == 0)
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
            }
        }

        private void upList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (upList.SelectedItems.Count != 0)
            {
                int n = upList.SelectedItems[0].Index;
                updateName.Text = upList.Items[n].SubItems[1].Text;
                updateTel.Text = upList.Items[n].SubItems[2].Text;
                updateAddr.Text = upList.Items[n].SubItems[3].Text;
                updateEmail.Text = upList.Items[n].SubItems[4].Text;
                updateNum = Convert.ToInt32(upList.Items[n].SubItems[0].Text) - 1;
            }
        }



        private void resetList()
        {
            upList.Items.Clear();
            initListView();
        }
    }
}
