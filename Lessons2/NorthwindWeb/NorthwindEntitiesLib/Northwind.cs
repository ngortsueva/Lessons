﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace NorthwindEntitiesLib
{
    public class Northwind : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public Northwind(DbContextOptions options)
        : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=gnome\sqlexpress;" +
                "Initial Catalog = Northwind;" +
                "Persist Security Info = True;" +
                "User ID = sa;" + 
                "Password = '12345';");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>()
            .Property(c => c.CategoryName)
            .IsRequired()
            .HasMaxLength(15);

            // определить отношение "один-ко-многим"
            modelBuilder.Entity<Category>()
            .HasMany(c => c.Products)
            .WithOne(p => p.Category);

            modelBuilder.Entity<Customer>()
            .Property(c => c.CustomerID)
            .IsRequired()
            .HasMaxLength(5);

            modelBuilder.Entity<Customer>()
            .Property(c => c.CompanyName)
            .IsRequired()
            .HasMaxLength(40);

            modelBuilder.Entity<Customer>()
            .Property(c => c.ContactName)
            .HasMaxLength(30);

            modelBuilder.Entity<Customer>()
            .Property(c => c.Country)
            .HasMaxLength(15);

            modelBuilder.Entity<Employee>()
            .Property(c => c.LastName)
            .IsRequired()
            .HasMaxLength(20);

            modelBuilder.Entity<Employee>()
            .Property(c => c.FirstName)
            .IsRequired()
            .HasMaxLength(10);

            modelBuilder.Entity<Employee>()
            .Property(c => c.Country)
            .HasMaxLength(15);

            modelBuilder.Entity<Product>()
            .Property(c => c.ProductName)
            .IsRequired()
            .HasMaxLength(40);

            modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products);

            modelBuilder.Entity<Product>()
            .HasOne(p => p.Supplier)
            .WithMany(s => s.Products);

            modelBuilder.Entity<OrderDetail>()
            .ToTable("Order Details");

            // определить первый ключ в нескольких столбцах
            // для таблицы Order Details
            modelBuilder.Entity<OrderDetail>()
            .HasKey(od => new { od.OrderID, od.ProductID });

            modelBuilder.Entity<Supplier>()
            .Property(c => c.CompanyName)
            .IsRequired()
            .HasMaxLength(40);

            modelBuilder.Entity<Supplier>()
            .HasMany(s => s.Products)
            .WithOne(p => p.Supplier);
        }
    }
}
