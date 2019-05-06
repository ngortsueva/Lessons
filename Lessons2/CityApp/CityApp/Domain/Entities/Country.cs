using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityApp.Domain.Entities
{
    public class Country 
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public int Continent { get; set; }

        public string Holidays { get; set; }
    }
}