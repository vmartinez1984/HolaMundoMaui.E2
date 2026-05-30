

using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace HolaMundo.Suma
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

       
        private void ClickedSumarNumeros(object sender, EventArgs e)
        {

            double numero1 = double.Parse(EntryNumero1.Text);
            double numero2 = double.Parse(EntryNumero2.Text);
            double resultado = numero1 + numero2;

            //LAbelResultado.Text = resultado.ToString();
            Toast.Make("El resultado: " + resultado, ToastDuration.Long).Show();
        }

    }
}
