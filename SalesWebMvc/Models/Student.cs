using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        
        [Display(Name = "Name")]
        public string StudentName { get; set; }
        public int Age { get; set; }
        public bool IsNewlyEnrolled { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            return StudentName + "->" + Age;
        }

    }
}
