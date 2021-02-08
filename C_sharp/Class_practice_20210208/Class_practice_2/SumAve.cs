using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_2
{
    class SumAve
    {
        private int sum;
        private int ave;

        public int getSum(int[] arr)
        {
            sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public int getAve(int[] arr, int sum)
        {
            ave = sum / arr.Length;
            return ave;
        }
    }
}
