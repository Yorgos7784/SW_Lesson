using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCustomerInfo
{
    class CarInfoCtrl
    {
        List<Car> carList = new List<Car>();
        public List<Car> getList()
        {
            return carList;
        }

        public void addCarInfo(string model, string color, string company, string price, string name)
        {
            carList.Add(new Car(model, color, company, price, new Customer(name)));
        }

        public void delCarInfo(string model, string name)
        {
            for (int i = 0; i < carList.Count; i++)
            {
                if(carList[i].Model == model && carList[i].Customer.Name == name)
                {
                    carList.RemoveAt(i--);
                }
            }
        }

        public void updateCarInfo(int num, string model, string color, string company, string price, string name)
        {
            carList[num].Model = model;
            carList[num].Color = color;
            carList[num].Company= company;
            carList[num].Price = price;
            carList[num].Customer.Name = name;
        }
    }
}
