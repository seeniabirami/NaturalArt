using System;
using System.Collections.Generic;
using System.Text;
using Naturalartdata;
using NaturalArtData.Models;
using NaturalArtData;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace NaturalArtServices
{
    public class EnquiryService : IEnquiry
    {

        private NaturalArtdbContext _context;
        public  EnquiryService(NaturalArtdbContext context)
        {
            _context = context;

        }
        public void DeleteEnquiry(int id)
        {
            var Enquiry = GetdetailByID(id);
            _context.Remove(Enquiry);
            _context.SaveChanges();
        }

        public IEnumerable<Enquiry> GetAll()
        {
            return _context.Enquiry.Include(x => x.Statusrec);             ;
                
        }

        

        public Enquiry GetdetailByID(int id)
        {
            return GetAll().FirstOrDefault(x => x.ID == id);
        }

        public void InsertEquery(Enquiry recOrder)
        {

            _context.Add(recOrder);
            _context.SaveChanges();
        }

        public void sendEmail(Enquiry mEnquiry)
        {
            throw new NotImplementedException();
        }

        public void sendEmailorReply(Enquiry recOrder)
        {
            _context.Add(recOrder);
            _context.SaveChanges();
        }

        public void SetStatusEnquiry(Enquiry nEnquiry)
        {
            _context.Update(nEnquiry);
            _context.SaveChanges();
        }
    }
}
