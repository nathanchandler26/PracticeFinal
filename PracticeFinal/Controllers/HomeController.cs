using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticeFinal.Models;

namespace PracticeFinal.Controllers
{
    public class HomeController : Controller
    {
        private RestaurantsContext _repo { get; set; }
        public HomeController(RestaurantsContext temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AddRestaurant()
        {
            //var ResInfo = _repo.
            return View();
        }

        [HttpPost]
        public IActionResult AddRestaurant(RestaurantInfo ri)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(ri);
                _repo.SaveChanges();
                return View("Confirmation", ri);
            }
            else
            {
                return View();
            }
        }



        [HttpGet]
        public IActionResult RestaurantList()
        {
            var restaurants = _repo.Info.ToList();

            return View(restaurants);
        }

        [HttpGet]
        public IActionResult Edit(int restaurantid)
        {
            var restaurant = _repo.Info.Single(x => x.RestaurantId == restaurantid);

            //return View("AddRestaurant", restaurant);
            return View("AddRestaurant", restaurant);
        }

        [HttpPost]
        public IActionResult Edit(RestaurantInfo x)
        {
            _repo.Update(x);
            _repo.SaveChanges();

            return RedirectToAction("RestaurantList");
        }

        [HttpGet]
        public IActionResult Delete(int restaurantid)
        {
            var restaurant = _repo.Info.Single(x => x.RestaurantId == restaurantid);
            return View(restaurant);
        }

        [HttpPost]
        public IActionResult Delete(RestaurantInfo ri)
        {
            _repo.Info.Remove(ri);
            _repo.SaveChanges();
            return RedirectToAction("RestaurantList");
        }


    }
}
