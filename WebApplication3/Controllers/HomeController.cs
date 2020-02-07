using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public DbContextPersona _db = new DbContextPersona();


        public ActionResult Index()
        {
            var data = _db.Personas.ToList();
            return View(data);
        }

        public ActionResult About()
        {
            _db.Personas.Add(new Persona { Id = 1, Nombre = "Jose" });
            _db.SaveChanges();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}