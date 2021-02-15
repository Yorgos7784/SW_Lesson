using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1번 문제");
            Console.Write("숫자를 하나 입력하세요 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            string result = (num1 % 2 == 0) ? "짝수입니다." : "홀수입니다.";
            Console.WriteLine(result);
            Console.WriteLine("--------------------");

            Console.WriteLine("2번 문제");
            Console.Write("숫자를 두개 입력하세요 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------");
        }
    }
}
