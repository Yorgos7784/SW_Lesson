using CarManager_0323.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager_0323.Handler
{
    class dealHandler
    {
        List<Deal> dealList = new List<Deal>();

        public dealHandler()
        {
            dealList.Add(new Deal(null, null, null));
        }

        public List<Deal> getOrderList()
        {
            return dealList;
        }

        public void dealListClear()
        {
            dealList.Clear();
            dealList.Add(new Deal(null, null, null));
        }
    }
}
