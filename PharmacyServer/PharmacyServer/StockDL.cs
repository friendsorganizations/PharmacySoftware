using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmacyServer
{
    public class StockDL
    {
        public static List<StockClass> stocklist = new List<StockClass>();
        public static void addProduct(StockClass product)
        {
            stocklist.Add(product);
        }
        public void deleteProduct(int ind)
        {

            StockDL.stocklist.RemoveAt(ind);
}
        public void updateProduct(string name,string type,int price,int quantity) { 
        StockClass c = new StockClass();
        c.ItemName = name;
           
            c.ItemType = type;
            c.ItemPrice = price;
            c.ItemQuantity = quantity;

            foreach (StockClass sl in StockDL.stocklist)
            {
                if (sl.ItemName == c.ItemName && sl.ItemType == c.ItemType)
                {
                    sl.ItemPrice = c.ItemPrice;
                    sl.ItemQuantity = c.ItemQuantity;
                }
            }
}

    }
}