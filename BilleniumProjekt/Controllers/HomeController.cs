using BilleniumProjekt.DAL;
using BilleniumProjekt.Models;
using BilleniumProjekt.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilleniumProjekt.Controllers
{
    public class HomeController : Controller
    {
        private FormDataContext db = new FormDataContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Finish()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(FormViewModel model)
        {
            ContactData data = new ContactData
            {
                ContactDataId = model.ContactDataId,
                Name = model.Name,
                Surname = model.Surname,
                Comment = model.Comment
            };
            if (ModelState.IsValid)
            {
                db.ContactData.Add(data);
                db.SaveChanges();
                return RedirectToAction("Finish","Home");
            }
            return View(model);

        }
    }
}