using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Course_7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            return View("Index");
        }
        [ActionName("about")]
        public ActionResult SomeMethodName(){
            return View("SomeMethodName");
        }
        //[NonAction]
        public ActionResult Calc() {
            return Content("Calc");
        }
        [HttpGet]
        public ActionResult VerbsTest()
        {
            return Content("Hello");
        }
        [ActionName("authorize")]
        [Authorize(Roles = "Admin")]
        public ActionResult ThisMethodNeedsAuthorization() {
            return Content("Hello");
        }
    }
}