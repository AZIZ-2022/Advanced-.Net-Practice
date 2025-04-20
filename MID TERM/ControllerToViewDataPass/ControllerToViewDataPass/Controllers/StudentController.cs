using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllerToViewDataPass.Models;

namespace ControllerToViewDataPass.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowData()
        {
            Student s = new Student();
            s.id = 5;
            s.name = "Jahid";
            s.cgpa = 3.5;

            return View(s);

        }

       public ActionResult ViewDataExample()
        {
            ViewData["data"] = "Barcelona";

            string[] Fruits = { "Apple", "Mango", "Banana" };

            ViewData["Tasty"] = Fruits;


            return View();
        }



        public ActionResult ViewBagExample()
        {
            ViewBag.Team = "Argentina";

            string[] Fruits = { "Apple", "Mango", "Banana" };

            ViewBag.Tasty = Fruits;


            ViewBag.TeamsList = new List<string>()
            {
                "Barcelona" ,
                "Liverpool",
                "AC Milan"

            };


            Student S = new Student();


            S.name = "Aziz";
            S.id = 22470131;
            S.cgpa = 3.75;

            ViewBag.Student = S;



            return View();
        }





    }
}