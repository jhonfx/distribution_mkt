using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace distribucion_mkt_digital.Models
{
    public class MedidaMaterial
    {
        long id;
        string medida_material;
        DateTime fecha_creacion = new DateTime();
        DateTime fecha_modificacion = new DateTime();
        string usuario_modificacion;
        long id_formato_material;

        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}
