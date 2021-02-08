using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            SumAve result = new SumAve();
            Console.WriteLine("배열의 합 : " + result.getSum(arr));
            Console.WriteLine("배열의 평균 : " + result.getAve(arr, result.getSum(arr)));
        }
    }
}
