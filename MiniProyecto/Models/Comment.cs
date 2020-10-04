using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProyecto.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Photo Photo { get; set; }
    }
}