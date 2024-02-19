using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSalon.Shared
{
    public class DetalleVentaDTO
    {
        public int? Cantidad { get; set; }

        public decimal? SubTotal { get; set; }

        public virtual EmpleadoDTO Empleado { get; set; }

        public virtual ServicioDTO Servicio { get; set; }
    }
}
