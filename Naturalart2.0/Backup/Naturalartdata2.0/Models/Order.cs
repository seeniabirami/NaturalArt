using NaturalArtData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NaturalArtData.Models
{
   public  class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }

        [Display(Name = "Total Item")]
        public int TotalItem { get; set; }
        [Display(Name = "Total Cost")]
        public float TotalCost { get; set; }

        [Display(Name = "Required Date")]
        public DateTime Requireddate { get; set; }
        [Display(Name = "Shipped Date")]
        public DateTime shippedDate { get; set; }
        
        [Display(Name = "Address1")]
        public string shipAdd1 { get; set; }
        [Display(Name = "Address2")]
        public string shipAdd2 { get; set; }
        [Display(Name = "State")]
        public string shipState { get; set; }
        [Display(Name = "City")]
        public string shipCity { get; set; }
       
       [StringLength(6,ErrorMessage ="Postal code Exceeds Max entry")]
       [Display (Name ="Postal Code")]
        public Int16 shippostcode { get; set; }
        public string shipcountry { get; set; }


      
        public int OrderStatusID { get; set; }
        public string OrderStatusName{ get; set; }
        public virtual Status  Status{ get; set; }
        public virtual Customer Customer { get; set; }

        public bool SameShippingAdd{ get; set; }
       
       
        public virtual Address ToAddress { get; set; }
        public virtual List<OrderDetails> Cartlist { get; set; }

}
}
