using System;

namespace distribucion_mkt_digital.Models
{
    public class Usuarios
    {
        public string UniqueId { get; set; }
        public string nombre_usuario { get; set; }
        public string contrasenia { get; set; }
        public string rol_usuario { get; set; }
        public long id_unidad_negocio { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime fecha_modificacion { get; set; }

        public Usuarios()
        {
            UniqueId = Guid.NewGuid().ToString();
        }

    }

}

