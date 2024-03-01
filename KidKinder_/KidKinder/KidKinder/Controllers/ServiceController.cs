using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        KidKinderContext context = new KidKinderContext();

        public ActionResult ServiceList()
        {
            var values = context.Services.ToList();
            return View(values);
        }
    }
}