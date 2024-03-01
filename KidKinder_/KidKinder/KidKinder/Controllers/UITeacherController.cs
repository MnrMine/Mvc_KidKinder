using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    public class UITeacherController : Controller
    {
        KidKinderContext context = new KidKinderContext();

        public ActionResult UITeacherIndex()
        {
            return View();
        }

        public PartialViewResult UITeacherHeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult PartialTeacher()
        {
            var values = context.Teachers.ToList();
            return PartialView(values);
        }
    }
}