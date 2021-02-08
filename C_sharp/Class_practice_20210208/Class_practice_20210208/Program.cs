using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_20210208
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.showCarInfo();
            Car car2 = new Car("현대", "흰색", "G80", "6천만원");
            car2.showCarInfo();
        }
    }
}
