using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AllisonKieferMIS4200.Models
{
    public class Students
    {
    [Key]
            public int studentID { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public string address { get; set; }
            public ICollection<Course> Course { get; set; }


        }
}