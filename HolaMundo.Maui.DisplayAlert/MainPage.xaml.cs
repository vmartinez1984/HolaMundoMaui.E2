namespace HolaMundo.Maui.DisplayAlert
{
    public partial class MainPage : ContentPage
    {        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            DisplayAlertAsync("Titulo", "Mensaje", "Ok");
        }
    }
}
