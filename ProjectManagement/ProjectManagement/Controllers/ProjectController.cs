using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class ProjectController : Controller
    {
        public ActionResult DoAnAction() {
            return Content("Hello World!");
        }
        public ActionResult HelloUser(string alpha)
        {
            string receivedParameter = Server.HtmlEncode(alpha);
            return Content("Hello, " + receivedParameter);
        }
    }
}