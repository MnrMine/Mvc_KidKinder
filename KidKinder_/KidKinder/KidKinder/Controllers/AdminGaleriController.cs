using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    [Authorize]
    public class AdminGaleriController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.Galleries.ToList();
            return View(values);
        }
        public ActionResult Passive(int id)
        {
            var values = context.Galleries.Find(id);

            values.Status = 0;
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Active(int id)
        {
            var values = context.Galleries.Find(id);
            values.Status = 1;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateGaleri()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CreateGaleri(Gallery p)
        {
            context.Galleries.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult DeleteGaleri(int id)
        {
            var values = context.Galleries.Find(id);
            context.Galleries.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}