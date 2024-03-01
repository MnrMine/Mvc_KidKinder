﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        KidKinderContext context = new KidKinderContext();
        public ActionResult StudentList()
        {
            var values = context.Students.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return RedirectToAction("StudentList");
        }

        public ActionResult DeleteStudent(int id)
        {
            var value = context.Students.Find(id);
            context.Students.Remove(value);
            context.SaveChanges();
            return RedirectToAction("StudentList");
        }
        [HttpGet]
        public ActionResult UpdateStudent(int id)
        {

            return View();


        }
        [HttpPost]
        public ActionResult UpdateStudent(Student student)
        {
            var value = context.Students.Find(student.StudentId);

            value.NameSurname = student.NameSurname;
            value.StudentId = student.StudentId;
            value.Birthday = student.Birthday;
            value.ParentId = student.ParentId;
            value.Status = student.Status;
            context.SaveChanges();
            return RedirectToAction("StudentList");
        }
    }
}