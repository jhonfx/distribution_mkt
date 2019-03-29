using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace distribucion_mkt_digital.Models
{
    public class Sucursales
    {
        long id;
        string nombre_sucursal;
        long id_centro_distribucion;
        string centro_costo;
        string estatus_ceco;
        long id_canal;
        DateTime fecha_creacion = new DateTime();
        DateTime fecha_modificacion = new DateTime();
        string usuario_modificacion;

        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}
