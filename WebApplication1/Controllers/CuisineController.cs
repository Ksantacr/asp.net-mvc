using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cousine
        public ActionResult Index()
        {
            return View(restaurants);
        }

        // GET: Cousine
        public ActionResult Search(string name = "French")
        {
            return Content("Cousine: "+ name);
            //return View();
        }

        // GET: Cousine/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cousine/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cousine/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cousine/Edit/5
        public ActionResult Edit(int id)
        {
            var model = restaurants.Single(r => r.Id == id);
            return View(model);
        }

        // POST: Cousine/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var restaurant = restaurants.Single(r => r.Id == id);

            if (TryUpdateModel(restaurant))
            {
                TryUpdateModel(restaurant);
                return RedirectToAction("Index");
            }
            return View(restaurant);
        }

        // GET: Cousine/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cousine/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        static List<Restaurant> restaurants = new List<Restaurant> {
            new Restaurant{
                Id = 1,
                Name = "Cruz Azul",
                City = "Gye",
                Country = "Ecuador"
            },
            new Restaurant{
                Id = 2,
                Name = "Sport Planet",
                City = "UIO",
                Country = "Ecuador"
            },
            new Restaurant{
                Id = 3,
                Name = "Dorado",
                City = "CUENCA",
                Country = "Ecuador"
            }
        };
    }
}
