using System;
using System.Collections.Generic;
using System.Text;
using NaturalArtData.Models;

namespace NaturalArtData
{
    public  interface IEnquiry
    {
       IEnumerable<Enquiry>GetAll();
       
    void DeleteEnquiry(int id);
        Enquiry GetdetailByID(int id);
        void sendEmail(Enquiry mEnquiry);
    void InsertEquery(Enquiry nEnquiry);
        void SetStatusEnquiry(Enquiry nEnquiry);
    }
}
