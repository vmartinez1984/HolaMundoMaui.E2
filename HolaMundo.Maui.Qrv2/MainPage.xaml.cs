namespace HolaMundo.Maui.Qrv2
{
    public partial class MainPage : ContentPage
    {      

        public MainPage()
        {
            InitializeComponent();
        }               

        private void BarcodesDetected_LeerCodigo(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
        {
            string texto = e.Results.FirstOrDefault().Value;
        }
    }
}
