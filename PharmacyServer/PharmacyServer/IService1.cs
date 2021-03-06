﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PharmacyServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void Register(string name, string password);
        [OperationContract]

        bool login(string name, string password);

       [OperationContract]
       bool resetPassword(string old_password, string new_password);
        [OperationContract]
        bool forgetPassword(string name, string new_password);
        [OperationContract]
        void add(string name, string type, string formula, int price, int quantity, DateTime exp);
        [OperationContract]
        void delete_product(int ind);
        [OperationContract]
        List<StockClass> showAll();
        [OperationContract]
        void update(string name, string type, int price, int quantity);

        [OperationContract]
        List<StockClass> searchName(string name);
        [OperationContract]
        List<StockClass> searchFormula(string formula);
        [OperationContract]
        List<StockClass> searchType(string type);

        [OperationContract]
        void add_order(string name,string type,int quantity, int price, int total);
        [OperationContract]
        List<OrderClass> showorder();
        [OperationContract]
        string GetData(int value);
        [OperationContract]
        void deleteOrder(int index);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
