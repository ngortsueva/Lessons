using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryWeb.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Region> Regions { get; set; }
    }

    public class Region
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public Country Country { get; set; }
        public List<City> Cities { get; set; }
    }

    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public Region Region { get; set; }
    }
}
