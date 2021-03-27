using CitiesAPI.DataAccess;
using CitiesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesAPI.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RestarauntDBContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Countries.Any())
            {
                var Countries = new Country[]
                {
                    new Country{Name = "England", CallCode = "+44", Currency = "Pounds"},
                    new Country{Name = "United States", CallCode = "+1", Currency = "Dollars"},
                    new Country{Name = "Germany", CallCode = "+49", Currency = "Euro"},
                    new Country{Name = "France", CallCode = "+33", Currency = "Euro"}
                };
                context.Countries.AddRange(Countries);
                context.SaveChanges();
            }

            if (!context.Cities.Any())
            {
                var CountEN = context.Countries.FirstOrDefault(x => x.Name == "England");
                var CountUS = context.Countries.FirstOrDefault(x => x.Name == "United States");
                var CountDE = context.Countries.FirstOrDefault(x => x.Name == "Germany");
                var CountFR = context.Countries.FirstOrDefault(x => x.Name == "France");

                var Cities = new City[]
                {
                    new City{CountryID = CountEN.ID, Name = "London", Longitude = 51.5074, Latitude = 0.127},
                    new City{CountryID = CountUS.ID, Name = "New York", Longitude = 40.7128, Latitude = 74.0060 },
                    new City{CountryID = CountDE.ID, Name = "Berlin", Longitude = 52.5200, Latitude = 13.4050},
                    new City{CountryID = CountFR.ID, Name = "Paris", Longitude = 48.8566, Latitude = 2.3522}
                };
                context.Cities.AddRange(Cities);
                context.SaveChanges();
            }

            if (!context.Restaurants.Any())
            {
                var CityLN = context.Cities.FirstOrDefault(x => x.Name == "London");
                var CityNY = context.Cities.FirstOrDefault(x => x.Name == "New York");
                var CityBL = context.Cities.FirstOrDefault(x => x.Name == "Berlin");
                var CityPR = context.Cities.FirstOrDefault(x => x.Name == "Paris");

                var Restaraunts = new Restaraunt[]
                {
                    new Restaraunt{CityID = CityLN.ID, Name = "Bleecker Burger Victoria", Address = "205 Victoria St, Westminster, London SW1E 5NE", Type = Helper.RestarauntType.Burger},
                    new Restaraunt{CityID = CityNY.ID, Name = "The Modern", Address = "9 W 53rd St, New York, NY 10019, United States", Type = Helper.RestarauntType.FineDining},
                    new Restaraunt{CityID = CityBL.ID, Name = "Asia Mami Berlin Marzahn", Address = "Allee der Kosmonauten 151, 12685 Berlin, Germany", Type = Helper.RestarauntType.Indian},
                    new Restaraunt{CityID = CityPR.ID, Name = "Tour Maine Montparnasse", Address = "56ème, Avenue du Maine, 75015 Paris, France", Type = Helper.RestarauntType.FineDining},
                };
                context.Restaurants.AddRange(Restaraunts);
                context.SaveChanges();
            }
        }
    }
}
