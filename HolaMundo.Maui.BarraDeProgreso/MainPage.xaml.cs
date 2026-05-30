namespace HolaMundo.Maui.BarraDeProgreso
{
    public partial class MainPage : ContentPage
    {        
        bool estaActivado = false;
        public MainPage()
        {
            InitializeComponent();
        }
                

        private void ClikedProcesarDatos(object sender, EventArgs e)
        {
            if (estaActivado)
            {
                estaActivado = false;
                ActivityIndicator.IsRunning = true;
            }
            else
            {
                estaActivado = true;
                ActivityIndicator.IsRunning = false;
            }
        }
    }
}
