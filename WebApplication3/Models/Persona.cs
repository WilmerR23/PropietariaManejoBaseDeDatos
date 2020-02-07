using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Persona
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

    }

    public class DbContextPersona : DbContext {
        
        public DbContextPersona() : base("PersonaCS")
        {

        }

        public DbSet<Persona> Personas { get; set; }

    }
}