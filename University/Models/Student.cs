using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace University.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="نام")]
        [Required(ErrorMessage = "وارد کردن {0} ضروری است")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "وارد کردن {0} ضروری است")]
        public string LastName { get; set; }

        public virtual ICollection<Student_Course> Student_Courses { get; set; }
    }
}
