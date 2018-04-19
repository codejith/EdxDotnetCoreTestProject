using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using TestApp.Models;

namespace TestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var ob = new Program();
          // ob.getFilmAndActors();
        //    ob.updateCityRecord();
            BuildWebHost(args).Run();
        }

        private void getFilmAndActors() {
            using (var dbContext = new sakilaContext())
            {
             var records = dbContext.Film.Include(x => x.FilmActor).ThenInclude(y => y.Actor).ToList();
             foreach(var record in records){
                 Console.WriteLine($"Film : {record.Title}");
                 foreach(var actor in record.FilmActor){
                     Console.WriteLine($"Actor: {actor.Actor.FirstName} {actor.Actor.LastName}");
                 }
             }   
            }  
        }

        private void addCity() {
            using(var dbContext = new sakilaContext())
            {
                var city = new City() { CityId=1001, Name="Alappuzha", CountryId=103 };
                dbContext.Add(city);
                dbContext.SaveChanges();
            }
        }

        private void updateCityRecord(){
            using(var dbContext = new sakilaContext())
            {
                var city = dbContext.City.SingleOrDefault(x => x.CityId == 1001);
                if(city!=null){
                    city.Name = "Alleppy";
                    dbContext.Update(city);
                    dbContext.SaveChanges();
                }
            }
        }

        private void deleteCity(){ 
            using(var dbContext = new sakilaContext())
            {
                var city = dbContext.City.SingleOrDefault(x => x.CityId == 1001);
                if (city != null) 
                {
                    dbContext.Remove(city);
                    dbContext.SaveChanges();
                }
            }
         }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
