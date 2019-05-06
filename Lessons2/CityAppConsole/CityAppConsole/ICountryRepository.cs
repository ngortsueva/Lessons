using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCalendarConsole
{
    public interface ICountryRepository
    {
        IQueryable<Country> Countries { get; }
        void SaveCountry(Country country);
        void DeleteCountry(Country country);
    }
}