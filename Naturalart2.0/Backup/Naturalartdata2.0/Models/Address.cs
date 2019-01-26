using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

using NaturalArtData.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace NaturalArtData.Models
{
    public class Address
    {
        [Key]
        public int Addid { get; set; }
        public string  Addtype { get; set; }
        public int UserID { get; set; }
        public string UserType { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public Int32 postcode { get; set; }
        public string country { get; set; }
       
       
     
    }
}

