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
            return View();
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
            obj.rommName = "Sal33";
            obj.isAvailable = false;

            db.Rooms.Add(obj);

           


            db.Rooms.Add(new Models.Room
            {
                rommName = "Sal77",
                isAvailable = true 


            }) ;


            db.SaveChanges();


            return View();
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






            return View();

        }







    }
}