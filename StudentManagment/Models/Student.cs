using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManagment.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Student Name")]
        [MaxLength(50)]
        public string StudentName { get; set; }
        [Required]
        [Range(1, int.MaxValue , ErrorMessage ="Check Your ID!")]
        [Display(Name = "Student ID")]
        public int StudentNumber { get; set; }
        [Display(Name = "Student Courses")]
        public string StudentCourses { get; set; }

        public ICollection<Course> Courses { get; set; }



    }
}
