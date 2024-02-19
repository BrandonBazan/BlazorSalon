using BlazorSalon.Shared;

namespace BlazorSalon.Client.Servicio
{
    public interface IServicioService
    {
        Task<List<ServicioDTO>> Lista();
    }
}
