using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;

namespace KidKinder.Controllers
{

    [Authorize]
    public class AdminClassRoomController : Controller
    {
        KidKinderContext context = new KidKinderContext();


        public ActionResult ClassRoomList()
        {
            var values = context.ClassRooms.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateClassRoom()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult CreateClassRoom(ClassRoom classRoom)
        {
            context.ClassRooms.Add(classRoom);
            context.SaveChanges();
            return RedirectToAction("ClassRoomList");
        }

        public ActionResult DeleteClassRoom(int id)
        {
            var value = context.ClassRooms.Find(id);
            context.ClassRooms.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ClassRoomList");
        }

        [HttpGet]
        public ActionResult UpdateClassRoom(int id)
        {

            
            return View();


        }

        [HttpPost]
        public ActionResult UpdateClassRoom(ClassRoom classRoom)
        {
            var value = context.ClassRooms.Find(classRoom.ClassRoomId);
            value.Title = classRoom.Title;
            value.TotalSeat = classRoom.TotalSeat;
            value.AgeOfKinds = classRoom.AgeOfKinds;
            value.Price= classRoom.Price;
            value.ClassTime= classRoom.ClassTime;
            
            context.SaveChanges();
            return RedirectToAction("ClassRoomList");
        }
    }
}