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
    public class DashBoardController : Controller
    {
       
        KidKinderContext context = new KidKinderContext();

        public ActionResult Index()
        {
            ViewBag.ResimCizmeCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z => z.Name == "Resim Çizim").Select(y => y.BranchId).FirstOrDefault()).Count();

            ViewBag.AvgPrice = context.ClassRooms.Average(x => x.Price).ToString("0.00");

            ViewBag.totalseat = context.ClassRooms.Sum(x => x.TotalSeat).ToString();
            ViewBag.v1 = context.Teachers.Count();
            ViewBag.v2 = context.Students.Count();
            ViewBag.v3 = context.Testimonials.Count();
            ViewBag.v4 = context.Parents.Count();
            var values = context.Testimonials.OrderByDescending(x => x.TestimonialId).ToList();


            return View(values);
        }
    }
}