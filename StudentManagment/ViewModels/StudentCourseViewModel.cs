using StudentManagment.Models;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManagment.ViewModels
{
    public class StudentCourseViewModel
    {
        public List<Course> Courses { get; set; }
        [Required]
        [Display(Name = "Student Name")]
        [MaxLength(50)]
        public string StudentName { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Check Your ID!")]
        [Display(Name = "Student ID")]
        public int StudentNumber { get; set; }

        [Display(Name = "Student Courses")]
        public string StudentCourses { get; set; }

        public int CourseId { get; set; }
    }
}
