
using NaturalArtData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NaturalArtData.Models
{
    public class ArtItem
    {
        [Key]
       [Required]
        public int ItemID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Title")]
        public string ItemTitle { get; set; }
     
        [Required]
        [ForeignKey("CategoryID")]
       
        public int CategoryID { get; set; }
            

        [Required]
        [StringLength(200)]
        [Display(Name = "Description")]
        public string ItemDescription { get; set; }

        [Required]
       
        public int Width { get; set; }

        [Required]
        public int Length { get; set; }

        [Required]
        [StringLength(5)]
        public string Measure { get; set; }

        [Required]
        public int Prize { get; set; }

        
        [StringLength(20)]
        [Display(Name = "Status Available")]
        public string availability { get; set; }
        
        [StringLength(4)]
        [Display(Name = "Year Made")]
        public int YearMade { get; set; }
             
        public  string imageurl { get; set; }

      
        public DateTime postedDate { get; set; }

        [ForeignKey("StatusID")]
        public int statusid { get; set; }

        [ForeignKey("ArtistID")]
        public int ArtistID { get; set; }

        public virtual ArtistDetails ArtistDetail { get; set; }
        public virtual ItemCategory Itemcategories { get; set; }
        public virtual List<ItemCategory> ItemcategoriesList { get; set; }
        public virtual Status Statusrec { get; set; }
        public virtual List<Status> StatusList { get; set; }

    }
}