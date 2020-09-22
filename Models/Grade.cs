using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AllisonKieferMIS4200.Models
{
    public class Grade
    {
        [Key]

            public int gradeID { get; set; }
            public int numberCourses { get; set; }
            public decimal Courseprice { get; set; }

            public int professorID { get; set; }
            public virtual Professor professor { get; set; }


            public int courseID { get; set; }
            public virtual Course course { get; set; }
            






        }
}