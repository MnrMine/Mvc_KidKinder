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
    public class GalleryController : Controller
    {
       KidKinderContext context = new KidKinderContext();
        public ActionResult GalleryIndex()
        {
            return View();
        }

        public PartialViewResult GalleryHeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult PartialGallery()
        {
            var values = context.Galleries.ToList();
            return PartialView(values);
        }
    }
}