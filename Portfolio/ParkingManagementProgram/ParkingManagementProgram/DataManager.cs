using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace ParkingManagementProgram
{
    class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();
        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            Cars.Clear();
            try
            {
                string carsOutput = File.ReadAllText(@"./Cars.xml");
                XElement carXElement = XElement.Parse(carsOutput);
                foreach (var item in carXElement.Descendants("car"))
                {
                    int tempParkingSpot = int.Parse(item.Element("parkingSpot").Value);
                    string tempCarNumber = item.Element("carNumber").Value;
                    string tempDriverName = item.Element("driverName").Value;
                    string tempPhoneNumber = item.Element("phoneNumber").Value;
                    DateTime tempParkingTime = item.Element("parkingTime").Value == "" ?
                        DateTime.Now : DateTime.Parse(item.Element("parkingTime").Value);

                    ParkingCar tempCar = new ParkingCar()
                    {
                        parkingSpot = tempParkingSpot,
                        carNumber = tempCarNumber,
                        driverName = tempDriverName,
                        phoneNumber = tempPhoneNumber,
                        parkingTime = tempParkingTime
                    };
                    Cars.Add(tempCar);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printLog(ex.Message);
                printLog(ex.StackTrace);

                // 만약 파일이 없어서 진입한 경우
                CreateFile(); // 파일 생성
                Save(); // 파일저장
                Load(); // 다시 불러오기
                // Load함수에 문제가 있을 시 무한루프에 빠진다.
            }
        }

        private static void CreateFile()
        {
            string fileName = @"./Cars.xml";
            StreamWriter writer = File.CreateText(fileName);// 파일이 없으면 해당 파일 생성
            writer.Dispose(); // 메모리 해제
        }

        public static void Save()
        {
            string booksOutput = string.Empty;
            booksOutput += "<cars>\n";
            if (Cars.Count > 0)
            {
                foreach (var item in Cars)
                {
                    booksOutput += "<car>\n";
                    booksOutput += $"   <parkingSpot>{item.parkingSpot}</parkingSpot>\n";
                    booksOutput += $"   <carNumber>{item.carNumber}</carNumber>\n";
                    booksOutput += $"   <driverName>{item.driverName}</driverName>\n";
                    booksOutput += $"   <phoneNumber>{item.phoneNumber}</phoneNumber>\n";
                    booksOutput += $"   <parkingTime>{item.parkingTime}</parkingTime>\n";
                    booksOutput += "</car>\n";
                }
                
            }
            else //xml파일에 아무것도 없는 경우
            {
                for (int i = 0; i < 5; i++)
                {
                    booksOutput += "<car>\n";
                    booksOutput += $"   <parkingSpot>{i}</parkingSpot>\n";
                    booksOutput += "   <carNumber></carNumber>\n";
                    booksOutput += "   <driverName></driverName>\n";
                    booksOutput += "   <phoneNumber></phoneNumber>\n";
                    booksOutput += "   <parkingTime></parkingTime>\n";
                    booksOutput += "</car>\n";
                }
            }
            booksOutput += "</cars>";
            File.WriteAllText(@"./Cars.xml", booksOutput);
        }

        // 두번째 파라미터를 적지 않으면 name에는 parkingHistory가 들어감
        public static void printLog(string contents, string name = "parkingHistory")
        {
            string directory = "parkingHistory";
            DirectoryInfo di = new DirectoryInfo(directory);
            if (!di.Exists)
            {
                di.Create(); // 폴더만들기
            }

            // @ : \ 하나 쌉가능 (없으면 \\)
            //using (StreamWriter writer = new StreamWriter(@"parkingHistory\parkingHistory.txt", true))
            using (StreamWriter writer = new StreamWriter(directory + @"\" + name + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }


    }
}
