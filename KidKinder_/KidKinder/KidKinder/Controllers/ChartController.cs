using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    [Authorize]
    public class ChartController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult ChartIndex()
        {
            ViewBag.a = context.Testimonials.Count();
            ViewBag.b = context.Teachers.Count();
            ViewBag.c = context.Students.Count();
            ViewBag.d = context.MailSubscribes.Count();
            ViewBag.e = context.Parents.Count();
            return View();
        }
    }
}