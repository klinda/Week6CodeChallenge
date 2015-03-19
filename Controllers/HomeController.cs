using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Web.Mvc;
using Week6CodeChallenge.Models;
using System.Text;

namespace Week6CodeChallenge.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
                return PartialView();

            return View();
        }
        public ActionResult Who()
        {
            return PartialView();
        }
        public ActionResult What()
        {

            return PartialView();
        }
        public ActionResult Where()
        {

            return PartialView();
        }
        public ActionResult How()
        {

            return PartialView();
        }
        public ActionResult Why()
        {

            return PartialView();
        }
        public ActionResult About()
        {
            return PartialView();
        }
        public ActionResult Work()
        {
            return PartialView();
        }
        public ActionResult Careers()
        {
            return PartialView();
        }
   
    }
}



