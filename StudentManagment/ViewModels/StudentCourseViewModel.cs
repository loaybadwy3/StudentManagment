using StudentManagment.Models;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManagment.ViewModels
{
    public class StudentCourseViewModel
    {
        public int Id { get; set; }
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }

        public string StudentName { get; set; }

        public int StudentNumber { get; set; }

        public string StudentCourses { get; set; }

        public string CourseName { get; set; }

        public int CourseNumber { get; set; }

        public int CourseId { get; set; }
        public int StudentId { get; set; }

    }
}
