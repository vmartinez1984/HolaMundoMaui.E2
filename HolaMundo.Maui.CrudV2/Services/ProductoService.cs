using HolaMundo.Maui.CrudV1.Models;
using System.Text.Json;

namespace HolaMundo.Maui.CrudV1.Services
{
    public class ProductoService
    {
        string BaseUrl = "https://utilidades.vmartinez84.xyz/api";
        string Apikey = "vmtz";

        public async Task<List<ProductoModel>> ObtenerTodosAsync()
        {
            var client = new HttpClient();
            var url = BaseUrl + "/Productos?activo=true";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("accept", "application/json");
            request.Headers.Add("apikey", Apikey);
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                List<ProductoModel> lista = JsonSerializer.Deserialize<List<ProductoModel>>(
                    await response.Content.ReadAsStringAsync(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return lista;
            }
            return new List<ProductoModel>();
        }

        public async Task<string> AgregarAsync(ProductoModel producto)
        {
            var client = new HttpClient();
            var url = BaseUrl + "/Productos";
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Headers.Add("accept", "application/json");
            request.Headers.Add("apikey", Apikey);
            var body = JsonSerializer.Serialize(producto);
            var content = new StringContent(body, null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                return producto.Encodedkey;
            }
            else
                return string.Empty;
        }

        internal async Task ActualizarAsync(ProductoModel producto)
        {
            var client = new HttpClient();
            var url = BaseUrl + "/Productos/" + producto.Encodedkey;
            var request = new HttpRequestMessage(HttpMethod.Put, url);
            request.Headers.Add("accept", "application/json");
            request.Headers.Add("apikey", Apikey);
            var body = JsonSerializer.Serialize(producto);
            var content = new StringContent(body, null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }
    }
}
