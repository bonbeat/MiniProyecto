using MiniProyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniProyecto.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            ViewBag.list = GetAlbums();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private IEnumerable<AlbumDTO> GetAlbums()
        {
            var List = (from obj in db.Album
                                select new AlbumDTO
                                {
                                    Id = obj.Id,
                                    Nombre = obj.Nombre,
                                    Status = obj.Status,
                                }).ToList().Where(c => c.Status == "Disponible");
            return List;
        }
    }
}