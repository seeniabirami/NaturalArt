using System;
using System.Collections.Generic;
using System.Text;
using NaturalArtData.Models;
namespace NaturalArtData
{
    public interface IOrderDetails
        {
  
        List<OrderDetails> GetAll();
        OrderDetails GetOrderDetailbyID(int prmOrderID, int ID);
       
        List<OrderDetails> GetAllByOrderID(int OrderID);
      
        void UpdateOrderDetail(OrderDetails recOrder);
        void InsertOrderDetail(OrderDetails recOrder);
        void DeleteOrderDetByOrder(OrderDetails recOrder);


    }
}

