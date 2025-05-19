using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlayerManagement.Context;

namespace PlayerManagement.Controllers
{
    public class PlayerController : Controller
    {


        PlayerEntities db = new PlayerEntities();
        // GET: Player
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(table_Registration collect)
        {
            if (ModelState.IsValid)
            {
                table_Registration r = new table_Registration();


                r.name = collect.name;
                r.password = collect.password;
                r.email = collect.email;
                r.address = collect.address;

                db.table_Registration.Add(r);
                db.SaveChanges();
                return RedirectToAction("Login");
            }

           
            return View("Registration");
           


            
        }




        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(table_Registration loginData)
        {
            var user = db.table_Registration.FirstOrDefault(x => x.email == loginData.email && x.password == loginData.password);

            if (user != null)
            {
                // You can use Session here for storing login info
                Session["UserName"] = user.name;
                Session["UserEmail"] = user.email;

                // Redirect to a success or dashboard page
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.Message = "Invalid email or password.";
                return View("Login");
            }
        }

    






    }
}
