using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class CourseController : Controller
    {

        private mvcDbContext db;

        public CourseController()
        {
            db = new mvcDbContext();
        }

        public ActionResult getCourses()
        {
            List<Course> CourseList = new List<Course>();

            //CourseList = (from obj in db.Courses


            //              select obj).ToList();


            List<Course> obj = new List<Course>();

            foreach (var i in db.Courses)
            {
                obj.Add(i);
                
            }


            return View("Index");
        }
        public ActionResult GetCourse(int id)
        {

            Course obj = new Course();
            obj = (from x in db.Courses
                   where x.courseId == id
                   select x).FirstOrDefault();


            //Education teEdu = _context.Educations.Where(x => x.Title == education.Title).FirstOrDefault();

            return View("Details");


        }

        public ActionResult InsertCourse()
        {
            Course obj = new Course();

            obj.courseName = "Data";
            obj.isAvailable = true;

            db.Courses.Add(obj);
            db.SaveChanges();


            return View("Courses");

        }



        //public ActionResult GetCourse(Course model)
        //{


        //    db.Courses.Add(new Models.Course
        //    {


        //        courseName = model.courseName,
        //        isAvailable = model.isAvailable

        //    });

        //    //Course Courses = db.Courses.Where(x => x.courseName == name.courseName ).FirstOrDefault();
        //    return View("Test");
        //}



        public ActionResult DeleteCourse(int id)
        {
            //Course obj = new Course();

            //obj = (from x in db.Courses
            //       where x.courseId == id
            //       select x).FirstOrDefault();

            //db.Courses.Remove(obj);



            db.Courses.Remove(db.Courses.Find(id));
            db.SaveChanges();
            return View();
        }
       

        public ActionResult UpdateCourse(int id)
        {
            Course obj = new Course();

            obj = (from x in db.Courses
                   where x.courseId == id
                   select x).FirstOrDefault();

            obj.courseName = "DataApplicaation" ;



            Course course = db.Courses.Find(id);
            course.isAvailable = false;



            db.SaveChanges();


            return View("Courses");

        }































        //JsonResult
        //ViewResult
        //File
        //The Action Result is the main , and it's dynamic types 
        //that can accept the other types 
       //public ActionResult getCourses()
       // {
       //     int x = 0;
       //     if (x > 0) {

       //         return Json(null);
       //     }

       //     else
       //     {
       //      return  RedirectToAction("Text");
       //     }

            
       // }
  
       //   public ActionResult Text()
       // {


       //     return View();
       // }
    
    
    
    
    
    
    }
}