using NaturalArtData;
using System;
using System.Collections.Generic;
using System.Text;
using NaturalArtData.Models;

using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace NaturalArtServices
{
    public class UserRoleService : IUserRole
    {
        private NaturalArtdbContext _context;
        public UserRoleService(NaturalArtdbContext context)
        {
            _context = context;
        }
        public bool DeleteRole(int ID)
        {
           
               // var recArtistExist = _context.Artist.Where(x => x.UserroleID == ID).Count();

                //if (recArtistExist > 0)
                //{
                //    throw new ArgumentException("Role has been assign to a user ,hence cannot remove this role.");

                //    return false;
                //}
                //else
                //{
                    var userroles = GetAllbyID(ID);
                    _context.Remove(userroles);
                    _context.SaveChanges();
                    return true;
              //  }

           
        }
        public bool FindUniqueRole(string role)
        {
            if (GetAll().Where(x => x.UserRoleName == role).Count() > 0)

            {
                return true;
            }
            return false;
        }
        public IEnumerable<UserRole> GetAll()
        {
            return _context.UserRole;
        }
        public UserRole GetAllbyID(int ID)
        {
            return GetAll().FirstOrDefault(x => x.RoleID == ID);
        }
        public int GetIDbyRole(string role)
        {
            return  Convert.ToInt32( GetAll().Where(x => x.UserRoleName == role).Select(y => y.RoleID).FirstOrDefault());
        }
        public bool InsertRole(UserRole prmURole)
        {
                _context.Add(prmURole);
                _context.SaveChanges();
                return true;
        }
        public bool UpdateRole(UserRole prmURole)
        {
                _context.Update(prmURole);
                _context.SaveChanges();
                return true;
        }
    }
}
