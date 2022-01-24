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
     
        private mvcDbContext db;

        public TeacherController()
        {


            db = new mvcDbContext();
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
            return View();

        }
        
        public ActionResult Insert()
        {
            Teacher obj = new Teacher();

            obj.teacherName = "Johan";
            obj.teacherNo = "77";

            db.Teachers.Add(obj);



            db.Teachers.Add(new Models.Teacher
            {
                teacherName = "Mzzz",
                teacherNo = "64"
            }
            ) ;
            db.SaveChanges();
            
            return View();
        }
    
    
        public ActionResult Update(int id)
        {
            Teacher obj = new Teacher();

            obj = db.Teachers.Find(id);

            obj.teacherName = "Melissa";
            obj.teacherNo = "44";


            db.SaveChanges();

            return View();
        }


        public ActionResult Delete(int id)
        {
            Teacher obj = new Teacher();

            obj = db.Teachers.Find(id);

            db.Teachers.Remove(obj);


            db.SaveChanges();


            return View();

        }


    
    }
}