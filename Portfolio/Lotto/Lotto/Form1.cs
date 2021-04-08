using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        string[] words = {"인생에 필요한 것은 용기와 상상력,/그리고 약간의 돈이다.", "로또 외엔 방법 없다.", "돈이란 바닷물과 같다./마시면 마실수록 말라진다.",
            "돈 빌려주기 좋아하는 사람은/그냥 주는 사람이다.", "돈이란 누구에게도/무한한 것은 아니다.", "돈 없이 연애 결혼하면,/즐거운 밤과 슬픈 낮을 갖게된다.",
            "돈은 누군지도 묻지 않고,/그 소유자에게 권리를 준다.", "돈은 양으로 따질 뿐,/질로 따지는 것이 아니다.", "돈을 빌려준 사람은 돈을 빌린/사람보다 훨씬 기억력이 좋다.", "돈을 빌리는 것은/노예가 되는 것이다.",
            "인류는 두 인종을 이루어져 있다./빌리는 자와 빌려주는 자들로.", "지갑이 가벼우면/마음이 무겁다."};
        string[] names = {"찰리 채플린", "대한민국 누군가", "쇼펜하우어", "조지 하버트", "손자병법", "영국 속담", "라스킨", "짐멜", "프랭클린", "에머슨", "C.램", "괴테" };
        public Form1()
        {
            InitializeComponent();
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World");

            Random r = new Random();
            //MessageBox.Show(r.Next(1, 11).ToString());

            int[] nums = new int[7];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(1, 46);
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        i--;
                        break;
                    }
                }
            }

            num1.Text = nums[0].ToString();
            num1.BackColor = numColor(nums[0]);
            num2.Text = nums[1].ToString();
            num2.BackColor = numColor(nums[1]);
            num3.Text = nums[2].ToString();
            num3.BackColor = numColor(nums[2]);
            num4.Text = nums[3].ToString();
            num4.BackColor = numColor(nums[3]);
            num5.Text = nums[4].ToString();
            num5.BackColor = numColor(nums[4]);
            num6.Text = nums[5].ToString();
            num6.BackColor = numColor(nums[5]);
            Bonus.Text = nums[6].ToString();
            Bonus.BackColor = numColor(nums[6]);

            int word = r.Next(0, words.Length);
            if(word == 1)
            {
                title1.Text = string.Format("\"{0}\"", words[1]);
                title2.Text = "";
            }
            else
            {
                string[] titles = words[word].Split('/');
                title1.Text = string.Format("\"{0}", titles[0]);
                title2.Text = string.Format("{0}\"", titles[1]);
            }
            name.Text = string.Format("- {0} -", names[word]);
        }

        public Color numColor(int num)
        {
            if(num >= 1 && num <= 10)
            {
                return Color.Goldenrod;
            }
            else if(num >= 11 && num <= 20)
            {
                return Color.CornflowerBlue;
            }
            else if(num >= 21 && num <= 30)
            {
                return Color.IndianRed;
            }
            else if(num >= 31 && num <= 40)
            {
                return Color.DarkGray;
            }
            else
            {
                return Color.MediumSeaGreen;
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
