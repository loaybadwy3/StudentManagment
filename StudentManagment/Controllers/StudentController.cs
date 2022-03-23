using Microsoft.AspNetCore.Mvc;
using StudentManagment.Data;
using StudentManagment.Models;
using StudentManagment.ViewModels;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagment.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Student> objList = _db.Students;
            return View(objList);
        }
        public IActionResult Details(int id)
        {
            var obj = _db.Students.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        //public IActionResult Detail(int? id)
        //{
        //    var obj = _db.Students.Find(id);
        //    StudentCourseViewModel scvm = new StudentCourseViewModel();
        //    scvm.student = _db.Students.Find(id);
        //    //scvm.course = _db.Courses.Find(id);

        //    scvm.students = _db.Students;
        //    scvm.courses = _db.Courses;
        //    return View(scvm);

        //}

        public IActionResult Detail()
        {
            StudentCourseViewModel vm = new StudentCourseViewModel();

            vm.Courses = _db.Courses.ToList();

            return View(vm);
        }

        // GET-Add
        public IActionResult Add()
        {

            StudentCourseViewModel vm = new StudentCourseViewModel();
            vm.Courses = _db.Courses.ToList();
            return View(vm);
        }

        // POST-Add
        //[HttpPost]
        //public IActionResult Add(Student obj)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _db.Students.Add(obj);
        //        _db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(obj);
        //}

        [HttpPost]
        public IActionResult AddPost(SaveStudentCourses VM)
        {
            
            Student student = new Student();
            student.StudentName = VM.StudentName;
            student.StudentNumber = VM.StudentNumber;
           // student.Courses = VM.Courses;
            if (ModelState.IsValid)
            {
                _db.Students.Add(student);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        //[HttpPost]
        //public string Add(string StudentName, int StudentNumber, List<int> Courses)
        //{
        //    return "ss";
        //}

        //GET-Delete
        public IActionResult DeleteGet(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Students.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST-Delete
        public IActionResult Delete(int? id)
        {
            var obj = _db.Students.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Students.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        // Update-GET
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Students.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        // Update-POST
        [HttpPost]
        public IActionResult Update(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }
    }
}
