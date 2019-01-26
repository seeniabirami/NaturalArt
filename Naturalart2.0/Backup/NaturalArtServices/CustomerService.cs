using System;
using System.Collections.Generic;
using System.Text;
using NaturalArtData;
using NaturalArtData.Models;

using System.Linq;


using Microsoft.EntityFrameworkCore;
using Naturalartdata;

namespace NaturalArtServices
{
    public class CustomerService : ICustomer

    {
        private NaturalArtdbContext _context;

        public CustomerService(NaturalArtdbContext context)
        {
            _context = context;
        }
        public bool DeleteCustomer(int id)
        {
            var recOrder = GetCustomerbyID(id);

            _context.Remove(recOrder);
            _context.SaveChanges();
            return true;

        }



        public IEnumerable<Customer> GetAll()
        {
            return _context.Customer;
               
        }

        public Customer GetCustomerbyID(int ID)
        {
            return GetAll().FirstOrDefault(a => a.CustomerID == ID);
        }

        public bool InsertCustomer(Customer recOrder)
        {
            _context.Add(recOrder);
            _context.SaveChanges();
            return true;
        }

        public bool updateCustomer(Customer recOrder)
        {
            _context.Update(recOrder);
            _context.SaveChanges();
            return true;

        }


        public bool VerifyLoginUser(string prmUsername, string prmPwd)
        {
            int reccnt = _context.Artist.Where(x => x.UserName == prmUsername && x.Password == prmPwd).Count();
            if (reccnt == 1)
            {
                return true;
            }
            return false;
        }
        public bool VerifyUser(string prmUsername, string prmPwd)
        {
            int reccnt = _context.Artist.Where(x => x.UserName == prmUsername).Count();
            if (reccnt > 0)
            {
                return false;
            }
            return true;
        }
        public bool VerifyEmail(string prmEmail)
        {
            int reccnt = _context.Artist.Where(x => x.EmailID == prmEmail).Count();
            if (reccnt > 0)
            {
                return false;
            }
            return true;
        }

    }
}
