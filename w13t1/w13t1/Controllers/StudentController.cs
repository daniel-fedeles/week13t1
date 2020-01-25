using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using w13t1.Models;

namespace w13t1.Controllers
{
    public class StudentController : Controller
    {
        IList<Student> studentList = new List<Student>() {
            new Student(){ StudentId=1, StudentName="John", Age = 18 },
            new Student(){ StudentId=2, StudentName="Steve", Age = 21 },
            new Student(){ StudentId=3, StudentName="Bill", Age = 25 },
            new Student(){ StudentId=4, StudentName="Ram", Age = 20 },
            new Student(){ StudentId=5, StudentName="Ron", Age = 31 },
            new Student(){ StudentId=6, StudentName="Chris", Age = 17 },
            new Student(){ StudentId=7, StudentName="Rob", Age = 19 }
        };
        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.TotalStudents = studentList.Count();
            ViewBag.Title = "Students";
            return View(studentList);
        }

        // GET: Student/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Title = "Edit";
            var std = studentList.Where(s => s.StudentId == id).FirstOrDefault();
            return View(std);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(Student std)
        {
            try
            {

                var id = std.StudentId;
                var name = std.StudentName;
                var age = std.Age;
                var standardName = std.standard.StrandardName;

                //update database here..

                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
