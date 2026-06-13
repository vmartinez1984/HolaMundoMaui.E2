using HolaMundo.Maui.Mvvm.ListaV1.Models;
using HolaMundo.Maui.Mvvm.ListaV1.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace HolaMundo.Maui.Mvvm.ListaV1.ViewModels
{
    public class PizzaViewModel: INotifyPropertyChanged
    {
        private readonly PizzaService _pizzaService;

        #region Propiedades
        private List<PizzaModel> pizzas;

        public List<PizzaModel> Pizzas
        {
            get { return pizzas; }
            set { 
                pizzas = value;
                OnPropertyChanged();
            }
        }

        private PizzaModel pizzaSeleccionada;

        public PizzaModel PizzaSeleccionada
        {
            get { return pizzaSeleccionada; }
            set { 
                pizzaSeleccionada = value;
                OnPropertyChanged();
            }
        }

        #endregion


        #region Commands
        public ICommand  SeleccionarPizzaCommand { get; set; }
        public void SeleccionarPizza()
        {
            //Aqui es donde se hace la oparacion
            //Enviamos a la págian siguiente
            var pizza = this.PizzaSeleccionada;
        }
        #endregion

        public PizzaViewModel(PizzaService pizzaService)
        {
            Pizzas = new List<PizzaModel>();
            PizzaSeleccionada = new PizzaModel();
            //Enlaza el comando con la función
            SeleccionarPizzaCommand = new Command(SeleccionarPizza);

            this._pizzaService = pizzaService;
        }

        public async Task ObteneryAsignarPizzas()
        {
            Pizzas = await _pizzaService.ObtenerAsync();
        }

        #region PropertyChanged
        //2.- Implementación de la interfaz 
        public event PropertyChangedEventHandler? PropertyChanged;

        //3.- Evento a la escucha que hace los cambios
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}