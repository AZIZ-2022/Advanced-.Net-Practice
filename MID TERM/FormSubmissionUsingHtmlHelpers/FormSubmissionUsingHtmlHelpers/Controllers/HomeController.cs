using FormSubmissionUsingHtmlHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormSubmissionUsingHtmlHelpers.Models;

namespace FormSubmissionUsingHtmlHelpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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

        public ActionResult HtmlHelper()       //Controller To View Data Sending
        {
            Home H = new Home();
            {
                H.name = "Tawsif";
                H.id = "22-47013-1";
                H.cgpa = 3.50;
                H.Address = "Khilgaon";
            }
            ;
            return View(H);
        }



        //Form Submitting (From View To Controller data Pass)
        [HttpPost]
        public ActionResult HtmlHelper(Home H)       //Controller To View Data Sending
        {
            return View();
        }





        public ActionResult SecondPage(string name)
        {
            return View();
        }
    }
}