using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RapidPrototypingMVC4Examples.Areas.AppDemo.Controllers
{
    public class AppController : Controller
    {
        //
        // GET: /AppDemo/App/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Session()
        {
            return View();
        }

    }
}
