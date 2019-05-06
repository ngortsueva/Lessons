using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CityApp.Domain.Entities;

namespace CityApp.Domain.Abstract
{
    public interface ICountryRepository
    {
        IQueryable<Country> Countries { get; }
        void SaveCountry(Country country);
        void DeleteCountry(Country country);
    }
}