using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using HolaMundo.Maui.InicioDeSesion.Services;

namespace HolaMundo.Maui.InicioDeSesion
{
    public partial class MainPage : ContentPage
    {
        private readonly Servicio _servicio;

        public MainPage()
        {
            InitializeComponent();
            this._servicio = new Servicio();
        }

        private async void ClickedIniciarSesion(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                string correo = EntryCorreo.Text;
                string contrasenia = EntryContrasenia.Text;
                //llenamo el objeto

                //Enviar los datos al servicio
                ActivityIndicator.IsRunning = true;
                string respuesta = await _servicio.InicaiarSesion(correo, contrasenia);
                if (string.IsNullOrEmpty(respuesta))
                {
                   await Toast.Make("Credenciales no validas", ToastDuration.Short).Show();
                }
                else
                {
                    await Toast.Make("Bienvenido", ToastDuration.Short).Show();
                }
                ActivityIndicator.IsRunning = false;
            }
            else
            {
              await  Toast.Make("Ingrese las credenciales", ToastDuration.Short).Show();
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(EntryCorreo.Text))
                return false;
            if (string.IsNullOrEmpty(EntryContrasenia.Text))
                return false;

            return true;
        }
                
    }
}
