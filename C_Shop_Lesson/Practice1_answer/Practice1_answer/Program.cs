using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_answer
{
    class Program
    {
        static void Main(string[] args)
        {
            // 복습

            // 프로그램 실행법
            // java : ctrl + f11
            // C# : ctrl + f5

            // java : System.out.println("Hello")
            // c# : Console.WriteLine("Hello")
            // cw taptap
            Console.WriteLine("Hello하고 한줄 띄움");

            // java : System.out.print("Hello") = 출력한뒤 줄바꿈
            // C# :  Console.Write("Hello")
            Console.Write("Hello하고 한줄 안띄움");

            // java : System.out.println("") = 그냥 한줄 띄우기
            // c# : Console.WriteLine("")
            Console.WriteLine("");

            // 변수
            // java와 동일
            int example = 100;

            // 단 String 변수는  String이랑 string 둘다 동일하게 쓸수있다.
            string ex1 = "하이";
            String ex2 = "헬로";
            string 이런것도됨 = "와.신.기.하.다.";
            Console.WriteLine(이런것도됨); // 옛날버전에서는 안돌아갈수 있음

            // 문자열과 숫자 혼합
            string ex3 = example + " 더하기 " + example + "은 " + (example + example) + "이다.";
            string ex4 = $"{example} 더하기 {example}은 {example + example}이다.";
            string ex5 = string.Format("{0} 더하기 {1}은 {2}이다", example, example, example + example);
            Console.WriteLine(ex3);
            Console.WriteLine(ex4);
            Console.WriteLine(ex5);

            // 조건문
            // java와 동일
            if (example > 50)
            {
                Console.WriteLine("example은 50이상");
            }

            if (example > 30)
            {
                Console.WriteLine("30이상");
            }
            else
            {
                Console.WriteLine("30미만");
            }
            
            if (example == 10)
            {
                Console.WriteLine("10");
            }
            else if (example == 20)
            {
                Console.WriteLine("20");
            } // 끝에 꼭 else 안 붙여도 됨

            if (example==10)
            {
                Console.WriteLine("10");
            }
            else if (example==20)
            {
                Console.WriteLine("20");
            }
            else
            {
                Console.WriteLine("10이랑 20은 아님");
            }

            // switch(java와 동일)
            switch (example)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;
                default:
                    Console.WriteLine("10이랑 20은 아님");
                    break;
            }

            // 반복문
            // 단 foreach라는 특수 문법이 있는데 이건 나중에...
            // 몰라도 됨
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"같은 말 {i+1}번 반복하기");
            }
            
            int temp = 10;
            while (temp > 0)
            {
                temp--;
            }
            
            do
            {
                temp++;
            } while (temp<10);

            // 입출력
            // java
            /*
             * Scanner s = new Scanner(System.in);
             * String test = s.nextLine();
             * int test2 = s.nextInt();
             */

            // C#
            // String test = Console.ReadLine();
            // int test2 = int.Parse(Console.ReadLine();)

            string test = Console.ReadLine();
            int test2 = int.Parse(Console.ReadLine());


        }
    }
}
