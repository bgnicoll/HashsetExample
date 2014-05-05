using HashsetExample.Helpers;
using HashsetExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HashsetExample.Controllers
{
    public class HomeController : Controller
    {
        private HashsetHelper _helper;
        public HomeController()
        {
            _helper = new HashsetHelper();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.foods = _helper.InitializeHashset().ToList();
            return View(model);
        }

        [HttpPost]
        public JsonResult AddFood(string food)
        {
            var existingFoods = _helper.InitializeHashset();
            if (existingFoods.Add(food))
            {
                return Json(new { success = true, message = "This is a new food." }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { success = false, message = "You've already eaten this food." }, JsonRequestBehavior.AllowGet);
        }
    }
}