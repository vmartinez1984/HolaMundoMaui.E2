using CommunityToolkit.Maui.Alerts;
using HolaMundo.Maui.MvvmV1.Models;
using HolaMundo.Maui.MvvmV1.Pages;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace HolaMundo.Maui.MvvmV1.ViewModels
{
    //Es el equicvalente al controlador de Mvc
    public class ClienteViewModel : INotifyPropertyChanged //1 herede de esta interfaz
    {
        private readonly INavigation _navigation;
        #region Models
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
        #endregion

        #region Commands
        //A declara el command
        public ICommand Command { get; set; }

        /// <summary>
        /// Funcio que procesara los datos
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

        public ClienteViewModel(INavigation navigation)
        {
            //Los datos pueden venir de un servicio o base de datos
            ClienteModel = new ClienteModel { Nombre = "Pancho", Apellidos = "Pantera" };
            //C Enlace de command con la función
            Command = new Command(Guardar);
            _navigation = navigation;           
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
