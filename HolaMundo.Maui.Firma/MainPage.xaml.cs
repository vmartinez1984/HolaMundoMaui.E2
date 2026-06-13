namespace HolaMundo.Maui.Firma
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Clicked_GuardarFirma(object sender, EventArgs e)
        {
            var stream = await DrawingView.GetImageStream(800, 400);
            //obtner el path actual
            string fileName = Path.Combine(FileSystem.AppDataDirectory, "firma.png");

            string path = "C:\\Users\\ahal_\\source\\repos\\HolaMundoMaui.E2\\HolaMundo.Maui.Firma\\" + Guid.NewGuid() + ".png";
            using var fileStream = File.Create(path);
                      

            await stream.CopyToAsync(fileStream);            
        }
    }
}
