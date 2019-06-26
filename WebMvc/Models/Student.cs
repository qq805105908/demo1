using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMvc.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public int ClassID { get; set; }
    }
}