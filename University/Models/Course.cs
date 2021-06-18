using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace University.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="عنوان دوره")]
        [Required(ErrorMessage = "وارد کردن {0} ضروری است")]
        public string Title { get; set; }

        public virtual ICollection<Student_Course> Student_Courses { get; set; }
    }
}
