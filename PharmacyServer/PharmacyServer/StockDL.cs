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
        public static List<StockClass> searchByName(string name)
        {
            List<StockClass> namelist = new List<StockClass>();
            StockClass s = new StockClass();
            s.ItemName = name;
            foreach(StockClass l in stocklist)
            {
                if (l.ItemName == s.ItemName)
                {
                    namelist.Add(l);
                }
            }
            return namelist;

        }
        public static List<StockClass> searchByType(string type)
        {
            List<StockClass> typelist = new List<StockClass>();
            StockClass s = new StockClass();
            s.ItemType = type;
            foreach (StockClass l in stocklist)
            {
                if (l.ItemType == s.ItemType)
                {
                    typelist.Add(l);
                }
            }
            return typelist;

        }
        public static List<StockClass> searchByFormula(string formula)
        {
            List<StockClass> formulalist = new List<StockClass>();
            StockClass s = new StockClass();
            s.ItemFormula =formula;
            foreach (StockClass l in stocklist)
            {
                if (l.ItemFormula == s.ItemFormula)
                {
                    formulalist.Add(l);
                }
            }
            return formulalist;

        }

    }
}