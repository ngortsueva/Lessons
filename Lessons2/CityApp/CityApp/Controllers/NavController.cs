using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CityApp.Domain.Abstract;
using CityApp.Domain.Entities;
using CityApp.Domain.Concrete;

namespace CityApp.Controllers
{
    public class NavController : Controller
    {
        private IContinentRepository repository;

        public NavController()
        {
            repository = new ContinentRepository();
        }

        // GET: Nav
        public PartialViewResult Menu(string continent = null)
        {
            ViewBag.SelectedContinent = continent;
            IEnumerable<Continent> continents = repository.Continents
                .OrderBy(x => x.Id);

            return PartialView(continents);
        }
    }
}