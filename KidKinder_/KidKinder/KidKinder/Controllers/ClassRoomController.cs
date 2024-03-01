using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    [Authorize]
    public class ClassRoomController : Controller
    {
        // GET: ClassRoom
        public ActionResult ClassRoomIndex()
        {
            return View();
        }

        public PartialViewResult ClassRoomHeaderPartial()
        {
            return PartialView();
        }
    }
}