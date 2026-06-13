namespace HolaMundo.Maui.Gps
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }
                

        private async void ClickedObtenerGps(object sender, EventArgs e)
        {
            var request = new GeolocationRequest(GeolocationAccuracy.Medium);
            var location = await Geolocation.Default.GetLocationAsync(request);

            Label.Text = $"Latidud {location.Latitude}, Longitud {location.Longitude}";
        }
    }
}
