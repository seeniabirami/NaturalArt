using NaturalArtData;
using System;
using System.Collections.Generic;
using System.Text;
using NaturalArtData.Models;

using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace NaturalArtServices
{
    public class StatusService : IStatus

    {
        private NaturalArtdbContext _context;

        public StatusService(NaturalArtdbContext context)
        {
            _context = context;
        }
        public bool FindUniqueStatus(string type,string status)
        {
            if (GetAll().Where(x => x.StatusType == type && x.StatusName== status).Count() > 0)
               
            {
                return true;
            }
            return false;
        }
        public void AddStatus(Status newStatus)
        {
            try {
                _context.Add(newStatus);
                _context.SaveChanges();
            }
            catch (Exception ex) {

              ex.Message.ToString();
            }
            }


        public void DeleteStatus(int ID)
        {
            var recExist = _context.ArtItem.Where(x => x.statusid == ID).Count();
         //   var recExist1 = _context.ItemCatagory.Where(x => x.statusid == ID).Count();
            if (recExist > 0) {
                throw new ArgumentException("Category Already exist in relational tables");


            } else {
                var status = GetStatusbyID(ID);
                _context.Remove(status);
                _context.SaveChanges();
            }
           
        }
        public void UpdateStatusbyID(Status newStatus) {
            _context.Update(newStatus);
            _context.SaveChanges();
        }

        public void UpdateStatusbyIDandType(int ID, string Type) {
            throw new NotImplementedException();
        }

        public IEnumerable<Status> GetAll()
        {
            return _context.Status;
                      
        }

        public Status GetStatusbyID(int ID)
        {
            return GetAll()
               .FirstOrDefault(X => X.Statusid == ID);
        }

        public Status GetStatusbyIDandType(int ID, string Type)
        {
            return GetAll()
                .First(X => X.Statusid == ID);

        }

        public string GetStatusValue(int ID, string Type)
        {
            throw new NotImplementedException();

        }

        public List<String> GetStatusTypes()
            {

            return GetAll().Select(x => x.StatusType).Distinct().ToList();
               

        }

        public List<String> GetStatusNames(string type) {

            return GetAll()
                 .Where(p => p.StatusType == type).Select(x => x.StatusName ).Distinct().ToList() ;
          


        }
       

    }
}
