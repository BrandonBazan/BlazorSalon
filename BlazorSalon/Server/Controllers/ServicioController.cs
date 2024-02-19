using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using BlazorSalon.Server.Models;
using Microsoft.EntityFrameworkCore;
using BlazorSalon.Shared;

namespace BlazorSalon.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
        private readonly DbsalonContext _dbContext;

        public ServicioController(DbsalonContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var lista = new List<ServicioDTO>();

            foreach (var item in await _dbContext.Servicios.ToListAsync())
            {
                lista.Add(new ServicioDTO
                {
                    IdServicio = item.IdServicio,
                    Nombre = item.Nombre,
                    Precio = item.Precio,
                });
            }
            return Ok(lista);
        }
    }
}
