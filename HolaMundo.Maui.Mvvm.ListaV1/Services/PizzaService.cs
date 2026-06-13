using HolaMundo.Maui.Mvvm.ListaV1.Models;
using System.Text.Json;

namespace HolaMundo.Maui.Mvvm.ListaV1.Services
{
    public class PizzaService
    {
        public async Task<List<PizzaModel>> ObtenerAsync()
        {
            string url = "https://utilidades.vmartinez84.xyz/api/Pizzas/Pizzas";
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                List<PizzaModel> pizzas = JsonSerializer.Deserialize<List<PizzaModel>>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    );

                return pizzas;
            }
            else
            {
               return new List<PizzaModel>();
            }           
        }
    }
}
