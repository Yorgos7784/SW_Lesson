using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210129_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] items = {"토맛토마토", "토마토맛토", "토마토"};
            checkedListBox1.Items.AddRange(items);

            checkedListBox1.CheckOnClick = true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String item = checkedListBox1.SelectedItem.ToString();
            //textBox1.Text += item + "\r\n";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("목록에 선택한 내용이 없습니다.");
                return;
            }
            checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            String[] item = {"브레이킹 배드", "베터 콜 사울", "다크", "마인드 헌터", "퀸즈 갬빗"};
            comboBox1.Items.AddRange(item);
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("콤보박스에 선택한 내용이 없습니다.");
                return;
            }
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            textBox1.Text += "Index : " + e.Index + ", Value : " + e.NewValue + "\r\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                textBox1.Text += "Checked : " + checkedListBox1.CheckedItems[i] + "\r\n";
            }
        }
    }
}
