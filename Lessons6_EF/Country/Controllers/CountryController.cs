using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CountryWeb.Domain;
using CountryWeb.Models;

namespace CountryWeb.Controllers
{
    public class CountryController : Controller
    {
        private CountryDb db;

        public CountryController(CountryDb countryDb) { db = countryDb; }

        public IActionResult Index()
        {
            return View(db.Countries);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country country)
        {
            if (ModelState.IsValid)
            {
                db.Countries.Add(country);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }

        public IActionResult Edit(string id)
        {
            var country = db.Countries.FirstOrDefault(c => c.Id == Convert.ToInt32(id));

            return View(country);
        }

        [HttpPost]
        public IActionResult Edit(Country country)
        {
            if (ModelState.IsValid)
            {
                db.Countries.Update(country);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }

        public IActionResult Delete(string id)
        {
            var country = db.Countries.FirstOrDefault(c => c.Id == Convert.ToInt32(id));

            if (country != null)
            {
                db.Countries.Remove(country);
                db.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}