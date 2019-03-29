using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using distribucion_mkt_digital.Models;

namespace distribucion_mkt_digital.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult login() {
            var menu = new List<MenuPrincipal>();

            if (user_login== "jpurata")
            {
                new MenuPrincipal {id= Guid.NewGuid().ToString(), nombre_modulo="Tabla Materiales", fecha_creacion = DateTime.Now, fecha_modificacion = DateTime.Now, usuario_modificacion = "jpurata"},
                new MenuPrincipal { id = Guid.NewGuid().ToString(), nombre_modulo ="Compras", fecha_creacion = DateTime.Now, fecha_modificacion = DateTime.Now, usuario_modificacion = "jpurata"}

            } else if (user_login == "enrique")
            {

            }
            return View();
        }

        public IActionResult Index()
        {
            var users = new List<Usuarios>()
            {
                new Usuarios {UniqueId = Guid.NewGuid().ToString(), nombre_usuario = "jpurata", contrasenia = "asdf", rol_usuario = "admin", id_unidad_negocio = 1, fecha_creacion = DateTime.Now, fecha_modificacion = DateTime.Now},
                new Usuarios {UniqueId = Guid.NewGuid().ToString(), nombre_usuario = "erick", contrasenia = "asdf", rol_usuario = "dist", id_unidad_negocio = 2, fecha_creacion = DateTime.Now, fecha_modificacion = DateTime.Now },
                new Usuarios {UniqueId = Guid.NewGuid().ToString(), nombre_usuario = "enrique", contrasenia = "asdf", rol_usuario = "dist", id_unidad_negocio = 2, fecha_creacion = DateTime.Now, fecha_modificacion = DateTime.Now },
                new Usuarios {UniqueId = Guid.NewGuid().ToString(), nombre_usuario = "grisel", contrasenia = "asdf", rol_usuario = "brand", id_unidad_negocio = 3, fecha_creacion = DateTime.Now, fecha_modificacion = DateTime.Now }
            };
            
            return View(users);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
    