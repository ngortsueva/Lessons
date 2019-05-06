using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CityApp.Domain.Abstract;
using CityApp.Domain.Entities;

namespace CityApp.Domain.Concrete
{
    public class ContinentRepository : IContinentRepository
    {
        private Countrydb db = new Countrydb();

        public IQueryable<Continent> Continents {
            get {
                return db.Continents;
            }
        }

        public ContinentRepository()
        {           
        }
                
        public void SaveContinent(Continent continent)
        {
            if (continent.Id == 0)
            {
                db.Continents.Add(continent);
            }
            else
            {
                Continent find_c = db.Continents.FirstOrDefault(c => c.Id == continent.Id);
                find_c.Name = continent.Name;
            }
            db.SaveChanges();
        }

        public void DeleteContinent(Continent continent)
        {
            db.Continents.Remove(continent);
            db.SaveChanges();
        }
    }
}