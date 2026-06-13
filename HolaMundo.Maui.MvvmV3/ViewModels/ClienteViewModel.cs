using CommunityToolkit.Maui.Alerts;
using HolaMundo.Maui.MvvmV1.Models;
using HolaMundo.Maui.MvvmV1.Pages;
using HolaMundo.Maui.MvvmV1.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace HolaMundo.Maui.MvvmV1.ViewModels
{
    //Es el equicvalente al controlador de Mvc
    public class ClienteViewModel : INotifyPropertyChanged //1 herede de esta interfaz
    {
        private readonly INavigation _navigation;
        private readonly UnidadDeTrabajo _unidadDeTrabajo;
        #region Propiedades
        private ClienteModel clienteModel;

        public ClienteModel ClienteModel
        {
            get { return clienteModel; }
            set
            {
                clienteModel = value;
                OnPropertyChanged();//4.- colocar el metodo de notificación de cambio
            }
        }

        private bool estaCargando;

        public bool EstaCargando
        {
            get { return estaCargando; }
            set
            {
                estaCargando = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Commands
        //A declara el command
        public ICommand Command { get; set; }

        /// <summary>
        /// Función que procesara los datos
        /// </summary>
        public void Guardar()
        {
            //Esto se persiste por un servicio o en base de datos
            string data = $"{ClienteModel.Nombre}";
            //Notificación de acción
            Toast.Make("Datos procesados").Show();
            //Navegacióna otra Page
            _navigation.PushAsync(new NewPage1());
        }
        #endregion

        public ClienteViewModel(INavigation navigation, UnidadDeTrabajo unidadDeTrabajo)
        {
            ClienteModel = new ClienteModel();
            EstaCargando = false;

            //C Enlace de command con la función
            Command = new Command(Guardar);
            _navigation = navigation;
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public async Task<ClienteModel> ObtenerAsync()
        {
            this.ClienteModel = await _unidadDeTrabajo.Cliente.ObtenerAsync();
            return this.ClienteModel;
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
