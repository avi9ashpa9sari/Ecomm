using Ecomm.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace Ecomm.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        //public DbSet<Category> categories { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookCover> BookCovers { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }


        //public class AppDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
        //{
        //    public ApplicationDbContext CreateDbContext(string[] args)
        //    {
        //        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        //        optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Database = EcommAPI; Trusted_Connection = true");

        //        return new ApplicationDbContext(optionsBuilder.Options);
        //    }
        //}

        //protected override void OnConfiguring(DbContextOptions options)
        //{
        //    options.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=app_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //base.OnConfiguring(optionsBuilder);
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        //optionsBuilder.UseSqlServer(@"server=(LocalDB)\\MSSQLLocalDB;Database= EcommAPI;Trusted_Connection=True;");
        //    }
        //}
    }
}
