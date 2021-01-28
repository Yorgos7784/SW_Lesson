using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btnTmp = (Button)sender;
            textBox1.Text += btnTmp.Text;
        }

        private void result_Click(object sender, EventArgs e)
        {
            String plus = "+";
            String minus = "-";
            String gob = "*";
            String divide = "/";
            bool p = textBox1.Text.Contains(plus);
            bool m = textBox1.Text.Contains(minus);
            bool g = textBox1.Text.Contains(gob);
            bool d = textBox1.Text.Contains(divide);
            String[] numSplit = textBox1.Text.Split('+', '-', '*', '/');
            double result = Convert.ToDouble(numSplit[0]);
            if (p == true)
            {
                for (int i = 1; i < numSplit.Length; i++)
                {
                    result += Convert.ToDouble(numSplit[i]);
                }
                textBox1.Text = Convert.ToString(result);
            }
            else if (m == true)
            {
                for (int i = 1; i < numSplit.Length; i++)
                {
                    result -= Convert.ToDouble(numSplit[i]);
                }
                textBox1.Text = Convert.ToString(result);
            }
            else if (g == true)
            {
                for (int i = 1; i < numSplit.Length; i++)
                {
                    result *= Convert.ToDouble(numSplit[i]);
                }
                textBox1.Text = Convert.ToString(result);
            }
            else if (d == true)
            {
                for (int i = 1; i < numSplit.Length; i++)
                {
                    result /= Convert.ToDouble(numSplit[i]);
                }
                textBox1.Text = Convert.ToString(result);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
