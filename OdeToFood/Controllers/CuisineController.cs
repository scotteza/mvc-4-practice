using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Filters;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        //[Authorize]
        [Log]
        public ActionResult Search(string name = "Default Value")
        {
            var message = Server.HtmlEncode(name);

            // throw new Exception("Oh no!!");

            //return File(Server.MapPath(@"~/Content/site.css"), @"text/css");

            //return Json(new { Message = message, Name = "Mr Smith" }, JsonRequestBehavior.AllowGet);

            return Content(message);
        }

    }
}
