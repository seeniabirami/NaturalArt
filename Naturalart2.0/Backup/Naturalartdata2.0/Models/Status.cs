using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace NaturalArtData.Models
{
  public  class Status
    {
        [Key]
         public int Statusid { get; set; }
        [Required]
        public string StatusType { get; set; }
        [Required]
        public string StatusName { get; set; }

        public string Description { get; set; }
    }
}
