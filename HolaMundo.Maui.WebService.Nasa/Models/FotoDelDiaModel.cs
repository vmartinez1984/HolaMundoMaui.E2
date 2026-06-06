using System.Text.Json.Serialization;

namespace HolaMundo.Maui.WebService.Nasa.Models
{
    public class FotoDelDiaModel
    {
        [JsonPropertyName("date")]
        public string Fecha { get; set; }

        [JsonPropertyName("explanation")]
        public string Explanation { get; set; }

        [JsonPropertyName("hdurl")]
        public string Hdurl { get; set; }

        [JsonPropertyName("media_type")]
        public string MediaType { get; set; }

        [JsonPropertyName("service_version")]
        public string ServiceVersion { get; set; }

        [JsonPropertyName("title")]
        public string Titulo { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
