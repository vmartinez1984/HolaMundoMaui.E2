using HolaMundo.Maui.WebService.Nasa.Models;
using System.Text.Json;

namespace HolaMundo.Maui.WebService.Nasa.Services
{
    public class NasaService
    {
        public async Task<FotoDelDiaModel> ObtenerLaFotoDelDiaAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get,
                "https://api.nasa.gov/planetary/apod?api_key=gql2imgmAjMFE3FIaqbouPEawWbq0mMEtuIDU0Dl");
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                FotoDelDiaModel fotoDelDia = JsonSerializer.Deserialize<FotoDelDiaModel>(
                    await response.Content.ReadAsStringAsync(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return fotoDelDia;
            }
            return null;
        }
    }
}
