using System;
using System.Collections.Generic;

namespace BlazorSalon.Server.Models;

public partial class DetalleVenta
{
    public int IdDetalleVenta { get; set; }

    public int? IdVenta { get; set; }

    public int? IdEmpleado { get; set; }

    public int? IdServicio { get; set; }

    public int? Cantidad { get; set; }

    public decimal? SubTotal { get; set; }

    public virtual Empleado? IdEmpleadoNavigation { get; set; }

    public virtual Servicio? IdServicioNavigation { get; set; }

    public virtual Venta? IdVentaNavigation { get; set; }
}
