using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < Convert.ToInt32(Console.ReadLine()); i++)
            {
                string[] num = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(num[0]);
                int b = Convert.ToInt32(num[1]);
                Console.WriteLine(a + b);
            }
        }
    }
}