using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MiniProyecto.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Album> Album { get; set; }
        public DbSet<Photo> Photo { get; set; }
        public DbSet<Comment> Comment { get; set; }

        public ApplicationDbContext() : base("DefaultConnection")
        {
        }
    }
}