using System;
using System.Collections.Generic;
using System.Text;
using NaturalArtData.Models;

namespace NaturalArtData
{
 public    interface ICustomer
    {
        IEnumerable<Customer> GetAll();
        Customer GetCustomerbyID(int ID);
        bool DeleteCustomer(int id);
        bool updateCustomer(Customer recOrder);
        bool InsertCustomer(Customer recOrder);
        bool VerifyEmail(string prmEmail);
        bool VerifyUser(string prmUsername, string prmPwd);
        bool VerifyLoginUser(string prmUsername, string prmPwd);
    }
}
