using System.ComponentModel.DataAnnotations;

namespace Final_project.Models
{
    public class Person
    {
        [ScaffoldColumn(false)]
        public int PersonID { get; set; }

        [Required, StringLength(30), Display(Name = "Name")]
        public string PersonName { get; set; }

        [Required, StringLength(30), Display(Name = "Surname")]
        public string PersonSurname { get; set; }

        [Required, Display(Name = "Age")]
        public int PersonAge { get; set; }

        [Required, Display(Name = "Height")]
        public int PersonHeight { get; set; }

        [Required, Display(Name = "Weight")]
        public int PersonWeight { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Leg Length")]
        public int? PersonLegLength { get; set; }

        [Display(Name = "Shoe Size")]
        public int? PersonShoeSize { get; set; }

        [Required, Display(Name = "Gender")]
        public int GenderID { get; set; }

        public virtual Gender Gender { get; set; }

    }
}