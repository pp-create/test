using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace test.Models
{
   public class applictioncontext : DbContext
   {
        public applictioncontext(DbContextOptions<applictioncontext> options)
       : base(options)
        {
        }

        public DbSet<Item> Item { get; set; }
           public DbSet<mainitem> mainitem { get; set; }
           public DbSet<Users> Users { get; set; }
         

           //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           //{
           //    optionsBuilder.UseSqlServer("Server=.;Database=MyAppDb;Trusted_Connection=True;");
           //}
     
   }
}
