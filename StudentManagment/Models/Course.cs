using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManagment.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Course Name")]
        public string CourseName { get; set; }
        [Required]
        [Display(Name = "Course ID")]
        public int CourseNumber { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
