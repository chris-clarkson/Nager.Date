﻿using Nager.Date.Contract;
using Nager.Date.Model;
using System;
using System.Collections.Generic;

namespace Nager.Date.PublicHolidays
{
    public class FranceProvider : IPublicHolidayProvider
    {
        public IEnumerable<PublicHoliday> Get(DateTime easterSunday, int year)
        {
            //France
            //https://en.wikipedia.org/wiki/Public_holidays_in_France

            var countryCode = CountryCode.FR;

            var items = new List<PublicHoliday>();
            items.Add(new PublicHoliday(year, 1, 1, "Jour de l'an", "New Year's Day", countryCode, 1967));
            items.Add(new PublicHoliday(easterSunday.AddDays(-2), "Vendredi saint", "Good Friday", countryCode, null, new string[] { "FR-A", "FR-54" }));
            items.Add(new PublicHoliday(easterSunday.AddDays(1), "Lundi de Pâques", "Easter Monday", countryCode, 1642));
            items.Add(new PublicHoliday(year, 5, 1, "Fête du premier mai", "Labor Day", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(39), "Jour de l'Ascension", "Ascension Day", countryCode));
            items.Add(new PublicHoliday(year, 5, 8, "Fête de la Victoire", "Victory in Europe Day", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(50), "Lundi de Pentecôte", "Whit Monday", countryCode));
            items.Add(new PublicHoliday(year, 7, 14, "Fête nationale", "Bastille Day", countryCode));
            items.Add(new PublicHoliday(year, 8, 15, "L'Assomption de Marie", "Assumption of Mary to Heaven", countryCode));
            items.Add(new PublicHoliday(year, 11, 1, "La Toussaint", "All Saints' Day", countryCode));
            items.Add(new PublicHoliday(year, 11, 11, "Armistice de 1918", "Armistice Day", countryCode));
            items.Add(new PublicHoliday(year, 12, 25, "Noël", "Christmas Day", countryCode));
            items.Add(new PublicHoliday(year, 12, 26, "Saint-Étienne", "St. Stephen's Day", countryCode));

            return items;
        }
    }
}
