using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NaturalArtData.Models
{
   public class OrderDetails
    {
    [Key]
        public int OrderDetailID { get; set; }
        [ForeignKey("OrdID")]
        public int OrderID { get; set; }
        public int ItemRunNo { get; set; }
        
        public int ItemID { get; set; }
        public float Unitprize { get; set; }
        public int Quantity { get; set; }

        public virtual ArtItem Item { get; set; }
    }
}
