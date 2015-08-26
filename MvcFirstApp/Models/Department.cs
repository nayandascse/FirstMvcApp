using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcFirstApp.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Plz enter department Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Plz enter department Code")]
        public string Code { get; set; }
        public virtual ICollection<Student> Students { set; get; } 

    }
}