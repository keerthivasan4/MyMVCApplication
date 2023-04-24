using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApplication.Models;

namespace MyMVCApplication.Controllers
{
    public class StudentController : Controller
    {
        public static List<Student> listStudent = new List<Student>{
            new Student("Keerthi",24,0),
            new Student("Vasan",24,1),
            new Student(){Name="kauya",Age=23,Id=2}
        };
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Message = "hi student";
            return View();
        }

        //[ActionName("first")]
        public ActionResult second()
        {
            return View(listStudent);
        }

        //[HttpGet]
        public ActionResult Edit(int id)
        {
            Student s = listStudent.Where(stu => stu.Id == id).FirstOrDefault();
            //return RedirectToAction("second");
            return View(s);
        }

        [HttpPost]
        public ActionResult Edit(Student stu)
        {
            //Student s = listStudent.Where(student => { 
            //    if(student.Id == stu.Id)
            //    {
            //        student.Name = stu.Name;
            //        student.Age = stu.Age;
            //    }
            //});
            int i = listStudent.FindIndex(student => student.Id == stu.Id);
            listStudent[i].Name = stu.Name;
            listStudent[i].Age = stu.Age;

            return RedirectToAction("second");
        }
    }
}