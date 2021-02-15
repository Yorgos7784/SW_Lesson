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
            SumAve result = new SumAve(arr);

            SumAve result2 = new SumAve();
            result2.getSumAve(arr);

            SumAve result3 = new SumAve();
            result3.Arr = arr;
            result3.getSumAve();

            new SumAve(arr);
        }
    }
}
