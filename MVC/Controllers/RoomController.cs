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
       public ActionResult GetRooms()
        {
           // List<Room> Roomm = new List<Room>(); 
            
           //Roomm  = (from x in db.Rooms select x).ToList();
            List<Room> Rooms = new List<Room>(); 
            foreach(var i in db.Rooms)
            {
                Rooms.Add(i);

            }
            return View("RoomDetails");
        }
 

        public ActionResult GetDetails(int id)
        {
           //Room obj = db.Rooms.Find(id);

            Room rooms = new Room();
            rooms = (from x in db.Rooms
                     where x.roomId == id
                     select x).FirstOrDefault();


            return View("RoomDetails");

        }

        public ActionResult InsertRoom()
        {


            //obj = (from x in db.Rooms
            //       where x.roomId == RoomId
            //       select x).FirstOrDefault();
           
            Room obj = new Room();
            obj.rommName = "Sal55";
            obj.isAvailable = false;
            obj.Location = "Örebro";
            obj.roomSize = 16;

            db.Rooms.Add(obj);




            //db.Rooms.Add(new Models.Room
            //{
            //    rommName = "Sal77",
            //    isAvailable = true,
            //    Location = "Västerås",
            //    roomSize = 65


            //}) ;


            db.SaveChanges();


            return View("Index");
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