using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCalendarConsole
{
    public class CountryRepository : ICountryRepository
    {
        private Countrydb db = new Countrydb();

        public IQueryable<Country> Countries { get { return db.Countries; } }

        public CountryRepository()
        {
        }

        public void SaveCountry(Country country)
        {
            if (country.Id == 0)
            {
                db.Countries.Add(country);
            }
            else
            {
                Country find_c = db.Countries.FirstOrDefault(c => c.Id == country.Id);
                find_c.Name = country.Name;
            }
            db.SaveChanges();
        }

        public void DeleteCountry(Country country)
        {
            db.Countries.Remove(country);
            db.SaveChanges();
        }
    }
}