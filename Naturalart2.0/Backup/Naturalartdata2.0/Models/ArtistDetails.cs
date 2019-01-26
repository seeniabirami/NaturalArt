
using NaturalArtData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NaturalArtData.Models
{
   public class ArtistDetails
    {
        [Key]
        public int ArtistID { get; set; }
       
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required]
        [Display(Name =" Contact No")]
        public int ContactNo { get; set; }
        [Required]
        [Display(Name = " Email-Id")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }
        [Required]
        public string Area { get; set; }

        [DefaultValue(true)]
        public   Boolean Whatsapp { get; set; }

        [Display(Name = "WhatsApp No")]
        public int WhatsappNo { get; set; }

        [Display(Name = "UserroleID")]

        public int UserroleID { get; set; }

      

        [ForeignKey("Addid")]
        public int Addid { get; set; }

        public virtual Address Address { get; set; }

        public virtual UserRole UserRole { get; set; }
   

}
}
