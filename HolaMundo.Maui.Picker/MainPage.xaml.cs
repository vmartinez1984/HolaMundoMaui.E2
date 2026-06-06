using HolaMundo.Maui.Picker.Service;

namespace HolaMundo.Maui.Picker
{
    public partial class MainPage : ContentPage
    {
        private readonly ServiceVianey serviceVianey;

        public MainPage(ServiceVianey serviceVianey)
        {
            InitializeComponent();
            this.serviceVianey = serviceVianey;
            cargarDatos();
        }

        private async void cargarDatos()
        {
            var lista = await serviceVianey.ObtenerTodosAsync();
            //lista.ForEach(item =>
            //{
            //    Picker.Items.Add(item.Nombre);
            //});
            Picker.ItemsSource = lista;
        }

        private void seleccionarFruta(object sender, EventArgs e)
        {

        }
    }
}