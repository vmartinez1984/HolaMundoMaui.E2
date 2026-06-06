using SQLite;

namespace HolaMundo.Maui.CrudV1.Models
{
    public class ProductoModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Encodedkey { get; set; } = Guid.NewGuid().ToString();
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //public bool EstaSincornizado { get; set; } = false;
    }
}
