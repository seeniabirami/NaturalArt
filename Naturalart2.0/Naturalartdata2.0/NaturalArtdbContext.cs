using Microsoft.EntityFrameworkCore;
using System;
using NaturalArtData.Models;
using NaturalArtData;

namespace NaturalArtData {
    public class NaturalArtdbContext : DbContext

    {
        public NaturalArtdbContext()
        {          // << The reason....

        }
        public NaturalArtdbContext(DbContextOptions<NaturalArtdbContext> options):base(options){      }

        public DbSet<Address> Address { get; set; }
        public DbSet<ArtItem> ArtItem { get; set; }
        public DbSet<ArtistDetails> Artist { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Enquiry> Enquiry { get; set; }
        public DbSet<ItemCategory> ItemCatagory { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetails> Orderdetail { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        
       
    


    }
}
