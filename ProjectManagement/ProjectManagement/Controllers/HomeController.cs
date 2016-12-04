using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            var model = new AboutModel();
            model.Message = "Hello";
            model.Author = "Emma";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public double CalculateAverage() {
            int sum = 0;
            var list = new List<int> {1,2,3};
            //return list.Average();
            foreach (int x in list){
                sum += x;
            }
            return sum / list.Count();
        }
        public ActionResult HelloWorld()
        {
            return Content("Hello World");
        }
    }
}