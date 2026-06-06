namespace HolaMundo.Maui.Picker.Models
{
    public class FrutaModel
    {        
        public FrutaModel(int v1, string v2)
        {
            this.Id = v1;
            this.Nombre = v2;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
