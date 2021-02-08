using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210129_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("checkBox1.Checked : " + checkBox1.Checked);
            //checkBox1.Checked = true;
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
                MessageBox.Show("췤!");
            }
            //checkBox1.Checked = !checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 체크박스 리스트에 항목 추가
            string[] myFruit = { "Apples", "Oranges", "Tomato" };
            checkedListBox1.Items.AddRange(myFruit);

            // 한번 클릭으로 선택
            checkedListBox1.CheckOnClick = true;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //if (e.NewValue == CheckState.Unchecked)
            //{

            //}
            //else
            //{

            //}

            textBox1.Text += "e.NewValue : " + e.NewValue + "\r\n";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 선택된 항목의 값을 String으로 가져온다
            //string curItem = checkedListBox1.SelectedItem.ToString();
            //textBox1.Text += "curItem : " + curItem + "\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "selecte index : " + checkedListBox1.SelectedIndex + "\r\n";

            if(checkedListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Item is not available in checkedListBox1");
            }

            checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);

            //// Find the string in ListBox2.
            //int index = listBox2.FindString(curItem);
            //// If the item was not found in ListBox 2 display a message box, otherwise select it in ListBox2.
            //if (index == -1)
            //    MessageBox.Show("Item is not available in ListBox2");
            //else
            //    listBox2.SetSelected(index, true);
        }
    }
}