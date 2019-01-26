using System;
using System.Collections.Generic;
using System.Text;
using Naturalartdata;
using Microsoft.EntityFrameworkCore;
using NaturalArtData;
using NaturalArtData.Models;
using System.Linq;

namespace NaturalArtServices
{
    public class OrderService : IOrder 
    {


       public NaturalArtdbContext _context;
        public OrderService(NaturalArtdbContext context)
        {
            _context = context;
        }
        public void DeleteOrder( int id)
        {
           
            var Order = GetOrderbyID(id);
            _context.Remove(Order);
            _context.SaveChanges();
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Order
                .Include(s => s.Status)
                .Include(tA => tA.ToAddress)
                .Include(cus => cus.Customer)
               .Include(od => od.Cartlist);



        }

        public Order GetOrderbyID( int OrderID)
        {
            return GetAll().FirstOrDefault(x => x.OrderID == OrderID);


        }

        public Order GetOrderbyID(int CusID,int OrderID)
        {
            return GetAll().FirstOrDefault(x => x.OrderID == OrderID && x.CustomerID == CusID);
                      
            
        }

      public  Order GetCartbyCusID(int CusID)
        {
            return GetAll().FirstOrDefault(x => x.CustomerID == CusID  && x.OrderStatusName=="InCart")
                ;

        }

        public bool InsertOrder(Order recOrder)
        {
            _context.Add(recOrder);
            _context.SaveChanges();
            return true;

        }

        public bool InsertShipping(Order recOrder)
        {
            _context.Add(recOrder);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateOrder(Order recOrder)
        {
            _context.Update(recOrder);
            _context.SaveChanges();
            return true;
            
        }

        public bool UpdateShipping(Order recOrder)
        {
            _context.Update(recOrder);
            _context.SaveChanges();
            return true;
        }
    }
}
