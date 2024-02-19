using BlazorSalon.Shared;
using System.Net.Http.Json;

namespace BlazorSalon.Client.Servicio
{
    public class ServicioService : IServicioService
    {

        private readonly HttpClient _http;

        public ServicioService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<ServicioDTO>> Lista()
        {
            var lista = new List<ServicioDTO>();

            lista = await _http.GetFromJsonAsync<List<ServicioDTO>>("api/Servicio");

            return lista!;
        }
    }
}
