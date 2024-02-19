using BlazorSalon.Shared;

namespace BlazorSalon.Client.Servicio
{
    public interface IEmpleadoService
    {
        Task<List<EmpleadoDTO>> Lista();
    }
}
