using System;
using System.Collections.Generic;
using System.Text;
using NaturalArtData;
using Microsoft.EntityFrameworkCore;
using NaturalArtData.Models;
using System.Linq;

namespace NaturalArtServices
{
    public class OrderDetailServices : IOrderDetails
    {

        public NaturalArtdbContext _context;
        public OrderDetailServices(NaturalArtdbContext context)
        { _context = context; }
        public List<OrderDetails> GetAllByOrderID(int prmOrderID)
        {
            return GetAll()
                 .Where(x => x.OrderID == prmOrderID).ToList();

        }
        public List<OrderDetails> GetAll()
        {
            return _context.Orderdetail
                .Include(x => x.Item).ToList();
        }
      
        public OrderDetails GetOrderDetailbyID(int prmOrderID, int ItemID)
        {
            return GetAllByOrderID(prmOrderID).FirstOrDefault(x => x.ItemID == ItemID);
        }

        public void DeleteOrderDetByOrder(OrderDetails OrderDetail)
        {
         
            _context.Remove(OrderDetail);
            _context.SaveChanges();
        }

       

       

        public void InsertOrderDetail( OrderDetails recOrder)
        {
            _context.Add(recOrder);
            _context.SaveChanges();
        }

        public void UpdateOrderDetail( OrderDetails recOrder)
        {
            _context.Update(recOrder);
            _context.SaveChanges();
        }

       
    }
}
