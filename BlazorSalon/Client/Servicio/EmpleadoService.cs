using BlazorSalon.Shared;
using System.Net.Http.Json;

namespace BlazorSalon.Client.Servicio
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly HttpClient _http;

        public EmpleadoService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<EmpleadoDTO>> Lista()
        {
            var lista = new List<EmpleadoDTO>();

            lista = await _http.GetFromJsonAsync<List<EmpleadoDTO>>("api/Empleado");

            return lista!;
        }
    }
}
