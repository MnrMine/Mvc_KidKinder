using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class Student
    {

        public int StudentId { get; set; }

        public string NameSurname{ get; set; }

        public string Birthday { get; set; }

        public string ParentId{ get; set; }

        public string Status { get; set; }

        
    }
}