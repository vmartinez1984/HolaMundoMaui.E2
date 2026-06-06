using HolaMundo.Maui.Coleccion.Models;

namespace HolaMundo.Maui.Coleccion.Services
{
    public class PizzasService
    {
        public async Task<List<PizzaModel>> ObtenerTodosAsync()
        {
            await Task.Delay(500);
            var lista = new List<PizzaModel>();
            lista.Add(new PizzaModel(1, "Mexicana", "Jalapeño Carne"));
            lista.Add(new PizzaModel(2, "Hawaiina", "Jamón y piña"));

            return lista;
        }
    }
}
