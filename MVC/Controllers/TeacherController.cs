using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class TeacherController : Controller
    {
        mvcDbContext db = new mvcDbContext();

       
        public ActionResult Index()
        {

            return View();
        }


        public ActionResult GetDetails()
        {
            List<Teacher> list = new List<Teacher>();
            list = (from x in db.Teachers
                    select x).ToList();


            List<Teacher> teachers = new List<Teacher>();

            foreach(var i in db.Teachers)
            {
                teachers.Add(i);
            }
            return View("GetDetails",list);

        }
        
       [HttpGet] // We return the view only
        public ActionResult addTeacher()
        {




            return View("addTeacher");   
                
}




[HttpPost] // This to send the data from the view to the database in order to save it
        public ActionResult addTeacher(Teacher teacher)
        {


            db.Teachers.Add(teacher);

            db.SaveChanges();



            return RedirectToAction("GetDetails");
        }


        public ActionResult Insert()
        {
            Teacher obj = new Teacher();

            obj.teacherName = "Johan";
            obj.teacherNo = "77";

            db.Teachers.Add(obj);



            //db.Teachers.Add(new Models.Teacher
            //{
            //    teacherName = "Mzzz",
            //    teacherNo = "64"
            //}
            //) ;
            db.SaveChanges();
            
            return View();
        }
    
       
        [HttpGet]
        public ActionResult Edit (int id)
        {
            Teacher obj = new Teacher();

            obj = db.Teachers.Find(id);



            ViewBag.Name = obj.teacherName;
            ViewBag.Number = obj.teacherNo;


            db.SaveChanges();

            return View(obj);
        }

    
        [HttpPost]
        public ActionResult Edit(Teacher teacher)
        {
           

            //obj = db.Teachers.Find(id);

            //obj.teacherName = "Melissa";
            //obj.teacherNo = "44";



            


            db.SaveChanges();

            return RedirectToAction("GetDetails");
        }

     

        public ActionResult Delete(int id)
        {
            Teacher obj = new Teacher();

            obj = db.Teachers.Find(id);

            db.Teachers.Remove(obj);


            db.SaveChanges();





            //Teacher teach = new Teacher();

            //teach = (from data in db.Teachers
            //         where data.teacherId == id
            //         select data).FirstOrDefault();





            return RedirectToAction("GetDetails");

        }


    
    }
}