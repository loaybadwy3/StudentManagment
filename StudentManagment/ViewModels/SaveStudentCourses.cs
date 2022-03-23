using StudentManagment.Models;
using System.Collections.Generic;

namespace StudentManagment.ViewModels
{
    public class SaveStudentCourses
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int StudentNumber { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public List<int> Courses { get; set; }

    }
}
