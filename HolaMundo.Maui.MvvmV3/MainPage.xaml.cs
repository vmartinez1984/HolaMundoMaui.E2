using HolaMundo.Maui.MvvmV1.Services;
using HolaMundo.Maui.MvvmV1.ViewModels;

namespace HolaMundo.Maui.MvvmV1
{
    public partial class MainPage : ContentPage
    {
        ClienteViewModel clienteViewModel;
        public MainPage(UnidadDeTrabajo unidadDeTrabajo)
        {
            InitializeComponent();
            clienteViewModel = new ClienteViewModel(Navigation, unidadDeTrabajo);
            BindingContext = clienteViewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            clienteViewModel.EstaCargando = true;
            await clienteViewModel.ObtenerAsync();
            clienteViewModel.EstaCargando = false;
        }

    }
}
