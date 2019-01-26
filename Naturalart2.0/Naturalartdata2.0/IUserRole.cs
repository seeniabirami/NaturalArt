using NaturalArtData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaturalArtData
{
   public  interface IUserRole
    {
    IEnumerable<UserRole> GetAll();
          UserRole GetAllbyID(int ID);
        bool FindUniqueRole(string role);
        int GetIDbyRole(string role);
        bool DeleteRole(int id);
    bool UpdateRole(UserRole prmURole);
    bool InsertRole(UserRole prmURole);
}
}
