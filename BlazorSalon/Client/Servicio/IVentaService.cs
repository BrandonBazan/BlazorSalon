using BlazorSalon.Shared;

namespace BlazorSalon.Client.Servicio
{
    public interface IVentaService
    {
        Task<bool> Guardar(VentaDTO ventaDTO);
    }
}
