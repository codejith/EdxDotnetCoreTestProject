using System;
using Microsoft.AspNetCore.Mvc;
using TestApp.Models;

namespace TestApp.Controllers {
    public class FilmController: Controller {

        [HttpGet]
        public IActionResult CreateFilm()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UpdateFilm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFilm(Movie dto)
        {
            if (this.ModelState.IsValid)
            {
                return RedirectToAction("UpdateFilm");
                //return View("Create");
            }
            else
            {
                return View("Error");
            }
            
        }

        [HttpPost]
        public IActionResult UpdateFilm(Movie dto)
        {
            if (this.ModelState.IsValid)
            {
                return View("Update");
            }
            else
            {
                return View("Error");
            } 
        }
    }
}