using HolaMundo.Maui.MvvmV1.Models;

namespace HolaMundo.Maui.MvvmV1.Services
{
    public class ClienteService
    {
        public async Task<ClienteModel> ObtenerAsync()
        {
            await Task.Delay(3000);
            return new ClienteModel
            {
                Nombre = "PAncho", Apellidos = "Rosales"
            };
        }
    }
}
