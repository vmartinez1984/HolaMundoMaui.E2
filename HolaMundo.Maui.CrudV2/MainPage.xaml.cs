using HolaMundo.Maui.CrudV1.Models;
using HolaMundo.Maui.CrudV1.Pages;
using HolaMundo.Maui.CrudV1.Services;

namespace HolaMundo.Maui.CrudV1
{
    public partial class MainPage : ContentPage
    {
        private readonly ProductoService productoService;

        public MainPage(ProductoService productoService)
        {
            InitializeComponent();
            this.productoService = productoService;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ActivityIndicator.IsVisible = true;
            CollectionView.ItemsSource = null;
            CollectionView.ItemsSource = 
                await productoService.ObtenerTodosAsync();
            ActivityIndicator.IsVisible = false;
        }

        private void ClickedAgregarNuevo(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AgregarProductoPage(productoService));
        }

        private void ChangedIrADetalles(object sender, SelectionChangedEventArgs e)
        {
            ProductoModel producto = (ProductoModel)e.CurrentSelection.FirstOrDefault();
            DetallesDelProductoPage detallesDelProductoPage = 
                new DetallesDelProductoPage(productoService);
            detallesDelProductoPage.BindingContext = producto;
            Navigation.PushAsync(detallesDelProductoPage);
        }

    }
}