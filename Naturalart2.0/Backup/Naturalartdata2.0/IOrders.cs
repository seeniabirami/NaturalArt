using NaturalArtData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaturalArtData
{
    public interface IOrder
    {
       
        IEnumerable<Order> GetAll();
        Order GetOrderbyID(int CusID,int OrderID);
        Order GetOrderbyID(int OrderID);
        Order GetCartbyCusID(int CusID);
        void DeleteOrder(int id);
        bool UpdateOrder(Order recOrder);
        bool InsertOrder(Order recOrder);
        bool UpdateShipping(Order recOrder);
        bool InsertShipping(Order recOrder);
    }
}
