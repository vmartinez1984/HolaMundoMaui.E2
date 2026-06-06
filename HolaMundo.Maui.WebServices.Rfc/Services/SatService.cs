using HolaMundo.Maui.WebServices.Rfc.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolaMundo.Maui.WebServices.Rfc.Services
{
    public class SatService
    {
        public async Task<string> GenerateRfc(SolicitudDeRfcModel solicitud)
        {
            var client = new HttpClient();
            var url = "https://utilidades.vmartinez84.xyz/api/Rfc";
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Headers.Add("accept", "application/json");
            var payload = System.Text.Json.JsonSerializer.Serialize(solicitud);
            var content = new StringContent(payload, null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            Console.WriteLine(await response.Content.ReadAsStringAsync());
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var rfcDto = System.Text.Json.JsonSerializer.Deserialize<RfcDto>(json);

                return rfcDto.Rfc;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
