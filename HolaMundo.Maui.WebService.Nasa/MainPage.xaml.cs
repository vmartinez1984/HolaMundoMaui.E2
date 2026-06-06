using HolaMundo.Maui.WebService.Nasa.Models;
using HolaMundo.Maui.WebService.Nasa.Services;

namespace HolaMundo.Maui.WebService.Nasa
{
    public partial class MainPage : ContentPage
    {
        private readonly NasaService nasaService;

        public MainPage(NasaService nasaService)
        {
            InitializeComponent();
            this.nasaService = nasaService;
        }

        private async void ClickedCargarDatos(object sender, EventArgs e)
        {
            ActivityIndicator.IsVisible = true;
            FotoDelDiaModel fotoDelDia = await nasaService.ObtenerLaFotoDelDiaAsync();
            if (fotoDelDia is not null)
            {
                LabelTitulo.Text = fotoDelDia.Titulo;
                LabelExplicacion.Text = fotoDelDia.Explanation;
                LabelFecha.Text = fotoDelDia.Fecha;
                Image.Source = fotoDelDia.Url;
            }
            ActivityIndicator.IsVisible = false;
        }
    }
}
