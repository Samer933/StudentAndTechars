using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int roomId { get; set; }
        public string rommName { get; set; }
        public int roomSize { get; set; }

        public bool isAvailable { get; set; }

        public string Location { get; set; }

    }
}