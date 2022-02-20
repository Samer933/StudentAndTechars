using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class RoomController : Controller
    {
        private mvcDbContext db;

        public RoomController()
        {
            db = new mvcDbContext();
        }  
       public ActionResult RoomDetails()
        {
           // List<Room> Roomm = new List<Room>(); 
            
           //Roomm  = (from x in db.Rooms select x).ToList();
            List<Room> Rooms = new List<Room>(); 
            foreach(var i in db.Rooms)
            {
                Rooms.Add(i);

            }
            return View("RoomDetails",Rooms);
        }
 

        public ActionResult GetDetails(int id)
        {
           Room obj = db.Rooms.Find(id);

            Room rooms = new Room();
            rooms = (from x in db.Rooms
                     where x.roomId == id
                     select x).FirstOrDefault();


            List<Room> List = new List<Room>();
            List.Add(rooms);


            //ViewBag.Message1 = rooms.roomId;
            //ViewBag.Message2 = rooms.rommName;
           
            //ViewBag.Message3 = rooms.Location;
            //ViewBag.Message4 = rooms.isAvailable;
            //ViewBag.Message5 = rooms.roomSize;

            return View("GetDetails", obj);

        }


        [HttpGet]
        public ActionResult Insert()
        {




            return View();
        }



        [HttpPost]
        public ActionResult Insert(Room room)
        {



            db.Rooms.Add(room);

            db.SaveChanges();



            return RedirectToAction("Insert");

            //obj = (from x in db.Rooms
            //       where x.roomId == RoomId
            //       select x).FirstOrDefault();

            //Room obj = new Room();
            //obj.rommName = "Sal12345";
            //obj.isAvailable = false;
            //obj.Location = "Kumla";
            //obj.roomSize = 199;

            //db.Rooms.Add(obj);




            //db.Rooms.Add(new Models.Room
            //{
            //    rommName = "Sal77",
            //    isAvailable = true,
            //    Location = "Västerås",
            //    roomSize = 65


            //}) ;



        }

        public ActionResult DeleteRoom(int id )
        {
            //Room obj = db.Rooms.Find(id);

            //db.Rooms.Remove(obj);


            Room DeletedRoom = new Room();

            DeletedRoom = (from x in db.Rooms
                           where x.roomId == id
                           select x).FirstOrDefault();

            db.Rooms.Remove(DeletedRoom);

            return View("Index");

        }

        public ActionResult UpdateRoom(int id)
        {

            Room Obj = new Room();
            Obj = (from x in db.Rooms

                   where x.roomId == id
                   select x).FirstOrDefault();

            Obj.rommName = "Sal 899";
            Obj.isAvailable = false;
            Obj.Location = "Örebro";
            Obj.roomSize = 43 ;


            db.SaveChanges();
            return View("Index");
        }

 
        

    }
}