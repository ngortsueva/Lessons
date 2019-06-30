﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CountryWeb.Models;

namespace CountryWeb.Domain
{
    public class CountryDb : DbContext
    {
        public CountryDb(DbContextOptions<CountryDb> options) : base(options) { }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<City> Cities { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
