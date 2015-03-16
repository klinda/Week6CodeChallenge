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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return PartialView();
        }
        [HttpPost]
        public ActionResult Contact(Contact c)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msg = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    MailAddress from = new MailAddress(c.Email.ToString());
                    StringBuilder sb = new StringBuilder();
                    msg.From = new MailAddress("the_robots@seedpaths.com");
                    msg.To.Add("hello.lindakha@gmail.com");
                    msg.Subject = "Contact message";
                    msg.IsBodyHtml = false;
                    smtp.Host = "mail.dustinkraft.com";
                    smtp.Port = 587;
                    sb.Append("First + Last: " + c.FirstName + c.LastName);
                    sb.Append(Environment.NewLine);
                    sb.Append("Email: " + c.Email);
                    sb.Append(Environment.NewLine);
                    sb.Append("Phone number: " + c.PhoneNumber);
                    sb.Append("Company Name: " + c.CompanyName);
                    sb.Append("Project Description: " + c.ProjectDescription);
                    sb.Append("Comments: " + c.Comment);
                    msg.Body=sb.ToString();
                    msg.Dispose();
                    return PartialView("ThankYou");
                }
                catch (Exception) {
                    return PartialView("Error");
                }
            }
            return PartialView("ThankYou");
        }

        public ActionResult ThankYou() 
        { 
        return PartialView(); 
        }

    }
}