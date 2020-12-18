using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문제풀이 시작");
            /*Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("1번 문제 : 배수의 합 구하기");
            int result = 0;
            for (int i = 0; i < 100; i++)
            {
                if(i%3 == 0)
                result += i;
            }
            Console.WriteLine($"1부터 100까지의 수 중 3의 배수의 합은 {result}이다");

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("2번 문제 : 시간 구하기");
            Console.Write("숫자를 입력하세요 : ");
            int time = int.Parse(Console.ReadLine());
            //int min = time / 60;
            //int sec = time % 60;
            Console.WriteLine($"{time/60}분 {time%60}초");

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("3번 문제 : 피라미드");
            Console.Write("몇층까지 쌓겠느냐? : ");
            int floor = int.Parse(Console.ReadLine());
            for (int i = 0; i < floor; i++)
            {
                // 공백 + *
                for (int j = floor; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i*2+1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("4번 문제 : 구구단");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    Console.Write($"{j} x {i} = {i*j}\t");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("5번 문제 : 계절 판독기");
            Console.Write("월을 입력하세요 : ");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을");
                    break;
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울");
                    break;
                default:
                    Console.WriteLine("잘못된 값입니다.");
                    break;
            }

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("6번 문제 : 사분면 판독기");
            Console.Write("첫번째 숫자를 입력하세요 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("두번째 숫자를 입력하세요 : ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > 0 && num2 > 0)
                Console.WriteLine("1");
            else if (num1 < 0 && num2 < 0)
                Console.WriteLine("2");
            else if (num1 < 0 && num2 < 0)
                Console.WriteLine("3");
            else if (num1 > 0 && num2 < 0)
                Console.WriteLine("4");
            else
                Console.WriteLine("0");

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("7번 문제 : ★개미 수열");
            String start = "1";
            for (int i = 0; i < 20; i++)
            {
                int count = 0; // 각 자리 숫자의 갯수
                string end = ""; // 문자열을 누적시키는 변수
                Console.WriteLine($"{i+1}번째 : {start}"); // 말하기
                char number = start[0]; // 내가 가리키는 숫자

                for (int j = 0; j < start.Length; j++) // 수열 읽어들이기
                {
                    if (number != start[j])
                    {
                        end = end + number + count; // end = "" + '1' + 1
                        number = start[j]; // 가리키는 숫자를 다른걸로 바꿈
                        count = 1; // count는 1로 초기화(다른 숫자 카운트 시작)
                    }
                    else
                    {
                        count++;
                    }
                }
                end = end + number + count;
                start = end;
            }*/

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("7번 문제 : Centered Hexagonal Number");
            Console.Write("숫자를 입력하세요 : ");
            int hexnum = int.Parse(Console.ReadLine());
            int max = 1; // 각 벌집의 최대값
            int counter = 0; // 임의의 카운트 변수
            while (true)
            {
                max = max + (6 * counter);
                if(max<hexnum)
                {
                    counter++;
                    continue;
                }
                else
                    Console.WriteLine($"{hexnum}은  {counter+1}번째 벌짐에 속함");
                break;
            }





        }
    }
}
