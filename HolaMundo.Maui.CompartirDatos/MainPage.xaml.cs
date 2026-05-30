using HolaMundo.Maui.CompartirDatos.Pages;

namespace HolaMundo.Maui.CompartirDatos
{
    public partial class MainPage : ContentPage
    {       
        public MainPage()
        {
            InitializeComponent();
        }               

        private void ClickedIrALaPagina1(object sender, EventArgs e)
        {
            string nombre = "Pancho";

            Navigation.PushAsync(new NewPage1(nombre));
        }

        private void ClickedIrALaPagina2(object sender, EventArgs e)
        {
            string nombre = "Pancho";
            NewPage2 newPage2 = new NewPage2();
            newPage2.BindingContext = nombre;
            Navigation.PushAsync(newPage2);
        }
    }
}