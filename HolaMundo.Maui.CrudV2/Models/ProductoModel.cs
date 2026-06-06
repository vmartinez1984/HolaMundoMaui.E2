using System.Text.Json.Serialization;

namespace HolaMundo.Maui.CrudV1.Models
{
    public class ProductoModel
    {
        public string Encodedkey { get; set; } = Guid.NewGuid().ToString();
        
        [JsonPropertyName("valor01")]
        public string Nombre { get; set; }

        [JsonPropertyName("valor02")]
        public string Descripcion { get; set; }
    }
}
