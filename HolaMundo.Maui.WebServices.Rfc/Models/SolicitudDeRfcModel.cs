using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace HolaMundo.Maui.WebServices.Rfc.Models
{
    public class SolicitudDeRfcModel
    {
        [JsonPropertyName("tipoDePersona")]
        public int TipoDePersona { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("primerApellido")]
        public string PrimerApellido { get; set; }

        [JsonPropertyName("segundoApellido")]
        public string SegundoApellido { get; set; }

        [JsonPropertyName("fechaDeNacimiento")]
        public string FechaDeNacimiento { get; set; }
    }
}
