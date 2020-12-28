using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201228_Cshop_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1, 2번 문제
            /*Console.Write("숫자를 입력하세요(배열 크기) : ");
            int arsize = int.Parse(Console.ReadLine());
            int[] arr = new int[arsize];
            Console.Write("수를 3개 입력하세요 : ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = arr[0];
            int min = arr[0];
            int maxnum = 0;
            int minnum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    maxnum = i + 1;
                }
                else if (max == arr[0])
                {
                    maxnum = 1;
                }
                if (min > arr[i])
                {
                    min = arr[i];
                    minnum = i + 1;
                }
                else if (min == arr[0])
                {
                    minnum = 1;
                }

            }
            Console.WriteLine($"최대값 : {max}({maxnum}번째)");
            Console.WriteLine($"최소값 : {min}({minnum}번째)");*/

            // 3번
            Console.Write("수를 3개 입력하세요 : ");
            int result = int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine());
            string number = result.ToString();
            Console.WriteLine(number);
            char[] numarr = number.ToCharArray();

            for (int i = 0; i < 10; i++)
            {
                int count = 0;
                for (int j = 0; j < numarr.Length; j++)
                {
                    int num = (int)char.GetNumericValue(numarr[j]);
                    if(num == i)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{i}의 갯수 : {count}");
            }
            

        }
    }
}
