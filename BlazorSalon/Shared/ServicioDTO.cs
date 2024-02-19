using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSalon.Shared
{
    public class ServicioDTO
    {
        public int IdServicio { get; set; }

        public string? Nombre { get; set; }

        public decimal? Precio { get; set; }
    }
}
