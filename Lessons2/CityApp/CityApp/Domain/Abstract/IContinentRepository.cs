using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CityApp.Domain.Entities;

namespace CityApp.Domain.Abstract
{
    public interface IContinentRepository
    {
        IQueryable<Continent> Continents { get; }
        void SaveContinent(Continent continent);
        void DeleteContinent(Continent continent);        
    }
}