using MVC_Course_8_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Course_8_1.Controllers
{
    public class EvaluationController : Controller
    {
        static List<ProjectEvaluation> evaluations = new List<ProjectEvaluation>
            {
                new ProjectEvaluation() { Id=1, Name = "Emma", City = "Brad", Country = "Romania", Rating = 10},
                new ProjectEvaluation() { Id=2, Name = "Maria", City = "Londra", Country = "Anglia", Rating = 9},
                new ProjectEvaluation() { Id=3, Name = "Alexandra", City = "Berlin", Country = "Germania", Rating = 8}
            };
        public ActionResult Index()
        {
            return View(evaluations);
        }

        public ActionResult Edit(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var evaluation = evaluations.Single(e => e.Id == id);
            if (TryUpdateModel(evaluation))
            {
                return RedirectToAction("Index");
            }
            return View(evaluation);
        }
    }
}