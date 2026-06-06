using HolaMundo.Maui.Picker.Models;

namespace HolaMundo.Maui.Picker.Service
{
    public class ServiceVianey
    {
        public async Task<List<FrutaModel>> ObtenerTodosAsync()
        {
            await Task.Delay(3000);
            var frutas = new List<FrutaModel>();
            frutas.Add(new FrutaModel(1, "Platano"));
            frutas.Add(new FrutaModel(2, "Manzana"));
            frutas.Add(new FrutaModel(2, "Papaya"));
            
            return frutas;
        }
    }
}
