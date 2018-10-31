using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext():base("AspNetDB")
        {
            Database.SetInitializer<LibraryContext>
                (new CreateDatabaseIfNotExists<LibraryContext>());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categoryes { get; set; }
        public DbSet<Sales> Sales { get; set; }
    }
}