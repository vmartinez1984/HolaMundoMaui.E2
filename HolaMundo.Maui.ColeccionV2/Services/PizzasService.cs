using HolaMundo.Maui.Coleccion.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HolaMundo.Maui.Coleccion.Services
{
    public class PizzasService
    {
        string baseUrl;
        public PizzasService()
        {
            baseUrl = "https://utilidades.vmartinez84.xyz/api/Pizzas/";
        }

        public async Task<List<PizzaModel>> ObtenerTodosAsync()
        {
            string url = $"{baseUrl}Pizzas";
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get,url);
            request.Headers.Add("accept", "application/json");
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                List<PizzaModel> pizzas = JsonSerializer.Deserialize<List<PizzaModel>>(
                    await response.Content.ReadAsStringAsync(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true}
                );
                for (int i = 0; i < pizzas.Count; i++)
                {
                    pizzas[i].Ruta = baseUrl.Replace("api/Pizzas/", string.Empty) + pizzas[i].Ruta.TrimStart('/');
                }

                return pizzas;
            }
            else
            {
                return new List<PizzaModel>();
            }
        }
    }
}
