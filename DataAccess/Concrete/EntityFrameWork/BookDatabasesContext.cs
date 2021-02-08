using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    class BookDatabasesContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BookDatabases;Trusted_Connection=true");
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<TypeOfBook> TypeOfBooks { get; set; }
        public DbSet<PublishingHouse> PublishingHouses { get; set; }

        

    }
}
