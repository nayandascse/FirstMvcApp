using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcFirstApp.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Plz enter  Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Plz enter  email")]
        [EmailAddress(ErrorMessage = "invalid email")]
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

    }
}