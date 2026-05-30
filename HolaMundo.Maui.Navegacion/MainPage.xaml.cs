using HolaMundo.Maui.Navegacion.Pages;

namespace HolaMundo.Maui.Navegacion
{
    public partial class MainPage : ContentPage
    {      

        public MainPage()
        {
            InitializeComponent();
        }

      

        private void ClickedIrALaPagina1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage1());
        }

        private void ClickedIrALaPagina2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage2());
        }

        private void ClickedIrALaPagina3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NewPage3());
        }
    }
}
