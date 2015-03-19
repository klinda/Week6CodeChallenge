using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Week6CodeChallenge.Models;

namespace Week6CodeChallenge.Controllers
{
    public class ContactController : Controller
    {
        private sp6LindaEntities1 db = new sp6LindaEntities1();

        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return PartialView();
        }
        [HttpPost]
        public ActionResult Index(Models.ContactForm2 contactForm)
        {
            Models.sp6LindaEntities1 db = new Models.sp6LindaEntities1();
            db.ContactForm2.Add(contactForm);
            return View("ThankYou");
        }

    }
}