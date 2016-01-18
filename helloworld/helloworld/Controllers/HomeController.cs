using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace helloworld.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/ 36
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GoToHome()
        {
            return this.View("MyHomePage");
        }
	}
}