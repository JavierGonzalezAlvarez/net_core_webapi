using Microsoft.EntityFrameworkCore;
using apiweb.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiweb.Db
{
    public class ApplicationDbContext : DbContext
    {
        //constructor
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        //configurar las tablas de la BD
        public DbSet<User> User { get; set; } 
    }
}
