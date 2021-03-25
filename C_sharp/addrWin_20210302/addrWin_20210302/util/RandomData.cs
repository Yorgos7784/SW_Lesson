using System;
using System.Text;

namespace adressTest0218.util
{
    class RandomData
    {
        private static string[] lastName = { "김", "이", "박", "최", "강" };
        private static string[] firstName1 = { "춘", "덕", "광", "미", "용" };
        private static string[] firstName2 = { "삼", "배", "자", "국", "봉", "심", "숙", "식" };
        private static string[] address = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };
        private static string[] emailId = { "hong", "kim", "park", "choi", "kang", "lee" };
        private static string[] emailadd = { "@naver.com", "@gmail.com", "@hanmail.net" };

        readonly Random r = new Random();

        public RandomData() { }

        public string getName() 
        { 
            return lastName[r.Next(0, lastName.Length)] + firstName1[r.Next(0, firstName1.Length)] + firstName2[r.Next(0, firstName2.Length)]; 
        }
        public string getTel() 
        { 
            return "010-" + r.Next(1000, 10000) + "-" + r.Next(1000, 10000); 
        }
        public string getAddr() 
        { 
            return address[r.Next(0, 5)]; 
        }
        public string getEmail()
        {
            return emailId[r.Next(0, emailId.Length)] + emailadd[r.Next(0, emailadd.Length)]; 
        }

        public string getId()
        {
            string rdata = "abcdefghijklmnopqrstuvwxyz" + "0123456789" + "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + "~!@#$%^&*?";
            StringBuilder rs = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                rs.Append(rdata[(int)(r.NextDouble() * rdata.Length)]);
            }
            return rs.ToString();
        }
    }
}