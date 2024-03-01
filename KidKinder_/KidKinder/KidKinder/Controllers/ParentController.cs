using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class ParentController : Controller
    {
        // GET: Parent
        KidKinderContext context = new KidKinderContext();

        public ActionResult ParentList()
        {
            var values = context.Parents.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateParent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateParent(Parent parent)
        {
            context.Parents.Add(parent);
            context.SaveChanges();
            return RedirectToAction("ParentList");
        }

        public ActionResult DeleteParent(int id)
        {
            var value = context.Parents.Find(id);
            context.Parents.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ParentList");
        }

        [HttpGet]
        public ActionResult UpdateParent(int id)
        {

           
            return View();


        }
        [HttpPost]
        public ActionResult UpdateParent(Parent parent)
        {
            var value = context.Parents.Find(parent.ParentId);
            
            value.NameSurname = parent.NameSurname;
            value.ParentId = parent.ParentId;
            value.Email = parent.Email;
            value.PhoneNumber = parent.PhoneNumber;
            value.Address = parent.Address;
            context.SaveChanges();
            return RedirectToAction("ParentList");
        }
    }
}