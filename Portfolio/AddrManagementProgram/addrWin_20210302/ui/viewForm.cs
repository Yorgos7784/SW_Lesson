﻿using adressTest0218.control;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace addrWin_20210302.ui
{
    partial class viewForm : MaterialForm
    {
        StudentCtrl sc;

        public viewForm(StudentCtrl sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void initListView()
        {
            for (int i = 0; i < sc.getList().Count; i++)
            {
                listView.Items.Add(new ListViewItem(new string[]
                { (i + 1).ToString(),
                    sc.getList()[i].Name,
                    sc.getList()[i].Tel,
                    sc.getList()[i].Address,
                    sc.getList()[i].Email }));
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
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
            }
        }

        private void viewForm_Load(object sender, EventArgs e)
        {
            initListView();
        }

        private void viewExti_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 0)
            {
                int n = listView.SelectedItems[0].Index;
                string name1 = listView.Items[n].SubItems[1].Text;
                string tel1 = listView.Items[n].SubItems[2].Text;
                DialogResult viewDeldr = MainForm.getDialogResult("선택한 데이터를 삭제하시겠습니까?", "데이터 삭제");
                if (viewDeldr == DialogResult.Yes)
                {
                    sc.delItem(name1, tel1);
                    MessageBox.Show("삭제되었습니다.", "데이터 삭제 완료");
                    resetList();
                }
                else if (viewDeldr == DialogResult.No)
                {
                    MessageBox.Show("취소되었습니다.", "데이터 삭제 취소");
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 0)
            {
                int n = listView.SelectedItems[0].Index;
                string name2 = listView.Items[n].SubItems[1].Text;
                string tel2 = listView.Items[n].SubItems[2].Text;
                new UpdateDetail(name2, tel2, sc).ShowDialog();
                resetList();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            new AddForm(sc).ShowDialog();
            resetList();
        }

        private void addRand_Click(object sender, EventArgs e)
        {
            string cnt = MainForm.myInputBox("랜덤 데이터를 생성할 갯수를 입력하세요", "랜덤 데이터 생성", "0");
            if (cnt == "") return;
            sc.randData(Convert.ToInt32(cnt));
            MessageBox.Show("추가되었습니다!", "랜덤 데이터 추가 완료");
            resetList();
        }

        private void resetList()
        {
            listView.Items.Clear();
            initListView();
        }

        private void delAll_Click(object sender, EventArgs e)
        {
            DialogResult delAlldr = MainForm.getDialogResult("전체 데이터를 삭제하시겠습니까?", "데이터 삭제");
            if (delAlldr == DialogResult.Yes)
            {
                sc.delItemAll();
                MessageBox.Show("삭제되었습니다.", "삭제 완료");
                resetList();
            }
            else if (delAlldr == DialogResult.No)
            {
                MessageBox.Show("취소되었습니다.", "데이터 삭제 취소");
            }
        }

        private void serchButton_Click(object sender, EventArgs e)
        {
            if(inputSerchName.Text.Length > 0)
            {
                int count = 0;
                for (int i = 0; i < sc.getList().Count; i++)
                {
                    if (sc.getList()[i].Name == inputSerchName.Text)
                    {
                        count++;
                    }
                }
                if(count > 0)
                {
                    listView.Items.Clear();
                    for (int i = 0; i < sc.getList().Count; i++)
                    {
                        if (sc.getList()[i].Name == inputSerchName.Text)
                        {
                            listView.Items.Add(new ListViewItem(new string[]{
                                (i + 1).ToString(),
                                sc.getList()[i].Name,
                                sc.getList()[i].Tel,
                                sc.getList()[i].Address,
                                sc.getList()[i].Email }));
                        }
                    }

                    setRowColor(listView, Color.White, Color.Gainsboro);
                    if (listView.Items.Count > 0)
                    {
                        int index = listView.Items.Count - 1;
                        listView.Items[index].Focused = true;
                        listView.EnsureVisible(index);
                    }
                }

                else
                {
                    MessageBox.Show("일치하는 데이터가 없습니다.", "검색 실패");
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            resetList();
        }

        private void inputSerchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                serchButton_Click(sender, e);
            else if(e.KeyCode == Keys.F5)
                resetList();
        }
    }
}
