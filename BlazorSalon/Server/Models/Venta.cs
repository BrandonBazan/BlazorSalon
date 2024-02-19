using System;
using System.Collections.Generic;

namespace BlazorSalon.Server.Models;

public partial class Venta
{
    public int IdVenta { get; set; }

    public string? Cliente { get; set; }

    public decimal? Total { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();
}
