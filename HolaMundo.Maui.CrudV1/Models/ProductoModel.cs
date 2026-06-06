namespace HolaMundo.Maui.CrudV1.Models
{
    public class ProductoModel
    {
        public string Encodedkey { get; set; } = Guid.NewGuid().ToString();
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
