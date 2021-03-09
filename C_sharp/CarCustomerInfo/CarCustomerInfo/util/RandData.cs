using System;

namespace CarCustomerInfo
{
    class RandData
    {
        private string[] lastName = { "김", "이", "박", "최", "강" };
        private string[] firstName1 = { "춘", "덕", "광", "미", "용" };
        private string[] firstName2 = { "삼", "배", "자", "국", "봉", "심", "숙", "식" };
        private string[] address = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };
        private string[] emailId = { "hong", "kim", "park", "choi", "kang", "lee" };
        private string[] emailadd = { "@naver.com", "@gmail.com", "@hanmail.net" };

        private string[] company = { "현대", "기아", "쉐보레", "BMW", "AUDI" };
        private string[] model = { "소나타", "산타페", "미니쿠퍼", "모닝", "스파크" };
        private string[] color = { "White", "Black", "Red", "Yellow", "Gray" };

        Random r = new Random();

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

        public string getComp()
        {
            return company[r.Next(0, company.Length)];
        }

        public string getmodel()
        {
            return model[r.Next(0, model.Length)];
        }

        public string getcolor()
        {
            return color[r.Next(0, color.Length)];
        }

        public string getprice()
        {
            return r.Next(1000, 10000) + "만원";
        }
    }
}
