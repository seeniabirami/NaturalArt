using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NaturalArtData.Models
{
    public class Enquiry
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]
        [StringLength(50, ErrorMessage = "Name  Limits t0 50")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Contact No")]
        public int CusContactNo { get; set; }

        [StringLength(200, ErrorMessage = "Description limits exceeds")]
        public string Description { get; set; }
        [StringLength(200, ErrorMessage = "Status limits exceeds")]
        public int FeedStatus { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime createddate { get; set; }
        public int Statusid { get; set; }


        public virtual Status Statusrec {get;set;}
    }
}
