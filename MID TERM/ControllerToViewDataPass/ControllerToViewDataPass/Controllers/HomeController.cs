using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllerToViewDataPass.Models;

namespace ControllerToViewDataPass.Controllers
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

        public ActionResult Info(int id)
        {
            return Content("ID is " + id);

        }

        public ActionResult Data(int id,string name)
        {
            return Content("ID is " + id+ " Name is " + name);

        }



    }
}