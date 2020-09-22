using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllisonKieferMIS4200.Models
{
    public class Professor
    {
            public int professorID { get; set; }
            public string description { get; set; }
            public decimal qtyCourse { get; set; }
        public int informationID { get; set; }
        public ICollection<Grade> Grade { get; set; }

        }
}