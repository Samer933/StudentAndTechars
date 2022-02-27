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

        public ActionResult List()
        {
            List<Course> CourseList = new List<Course>();

            //CourseList = (from obj in db.Courses


            //              select obj).ToList();


            List<Course> obj = new List<Course>();

            foreach (var i in db.Courses)
            {
                obj.Add(i);
                
            }


            return View(obj);
        }
        public ActionResult GetCourse(int id)
        {

            Course obj = new Course();
            obj = (from x in db.Courses
                   where x.courseId == id
                   select x).FirstOrDefault();


            //Education teEdu = _context.Educations.Where(x => x.Title == education.Title).FirstOrDefault();

            return View(obj);


        }

        [HttpGet]
        public ActionResult InsertCourse()
        {
           



          


            return View();

        }

        [HttpPost]
        public ActionResult InsertCourse(Course course)
        {
     
            db.Courses.Add(course);


            db.SaveChanges();



            return RedirectToAction("List");
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


         //   Course obj = new Course();

         //obj = db.Courses.Find(id);
         //   db.Courses.Remove(obj);



            db.Courses.Remove(db.Courses.Find(id));
            db.SaveChanges();


            return RedirectToAction("List");
        }
       

        [HttpPost]
        public ActionResult Edit(Course course)
        {
            Course obj = new Course();


            obj = db.Courses.Find(course.courseId);

            obj.courseName = course.courseName;
            obj.isAvailable = course.isAvailable;



            //obj = (from x in db.Courses
            //       where x.courseId == id
            //       select x).FirstOrDefault();

            //obj.courseName = "DataApplicaation" ;



            //Course course = db.Courses.Find(id);
            //course.isAvailable = false;
            db.SaveChanges();


            return RedirectToAction("List");

        }



        [HttpGet]
        public ActionResult Edit(int id)
        {
            Course obj = new Course();
            obj = db.Courses.Find(id);

         



            return View(obj);
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