using System;
using System.Linq;
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
            writeLog("주차버튼 클릭");
            if (textBox1.Text.Trim() == "") // 공백
            {
                MessageBox.Show("주차 공간을 입력하세요", "입력 오류");
                writeLog("주차 공간을 입력하세요");
            }
            else if (textBox2.Text.Trim() == "") // 차량번호 입력 x
            {
                MessageBox.Show("차량 번호를 입력하세요", "입력 오류");
                writeLog("차량 번호를 입력하세요");
            }
            else
            {
                try
                {
                    // 참조변수 + 람다
                    ParkingCar car = DataManager.Cars.Single((x) => x.parkingSpot.ToString() == textBox1.Text);
                    if (car.carNumber.Trim() != "") // 이미 차 정보가 저장되어있음
                    {
                        MessageBox.Show(textBox1.Text + "번에는 이미 주차되어 있습니다.", "주차 오류");
                        writeLog(textBox1.Text + "번에는 이미 주차되어 있습니다.");
                    }
                    else // 아직 차 정보가 없음
                    {
                        car.parkingSpot = int.Parse(textBox1.Text);
                        car.carNumber = textBox2.Text;
                        car.driverName = textBox3.Text;
                        car.phoneNumber = textBox4.Text;
                        car.parkingTime = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Cars;
                        DataManager.Save();

                        string contents = $"주차공간 {textBox1.Text}에 {textBox2.Text}차를 주차함";
                        writeLog(contents, DateTime.Now.ToString("yyyy_MM_dd"));
                    }
                }
                catch (Exception ex)
                {
                    string contents = $"{textBox1.Text}에 주차 할 수 없습니다.";
                    MessageBox.Show(contents);
                    writeLog(contents);
                    writeLog(ex.Message);
                    writeLog(ex.StackTrace);
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeLog("출차버튼 클릭");

            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("주차공간 번호를 입력해주세요", "입력 오류");
                return;
            }
            // single 없이 조회하고 해당하는 데이터 변경
            try
            {
                for (int i = 0; i < DataManager.Cars.Count; i++)
                {
                    if (DataManager.Cars[i].parkingSpot.ToString() == textBox1.Text)
                    {
                        if (DataManager.Cars[i].carNumber.Trim() == "")
                        {
                            MessageBox.Show("주차된 차가 없습니다.", "출차 오류");
                            writeLog("주차된 차가 없습니다.");
                            return;
                        }
                        else
                        {
                            DataManager.Cars[i].carNumber = "";
                            DataManager.Cars[i].driverName = "";
                            DataManager.Cars[i].phoneNumber = "";
                            DataManager.Cars[i].parkingTime = DateTime.Now;
                            
                            string contents = $"주차공간 {textBox1.Text}에 {textBox2.Text}차량이 출차되었습니다.";
                            MessageBox.Show(contents);
                            writeLog(contents);
                            
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = DataManager.Cars;
                            DataManager.Save();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                writeLog("출차 오류");
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            writeLog("조회버튼 클릭");
            if (textBox5.Text.Trim() == "") // 공백
            {
                MessageBox.Show("주차 공간을 입력하세요", "입력 오류");
                writeLog("주차 공간을 입력하세요");
            }
            else
            {
                try
                {
                    // 참조변수 + 람다
                    ParkingCar car = DataManager.Cars.Single((x) => x.parkingSpot.ToString() == textBox5.Text);
                    if (car.carNumber.Trim() != "")
                    {
                        MessageBox.Show($"주차 공간 : {car.parkingSpot.ToString()}\n차량 번호 : {car.carNumber}\n차주 이름 : {car.driverName}\n전화 번호 : {car.phoneNumber}", "정보 조회");
                    }
                    else
                    {
                        MessageBox.Show($"{textBox5.Text}에 주차된 차가 없습니다.", "조회 오류");
                        writeLog($"{textBox5.Text}에 주차된 차가 없습니다.");
                    }
                }
                catch (Exception ex)
                {
                    string contents = $"{textBox5.Text}에 차량이 없습니다.";
                    MessageBox.Show(contents);
                    writeLog(contents);
                    writeLog(ex.Message);
                    writeLog(ex.StackTrace);
                }
            }
        }

        public void writeLog(string contents)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ParkingCar temp = dataGridView1.CurrentRow.DataBoundItem as ParkingCar;
                textBox1.Text = temp.parkingSpot.ToString();
                textBox2.Text = temp.carNumber;
                textBox3.Text = temp.driverName;
                textBox4.Text = temp.phoneNumber;
                textBox5.Text = temp.parkingSpot.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }
        }
    }
}
