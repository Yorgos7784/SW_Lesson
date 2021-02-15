using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1번 문제");
            const double PI = 3.14;
            int r = 5;
            Console.WriteLine("원의 넓이 : " + r * r * PI);
            Console.WriteLine("-----------------");

            Console.WriteLine("2번 문제");
            int kor = 90;
            int eng = 80;
            int math = 70;
            int sci = 60;
            int sum = kor + eng + math + sci;
            double ave = sum / 4.0;
            Console.WriteLine("총점 : " + sum);
            Console.WriteLine("평균 : " + ave);
            Console.WriteLine("-----------------");

            Console.WriteLine("3번 문제");
            int eng1 = 21;
            int eng2 = 5;
            int kor1 = 19;
            int kor2 = 10;
            Console.WriteLine("알파벳 자음 갯수 : " + eng1);
            Console.WriteLine("알파벳 모음 갯수 : " + eng2);
            Console.WriteLine("한글 자음 갯수 : " + kor1);
            Console.WriteLine("한글 모음 갯수 : " + kor2);
            Console.WriteLine("-----------------");

            Console.WriteLine("4번 문제");
            int f = 40;
            double c = (f - 32) / 1.8;
            Console.WriteLine("섭씨 " + c + "℃");
            Console.WriteLine("-----------------");

            Console.WriteLine("5번 문제");
            Console.Write("반지름을 입력하세요 : ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("원의 넓이 : " + r * r * PI);
            Console.Write("국어점수를 입력하세요 : ");
            kor = Convert.ToInt32(Console.ReadLine());
            Console.Write("영어점수를 입력하세요 : ");
            eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("수학점수를 입력하세요 : ");
            math = Convert.ToInt32(Console.ReadLine());
            Console.Write("과학점수를 입력하세요 : ");
            sci = Convert.ToInt32(Console.ReadLine());
            sum = sum = kor + eng + math + sci;
            ave = sum / 4.0;
            Console.WriteLine("총점 : " + sum);
            Console.WriteLine("평균 : " + ave);
            Console.WriteLine("-----------------");
        }
    }
}
