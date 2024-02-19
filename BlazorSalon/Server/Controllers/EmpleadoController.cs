using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using BlazorSalon.Server.Models;
using Microsoft.EntityFrameworkCore;
using BlazorSalon.Shared;

namespace BlazorSalon.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly DbsalonContext _dbContext;

        public EmpleadoController(DbsalonContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var lista = new List<EmpleadoDTO>();

            foreach (var item in await _dbContext.Empleados.ToListAsync())
            {
                lista.Add(new EmpleadoDTO
                {
                    IdEmpleado = item.IdEmpleado,
                    Nombre = item.Nombre,
                });
            }
            return Ok(lista);
        }
    }
}
