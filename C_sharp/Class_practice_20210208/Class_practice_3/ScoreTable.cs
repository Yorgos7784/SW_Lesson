using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_3
{
    class ScoreTable
    {
        private int[] arr;

        public ScoreTable(int[] arr)
        {
            this.arr = arr;
        }

        public int getSum()
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public int getAve(int sum)
        {
            return sum / arr.Length;
        }

        public string getResult(int ave)
        {
            if (100 >= ave && ave >= 90)
                return "A학점";
            else if (89 >= ave && ave >= 80)
                return "B학점";
            else if (79 >= ave && ave >= 70)
                return "c학점";
            else if (69 >= ave && ave >= 60)
                return "D학점";
            else
                return "B학점";
        }

        public void showResult(int num)
        {
            Console.WriteLine(num + "번 학생 결과");
            Console.WriteLine("총점 : " + getSum());
            Console.WriteLine("평균 : " + getAve(getSum()));
            Console.WriteLine("학점 : " + getResult(getAve(getSum())));
            Console.WriteLine("---------------------------------");
        }
    }
}
