using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProyecto.Models
{
    public class PhotoDTO
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public AlbumDTO Album { get; set; }
    }
}