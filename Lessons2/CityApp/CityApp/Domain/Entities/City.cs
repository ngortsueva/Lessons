using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityApp.Domain.Entities
{
    public class City
    {
        public int Id { get; set; }
        public int Country { get; set; }
        public string Name { get; set; }
    }
}