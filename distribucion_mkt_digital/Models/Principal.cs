using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace distribucion_mkt_digital.Models
{
    public class Principal
    {   
        public static void Main()
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            usuarios.Add(1, "jpurata", "asdf", "admin", 1, fecha_creacion, fecha_modificacion);
            usuarios.Add(2, "erick", "asdf", "admin", 3, fecha_creacion, fecha_modificacion);
            usuarios.Add(3, "enrique", "asdf", "brand_manager", 5, fecha_creacion, fecha_modificacion);

            Console.WriteLine();
            foreach (Usuarios us in Usuarios)
            {
                Console.WriteLine(us);
            }
        }
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}
