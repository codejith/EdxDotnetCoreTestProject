using System;
using Microsoft.AspNetCore.Mvc;
using TestApp.Models;

namespace TestApp.Controllers {
    public class FilmController: Controller {

        [HttpGet]
        public IActionResult CreateOrUpdate() 
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateOrUpdate(CreateOrUpdate dto) 
        {
            if (dto.Operation == Operations.Create)
            {
                // Create logic
                return View("Create");
            }
            else if (dto.Operation == Operations.Update) 
            {
                //Update the film by film id
                return View();
            }
            else
            {
                //delete logic
                return View();
            }

            return View();
        }
    }
}