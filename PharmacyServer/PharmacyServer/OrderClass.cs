using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmacyServer
{
    public class OrderClass
    {
        private string itemName;
        private string itemType;
        private int itemQuantity;
         private int itemPrice;
         private int Total;


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

        public int Total1
        {
            get
            {
                return Total;
            }

            set
            {
                Total = value;
            }
        }


    }
}