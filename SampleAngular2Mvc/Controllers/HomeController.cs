﻿using System.Web.Mvc;

namespace SampleAngular2Mvc.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View("NgApp");
        }
        [Route("trip")]
        [Route("location")]
        [Route("person")]
        public ActionResult AppBookmarkableRoutes()
        {
            return View("NgApp");
        }

        [Route("about")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}