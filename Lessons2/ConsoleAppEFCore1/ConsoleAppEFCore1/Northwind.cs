using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppEFCore1 
{
    class Northwind : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=gnome\sqlexpress;" +
                "Initial Catalog = Northwind;" +
                "Persist Security Info = True;" +
                "User ID = sa;" + 
                "Password = '12345';");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>()
                .Property(category => category.CategoryName)
                .IsRequired()
                .HasMaxLength(40);

            builder.Entity<Product>().HasQueryFilter(p => !p.Discontinued);
        }
    }
}
