using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryCalendarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Countrydb db = new Countrydb();

            //***
            Console.WriteLine("I. Continents");
            Console.WriteLine("Step 1. Continents: select all continents");

            foreach(var item in db.Continents)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }

            //***
            Console.WriteLine("Step 2. Continents: select continents with id>3");

            IEnumerable<Continent> continents = db.Continents
                .Where(c => c.Id > 3)
                .OrderBy(c => c.Name);

            foreach (var item in continents)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }

            //***
            Console.WriteLine("Step 3. Continents: select continent with id=2");

            Continent find_continent = db.Continents.FirstOrDefault(x => x.Id == 2);

            Console.WriteLine(find_continent.Id + " " + find_continent.Name);

            //--------------------------------------------------------------------------
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("II.Countries");
            Console.WriteLine("Step1. Countries: select all countries");
            foreach(var item in db.Countries)
            {
                Console.WriteLine(item.Id + " " + item.Code + " " + item.Name + " " + item.Continent);
            }

            Console.WriteLine("Step2. Countries: select countries with continent=2");
            IEnumerable<Country> countries = db.Countries
                .Where(c => c.Continent == 2)
                .OrderBy(c => c.Code);

            foreach(var item in countries)
            {
                Console.WriteLine(item.Id + " " + item.Code + " " + item.Name + " " + item.Continent);
            }

            Console.WriteLine("Step3. Countries: select country with Id=2");

            Country country = db.Countries.FirstOrDefault(x => x.Id == 2);

            Console.WriteLine(country.Id + " " + country.Code + " " + country.Name + " " + country.Continent);

            Console.ReadLine();
        }
    }
}
