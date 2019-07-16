using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using CruDelicious.Models;

namespace CruDelicious.Controllers
{
    public class HomeController : Controller
    {
        private HomeContext dbContext;
        public HomeController(HomeContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dishes> AllUsers = dbContext.Dishes.ToList();
            List<Dishes> MostRecent = dbContext.Dishes
                .OrderByDescending(u => u.CreatedAt)
                .ToList();
            return View("Index", AllUsers);
        }

        [HttpGet("new")]
        public IActionResult NewDish()
        {
            return View("New");
        }

        [HttpPost("create")]
        public IActionResult CreateUser(Dishes NewDish)
        {

            if(ModelState.IsValid)
            {
                dbContext.Add(NewDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("New");
            }
        }

        [HttpGet("/info/{dishId}")]
        public IActionResult Info(int dishId)
        {
            
            Dishes ClickedDish = dbContext.Dishes.FirstOrDefault( d => d.DishId == dishId);

            
            System.Console.WriteLine();
            return View("Info",ClickedDish);
            
        }

        [HttpGet("edit/{dishId}")]
        public IActionResult Edit(int dishId)
        {
            Dishes ClickedDish = dbContext.Dishes.FirstOrDefault( d => d.DishId == dishId);
            return View("Edit", ClickedDish);
        }

        [HttpPost("edit/process/{dishId}")]
        public IActionResult EditProcess(int dishId, Dishes NewDish)
        {
            if(ModelState.IsValid)
            {
                Dishes updateDish = dbContext.Dishes.FirstOrDefault(dish=> dish.DishId == dishId );
                updateDish.Chef = NewDish.Chef;
                updateDish.NameDish = NewDish.NameDish;
                updateDish.Calories = NewDish.Calories;
                updateDish.Tastiness = NewDish.Tastiness;
                updateDish.Description = NewDish.Description;
                dbContext.SaveChanges();
                return RedirectToAction("Index", updateDish);
            }
            else
            {
                return View("New");
            }
        }
    }
}
