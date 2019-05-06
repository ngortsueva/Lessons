using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CountryCalendarConsole
{
    public class CityRepository : ICityRepository
    {
        private Countrydb db = new Countrydb();

        public IQueryable<City> Cities {
            get { return db.Cities; }
        }

        public void SaveCity(City city)
        {
            if (city.Id == 0)
            {
                db.Cities.Add(city);
            }
            else
            {
                City find_c = db.Cities.FirstOrDefault(c => c.Id == city.Id);
                find_c.Name = city.Name;
            }
            db.SaveChanges();
        }

        public void DeleteCity(City City)
        {
            db.Cities.Remove(City);
            db.SaveChanges();
        }
    }
}