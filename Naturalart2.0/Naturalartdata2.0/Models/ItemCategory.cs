using System.ComponentModel.DataAnnotations;

namespace NaturalArtData.Models
{
    public  class ItemCategory
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        public string CategoryType { get; set; }
        public string Description { get; set; }
    }
}
