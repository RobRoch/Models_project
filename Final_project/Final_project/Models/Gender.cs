using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_project.Models
{
    public class Gender
    {
        [ScaffoldColumn(false)]
        public int GenderID { get; set; }

        [Required, StringLength(30), Display(Name = "Name")]
        public string GenderName { get; set; }

        public virtual ICollection<Person> Persons { get; set; }
    }
}