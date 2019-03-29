using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace distribucion_mkt_digital.Models
{
    public class Materiales
    {
        long id;
        long id_unidad_negocio;
        long id_formato_material;
        DateTime fecha_solicitud = new DateTime();
        long id_nombre_campania;
        string vigencia_campania;
        long id_ceco_publicidad;
        long id_ceco_operativo;
        string observaciones;
        long id_canal;
        long id_sucursales;
        long id_cedis;
        DateTime fecha_creacion = new DateTime();
        DateTime fecha_modificacion = new DateTime();
        string usuario_modificacion;

        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}
