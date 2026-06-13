using HolaMundo.Maui.Mvvm.ListaV1.Services;
using HolaMundo.Maui.Mvvm.ListaV1.ViewModels;

namespace HolaMundo.Maui.Mvvm.ListaV1
{
    public partial class MainPage : ContentPage
    {
        PizzaViewModel PizzaViewModel;

        public MainPage(PizzaService pizzaService)
        {
            InitializeComponent();
            PizzaViewModel = new PizzaViewModel(pizzaService);
            BindingContext = PizzaViewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await PizzaViewModel.ObteneryAsignarPizzas();
        }

        private void SelectionChanged_Pizzas(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
