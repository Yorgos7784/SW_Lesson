using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcVer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = textBox1.Text + "1";
            //textBox1.Text += "1";
            //textBox1.Text = textBox1.Text + button1.Text;
            //Button btn = (Button)sender;
            //textBox1.Text += button1.Text;
            ButtonsClick(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ButtonsOperator(sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ButtonsOperator(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ButtonsOperator(sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ButtonsOperator(sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        void ButtonsClick(object sender)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;

            if (textBox1.Text.Contains("+"))
            {
                String[] str1 = textBox1.Text.Split("+".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (str1.Length == 2)
                {
                    int num1 = Convert.ToInt32(str1[0]);
                    int num2 = Convert.ToInt32(str1[1]);
                    int result = num1 + num2;
                    textBox1.Text = "" + result;
                }
            }

            else if (textBox1.Text.Contains("-"))
            {
                String[] str1 = textBox1.Text.Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (str1.Length == 2)
                {
                    int num1 = Convert.ToInt32(str1[0]);
                    int num2 = Convert.ToInt32(str1[1]);
                    int result = num1 - num2;
                    textBox1.Text = "" + result;
                }
            }

            else if (textBox1.Text.Contains("*"))
            {
                String[] str1 = textBox1.Text.Split("*".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (str1.Length == 2)
                {
                    int num1 = Convert.ToInt32(str1[0]);
                    int num2 = Convert.ToInt32(str1[1]);
                    int result = num1 * num2;
                    textBox1.Text = "" + result;
                }
            }

            else if (textBox1.Text.Contains("/"))
            {
                String[] str1 = textBox1.Text.Split("/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries); 
                if (str1.Length == 2)
                {
                    int num1 = Convert.ToInt32(str1[0]);
                    int num2 = Convert.ToInt32(str1[1]);
                    int result = num1 / num2;
                    textBox1.Text = "" + result;
                }
            }
        }

        void ButtonsOperator(object sender)
        {
            if (textBox1.Text.Length > 0)
            {
                //textBox1.Text 값의 마지막 문자열을 가져온다
                String s1 = textBox1.Text.Substring(textBox1.Text.Length - 1, 1);
                Button btn = (Button)sender;
                if (btn.Text.Equals("+"))
                {
                    if (s1 == "+"){}
                    else{textBox1.Text += btn.Text;}
                }

                else if (btn.Text.Equals("-"))
                {
                    if (s1 == "-") {}
                    else{textBox1.Text += btn.Text;}
                }

                else if (btn.Text.Equals("*"))
                {
                    if (s1 == "*") {}
                    else{textBox1.Text += btn.Text;}
                }

                else if (btn.Text.Equals("/"))
                {
                    if (s1 == "/") {}
                    else{textBox1.Text += btn.Text;}
                }
            }
        }
    }
}