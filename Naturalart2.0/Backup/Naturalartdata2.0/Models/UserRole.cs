using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using NaturalArtData.Models;
namespace NaturalArtData.Models
{
    public class UserRole
    {
    [Key]
    public int RoleID { get; set; }
    [Required]
    public string UserRoleName { get; set; }
    
    public string Description { get; set; }

       
    }
}
