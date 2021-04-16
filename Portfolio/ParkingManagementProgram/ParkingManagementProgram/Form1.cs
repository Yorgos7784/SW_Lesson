using System;
using System.Windows.Forms;

namespace ParkingManagementProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //DataManager.Load();
            /*List<ParkingCar> cars = new List<ParkingCar>();
            cars.Add(new ParkingCar() 
            { 
                parkingSpot = 1, 
                carNumber = "30고9468", 
                driverName = "황창식", 
                phoneNumber = "010-6626-7784", 
                parkingTime = DateTime.Now 
            });*/

            dataGridView1.DataSource = DataManager.Cars;
            textBox1.Text = DataManager.Cars[0].parkingSpot.ToString();
            textBox2.Text = DataManager.Cars[0].carNumber;
            textBox3.Text = DataManager.Cars[0].driverName;
            textBox4.Text = DataManager.Cars[0].phoneNumber;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "지금은 : " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " 입니다.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeLog("주차버튼 클릭", DateTime.Now.ToString("yyyy_MM_dd"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeLog("출차버튼 클릭", DateTime.Now.ToString("yyyy_MM_dd"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            writeLog("조회버튼 클릭", DateTime.Now.ToString("yyyy_MM_dd"));
        }

        private void writeLog(string contents)
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}]{contents}";

            // 옛것이 좋은것이여~(새로운 내용 밑으로 추가)
            //listBox1.Items.Add(logContents);

            // 신문물이 짱이다(새로운 내용 위로 추가)
            listBox1.Items.Insert(0, logContents);
            DataManager.printLog(logContents);

        }

        private void writeLog(string contents, string date)
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}]{contents}";
            listBox1.Items.Insert(0, logContents);
            DataManager.printLog(logContents, date);
        }
    }
}
