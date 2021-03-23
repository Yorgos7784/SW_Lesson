using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager_0323.Model
{
    class OrderTable
    {
        private string order_date;
        private Customer customer;
        private Car car;
        private Seller seller;

        public OrderTable(string order_date, Customer customer, Car car, Seller seller)
        {
            this.order_date = order_date;
            this.customer = customer;
            this.car = car;
            this.seller = seller;
        }

        public string Order_date { get => order_date; set => order_date = value; }
        internal Customer Customer { get => customer; set => customer = value; }
        internal Car Car { get => car; set => car = value; }
        internal Seller Seller { get => seller; set => seller = value; }
    }
}
