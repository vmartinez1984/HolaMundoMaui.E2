using ZXing.Net.Maui;

namespace HolaMundo.Maui.Qr
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        //private void BarcodeDetected(object sender, BarcodeDetectionEventArgs e)
        //{
        //     Label.Text = e.Results.FirstOrDefault().Value;
        //}

        private void BarcodeDetected(object sender, BarcodeDetectionEventArgs e)
        {

            //MainThread.BeginInvokeOnMainThread(async () =>
            //{
            //    Label.Text = e.Results.FirstOrDefault().Value;
            //});

        }

        private void Limpiar_Clicked(object sender, EventArgs e)
        {
            drawingView.Lines.Clear();
        }

        private async void Guardar_Clicked(object sender, EventArgs e)
        {
            using var stream = await drawingView.GetImageStream(
                desiredWidth: 800,
                desiredHeight: 400);

            string fileName = Path.Combine(
                FileSystem.AppDataDirectory,
                "firma.png");

            using var fileStream = File.Create(fileName);

            await stream.CopyToAsync(fileStream);

            await DisplayAlertAsync(
                "Guardado",
                $"Firma guardada en:\n{fileName}",
                "OK");
        }
    }
}
