using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CityApp.Domain.Abstract;
using CityApp.Domain.Concrete;
using CityApp.Domain.Entities;

namespace CityApp.Controllers
{
    public class CountryController : Controller
    {
        private CountryRepository repository;

        public CountryController()
        {
            repository = new CountryRepository();
        }

        public CountryController(ICountryRepository repo)
        {
            repository = new CountryRepository();
        }

        // GET: Country
        public ViewResult List(int continent)
        {
            ViewBag.WithHolidays = false;

            IEnumerable<Country> countries = repository.Countries
                .Where(c => c.Continent == continent);

            return View(countries);
        }
        
        public ViewResult Holidays(string countrycode)
        {
            Country c = repository.Countries
                .FirstOrDefault(x => x.Code == countrycode);

            if (c != null)
            {
                return View(c);
            }
            else return View();
        }

        public ViewResult Calendar(string calendarcode)
        {
            Country c = repository.Countries
                .FirstOrDefault(x => x.Code == calendarcode);

            if (c != null)
            {
                return View(c);
            }
            else return View();
        }
    }
}