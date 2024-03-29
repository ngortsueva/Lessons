﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CountryCalendarConsole
{
    public interface IContinentRepository
    {
        IQueryable<Continent> Continents { get; }
        void SaveContinent(Continent continent);
        void DeleteContinent(Continent continent);        
    }
}