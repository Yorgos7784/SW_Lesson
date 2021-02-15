using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1번
            /*int result = 0;
            for (int i = 0; i < 100; i++)
            {
                if((i+1)%3 == 0)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);*/

            // 2번
            /*Console.Write("값을 입력하세요(초) : ");
            int num = int.Parse(Console.ReadLine());

            int min = 0;
            int sec = 0;
            min = num / 60;
            sec = num % 60;
            Console.WriteLine(min + "분" + sec + "초");*/

            // 3번
            /*Console.Write("값을 입력하세요 : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = i; j < (num-1); j++)
                {
                    Console.Write(" ");
                }
                
                for (int k = 0; k < i*2+1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }*/


            // 4번
            /*for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.WriteLine($"{i+2} x {j+1} = {(i+2) * (j+1)}");
                }
                Console.WriteLine();
            }*/

            // 5번
            /* Console.Write("숫자를 입력하세요 : ");
             int num = int.Parse(Console.ReadLine());

             switch (num)
             {
                 case 3:
                 case 4:
                 case 5:
                     Console.WriteLine("봄입니다.");
                     break;
                 case 6:
                 case 7:
                 case 8:
                     Console.WriteLine("여름입니다.");
                     break;
                 case 9:
                 case 10:
                 case 11:
                     Console.WriteLine("가을입니다.");
                     break;
                 case 12:
                 case 1:
                 case 2:
                     Console.WriteLine("겨울입니다.");
                     break;
                 default:
                     break;
             }*/

            // 6번
            /*Console.Write("첫번째 값을 입력하세요(x 좌표) : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("두번째 값을 입력하세요(y 좌표) : ");
            int y = int.Parse(Console.ReadLine());

            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("1");
                }
                else if (y < 0)
                {
                    Console.WriteLine("4");
                }
                else if (y == 0)
                {
                    Console.WriteLine("X선 위에 있습니다.");
                }
            }
            else if (x < 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("2");
                }
                else if (y < 0)
                {
                    Console.WriteLine("3");
                }
                else if (y == 0)
                {
                    Console.WriteLine("X선 위에 있습니다.");
                }
            }
            else if (x == 0)
            {
                if(y > 0)
                {
                    Console.WriteLine("Y선 위에 있습니다.");
                }
                else if (y < 0)
                {
                    Console.WriteLine("Y선 위에 있습니다.");
                }
                else if (y == 0)
                {
                    Console.WriteLine("0");
                }
            }*/
            

            // 7번



                      
            // 8번
            Console.Write("수를 입력하세요 : ");
            int num1 = int.Parse(Console.ReadLine());
            
            
            



        }
    }
}
