using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorldsSmallestBookstore.Client.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Spa()
        {
            return View();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "World's Smallest Bookstore Home Page.  Look at our latest Books";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BooksellerLogin()
        {
            ViewBag.Message = "Your Bookseller Login Page.";

            return View();
        }
     
       
    }
}
