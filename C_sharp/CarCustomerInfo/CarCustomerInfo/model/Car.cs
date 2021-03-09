using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCustomerInfo
{
    class Car
    {
        private string company;
        private string model;
        private string color;
        private string price;
        private Customer customer;

        public Car(string company, string model, string color, string price, Customer customer)
        {
            this.company = company;
            this.model = model;
            this.color = color;
            this.price = price;
            this.customer = customer;
        }

        public string Company { get => company; set => company = value; }
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public string Price { get => price; set => price = value; }
        internal Customer Customer { get => customer; set => customer = value; }
    }
}
