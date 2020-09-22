using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace AllisonKieferMIS4200.Models
{
    public class Course
    {
       
            public int courseID { get; set; }
            public string description { get; set; }
            public DateTime courseDate { get; set; }

        public ICollection <Grade> Grade { get; set; }

        public int studentId { get; set; }
        public virtual Students students { get; set; }

        }
}