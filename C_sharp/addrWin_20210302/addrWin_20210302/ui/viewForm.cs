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
            /*string[] data = { "1", "홍길동", "010-1234-5678", "조선 한양 홍대감댁", "hong@naver.com" };
            listView.Items.Add(new ListViewItem(data));

            for (int i = 0; i < 50; i++)
            {
                listView.Items.Add(new ListViewItem(new string[] { (i + 2).ToString(), "홍길동", "010-1234-5678", "조선 한양 홍대감댁", "hong@naver.com" }));
            }*/

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
            int index = listView.Items.Count - 1;
            //listView.Items[index].Selected = true;
            listView.Items[index].Focused = true;
            listView.EnsureVisible(index);
        }

        private void setRowColor(ListView list, Color color1, Color color2)
        {
            foreach(ListViewItem item in list.Items)
            {
                if((item.Index % 2) == 0)
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
            initGridView();
        }

        private void initGridView()
        {
            /*string[] data = { "1", "홍길동", "010-1234-5678", "조선 한양 홍대감댁", "hong@naver.com" };
            gridView.Rows.Add(data);

            for (int i = 0; i < 50; i++)
            {
                gridView.Rows.Add(new string[] { (i + 2).ToString(), "홍길동", "010-1234-5678", "조선 한양 홍대감댁", "hong@naver.com" });
            }*/

            for (int i = 0; i < sc.getList().Count; i++)
            {
                gridView.Rows.Add(new string[]
                { (i + 1).ToString(),
                    sc.getList()[i].Name,
                    sc.getList()[i].Tel,
                    sc.getList()[i].Address,
                    sc.getList()[i].Email });
            }

            int count = gridView.Rows.Count - 1;
            gridView.FirstDisplayedScrollingRowIndex = count;
            gridView.CurrentCell = gridView.Rows[count - 1].Cells[0];
        }

        private void viewExti_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // listview에서 선택한 아이템 정보
            if (listView.SelectedItems.Count != 0)
            {
                int n = listView.SelectedItems[0].Index;
                String name = listView.Items[n].SubItems[1].Text;
                String tel = listView.Items[n].SubItems[2].Text;
                String addr = listView.Items[n].SubItems[3].Text;
                String email = listView.Items[n].SubItems[4].Text;
                Console.WriteLine("이름 : {0}", name);
                Console.WriteLine("전화 : {0}", tel);
                Console.WriteLine("주소 : {0}", addr);
                Console.WriteLine("메일 : {0}", email);
            }
        }*/

        private void del_Click(object sender, EventArgs e)
        {
            if(listView.SelectedItems.Count != 0)
            {
                int n = listView.SelectedItems[0].Index;
                String name = listView.Items[n].SubItems[1].Text;
                String tel = listView.Items[n].SubItems[2].Text;
                String delChecker = MainForm.myInputBox(name + "의 정보를 삭제하시겠습니까? (y/n)", "데이터 삭제", "");
                if(delChecker == "y")
                {
                    sc.delItem(name, tel);
                    MessageBox.Show("삭제되었습니다.", "데이터 삭제 완료");

                    listView.Items.Clear();
                    initListView();

                    gridView.Rows.Clear();
                    initGridView();
                }
                else if(delChecker == "n")
                {
                    MessageBox.Show("취소되었습니다.", "데이터 삭제 취소");
                }
                else
                {
                    MessageBox.Show("잘못 입력하셨습니다.", "잘못된 입력");
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 0)
            {
                int n = listView.SelectedItems[0].Index;
                String name = listView.Items[n].SubItems[1].Text;
                String tel = listView.Items[n].SubItems[2].Text;
                new UpdateDetail(name, tel, sc).ShowDialog();

                listView.Items.Clear();
                initListView();

                gridView.Rows.Clear();
                initGridView();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            new AddForm(sc).ShowDialog();
            listView.Items.Clear();
            initListView();

            gridView.Rows.Clear();
            initGridView();
        }
    }
}
