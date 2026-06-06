using HolaMundo.Maui.Coleccion.Services;

namespace HolaMundo.Maui.Coleccion
{
    public partial class MainPage : ContentPage
    {
        private readonly PizzasService pizzasService;

        public MainPage(PizzasService pizzasService)
        {
            InitializeComponent();
            this.pizzasService = pizzasService;
            ObtenerDatos();
        }

        private async void ObtenerDatos()
        {
            var pizzas = await pizzasService.ObtenerTodosAsync();
            CollectionView.ItemsSource = pizzas;
        }
    }
}