using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using NaturalArtData.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace NaturalArtData.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        public string Customername { get; set; }
        [Required]
        [Display(Name = " Contact No")]
        public int ContactNo { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DefaultValue(true)]
        public Boolean Whatsapp { get; set; }

        [Display(Name = "WhatsApp No")]
        public int WhatsappNo { get; set; }
        [Required]
        [Display(Name = "BirthDate")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [ForeignKey("Addid")]
        public int AddressID { get; set; }
        public virtual Address FromAddress { get; set; }
        public virtual IEnumerable< Order> Orderslist { get; set; }
    }
}

