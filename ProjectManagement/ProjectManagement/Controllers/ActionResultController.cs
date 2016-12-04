using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class ActionResultController : Controller
    {
        public ActionResult Index() {
            return Content("This message is sent from Index action!");
        }
        public ActionResult RedirectPermanent() { 
            return Redirect("http://www.google.com");
        }
        public ActionResult RedirectToActionInTheSameController() {
            return RedirectToAction("Index");
        }
        public ActionResult RedirectToActionInHomeController() {
            return RedirectToAction("Index", "Home");
        }
        public ActionResult RedirectToRoute() {
            return RedirectToRoute("Default", new { controller = "Home", action = "About" });
        }
        public ActionResult ReturnFile() {
            return File("~/Content/Site.css", "text/css");
        }
    }
}