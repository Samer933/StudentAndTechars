using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class StudentController : Controller
    {

        private mvcDbContext db;


        public StudentController()
        {
            db = new mvcDbContext();
        }

        public ActionResult GetStudent(int id)
        {
            //Student i = db.Students.Find(id);

            Student obj = (from x in db.Students
                        where x.studentId == id
                        select x).FirstOrDefault();

           
            return View();

        }




        public ActionResult GetStudents()
        {
            //List<Student> obj = new List<Student>();

            //foreach(var i in db.Students)
            //{
            //    obj.Add(i);
            //}

            List<Student> list = new List<Student>();

            list = (from x in db.Students select x).ToList();




            return View(list);

        }



        [HttpGet]
        public ActionResult Insert()
        {
         return View("Insert");
        }






          [HttpPost]
        public ActionResult Insert (Student student)
        {
            //Student obj = new Student();

            //obj.studentName = "Kalle";
            //obj.studentNo = "54";

            db.Students.Add(student);


            //db.Students.Add(new Models.Student
            //{

            //    studentNo = "32",
            //    studentName = "Stevan"


            //});



            db.SaveChanges();


            return RedirectToAction("GetStudents");
        }

        public ActionResult Update(int id)
        {
            Student obj = new Student();

            obj = db.Students.Find(id);
            obj.studentName = "Samer";
            obj.studentNo = "12";

            //Student i = new Student();

            //i = (from x in db.Students
            //     where x.studentId == id
            //     select x).FirstOrDefault();

            //i.studentName = "Emma";
            //i.studentNo = "33";




            db.SaveChanges();

            return View();
        }


         public ActionResult Delete (int id)
        {

            Student obj = new Student();

            obj = (from x in db.Students
                   where x.studentId == id
                   select x).FirstOrDefault();

                   db.Students.Remove(obj);


            //Student ob = db.Students.Find(id);
            //db.Students.Remove(ob);

            db.SaveChanges();


            return View();

        }


    }
}