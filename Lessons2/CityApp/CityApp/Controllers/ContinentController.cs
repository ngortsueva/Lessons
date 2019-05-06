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
    public class ContinentController : Controller
    {
        private ContinentRepository repository;

        public ContinentController()
        {
            repository = new ContinentRepository();
        }

        public ContinentController(IContinentRepository repo)
        {
            repository = new ContinentRepository();
        }

        // GET: Continent
        public ViewResult List()
        {
            IEnumerable<Continent> continents = repository.Continents;

            return View(continents);
        }        
    }
}