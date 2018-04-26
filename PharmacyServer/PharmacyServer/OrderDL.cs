using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmacyServer
{
    public class OrderDL
    {
        public static List<OrderClass> orderlist = new List<OrderClass>();
        void addOrder(OrderClass selecteditems)
        {
            orderlist.Add(selecteditems);
        }
        public void deleteOrder(int index)
        {

            OrderDL.orderlist.RemoveAt(index);
        }
    }
}