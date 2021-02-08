using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBox_add_delete_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] item = { "아무거나", "입력", "했다" };
            checkedListBox1.Items.AddRange(item);

            checkedListBox1.CheckOnClick = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("선택한 항목 없음");
                return;
            }
            checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] item = { "가", "나", "다", "라", "마" };
            comboBox1.Items.AddRange(item);

            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("선택한 항목 없음");
                return;
            }
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }
    }
}
