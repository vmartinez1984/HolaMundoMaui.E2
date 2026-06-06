namespace HolaMundo.Maui.Coleccion.Models
{
    public class PizzaModel
    {
        public PizzaModel(int id, string nombre, string descripcion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Ruta { get; set; }
    }
}