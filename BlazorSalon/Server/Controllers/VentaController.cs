using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using BlazorSalon.Server.Models;
using Microsoft.EntityFrameworkCore;
using BlazorSalon.Shared;

namespace BlazorSalon.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly DbsalonContext _dbContext;

        public VentaController(DbsalonContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpPost]
        public async Task<IActionResult> Post(VentaDTO ventaDto)
        {
            try
            {
                var mdVenta = new Venta();
                var mdDetalleVenta = new List<DetalleVenta>();

                mdVenta.Cliente = ventaDto.Cliente;
                mdVenta.Total = ventaDto.Total;

                foreach (var item in ventaDto.DetalleVenta)
                {
                    mdDetalleVenta.Add(new DetalleVenta
                    {
                        IdEmpleado = item.Empleado.IdEmpleado,
                        IdServicio = item.Servicio.IdServicio,
                        Cantidad = item.Cantidad,
                        SubTotal = item.SubTotal
                    });
                }

                mdVenta.DetalleVenta = mdDetalleVenta;

                _dbContext.Venta.Add(mdVenta);
                await _dbContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
