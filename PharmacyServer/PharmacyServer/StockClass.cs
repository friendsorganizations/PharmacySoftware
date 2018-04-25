using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmacyServer
{
    public class StockClass
    {
        private string itemName;
        private string itemFormula;
        private string itemType;
        private int itemQuantity;
        private int itemPrice;
        private DateTime itemDate;

        public string ItemName
        {
            get
            {
                return itemName;
            }

            set
            {
                itemName = value;
            }
        }

        public string ItemFormula
        {
            get
            {
                return itemFormula;
            }

            set
            {
                itemFormula = value;
            }
        }

        public string ItemType
        {
            get
            {
                return itemType;
            }

            set
            {
                itemType = value;
            }
        }

        public int ItemQuantity
        {
            get
            {
                return itemQuantity;
            }

            set
            {
                itemQuantity = value;
            }
        }

        public int ItemPrice
        {
            get
            {
                return itemPrice;
            }

            set
            {
                itemPrice = value;
            }
        }

        public DateTime ItemDate
        {
            get
            {
                return itemDate;
            }

            set
            {
                itemDate = value;
            }
        }
    }
}