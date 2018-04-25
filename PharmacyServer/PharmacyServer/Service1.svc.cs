using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PharmacyServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public void Register(string name,string password)
        {
            Admin.userName= name;
            Admin.userPassword = password;

        }
      public bool login(string name,string password)
        {
            bool is_val = false;
          
             if(name==Admin.userName && password==Admin.userPassword)
            {
                is_val = true;

            }
            return is_val;

        }

    public    bool resetPassword(string old_password,string new_password)
        {
            bool is_eq = false;
            if (old_password==Admin.userPassword)
            {
                Admin.userPassword = new_password;
                is_eq = true;

            }
            return is_eq;
        
        }
     public   bool forgetPassword(string name, string new_password)
        {
            bool is_cor = false;
            if (name == Admin.userName)
            {
                Admin.userPassword = new_password;
                is_cor = true;
            }

            return is_cor;
            

        }
        public void add(string name,string type,string formula,int price,int quantity,DateTime exp)
        {
            StockClass st = new StockClass();
            st.ItemName = name;
            st.ItemType = type;
            st.ItemFormula = formula;
            st.ItemPrice = price;
            st.ItemQuantity = quantity;
            st.ItemDate = exp;
            StockDL.stocklist.Add(st);
        }

        public void delete_product(int ind)
        {
            StockDL s = new StockDL();
            s.deleteProduct(ind);
           
        }
        public List<StockClass> showAll()
        {
            return StockDL.stocklist;
        }
        public void update(string name, string type, int price, int quantity)
        {
            StockDL st = new StockDL();
            st.updateProduct(name, type, price, quantity);
           
        }
        public List<StockClass> searchName(string name)
        {
            return StockDL.searchByName(name);
        }
        public List<StockClass> searchFormula(string formula)
        {
            return StockDL.searchByFormula(formula);
        }
        public List<StockClass> searchType(string type)
        {
            return StockDL.searchByType(type);
        }
        public void add_order(string name, string type, int quantity,int price,int total)
        {
            OrderClass order = new OrderClass();
            order.ItemName = name;
            order.ItemType = type;
           order.ItemQuantity=quantity;
            order.ItemPrice = price;
            order.Total1 = total;
            OrderDL.orderlist.Add(order);


        }
        public List<OrderClass> showorder()
        {
            return OrderDL.orderlist;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        
    }
}
