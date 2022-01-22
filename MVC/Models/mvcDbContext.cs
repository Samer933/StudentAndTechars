using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class mvcDbContext : DbContext
    {

        public mvcDbContext() : base ("mvcConnectionString")
        {

        }


        public DbSet<Room>Rooms { get; set; }

        public DbSet <Course> Courses { get; set; }

        public DbSet <Student>Students { get; set; }

        public DbSet <Teacher> Teachers { get; set; }


    }
}