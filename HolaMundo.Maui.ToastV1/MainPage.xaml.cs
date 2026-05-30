using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace HolaMundo.Maui.ToastV1
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private async void ClickedShowToast(object sender, EventArgs e)
        {
            //if (DeviceInfo.Platform == DevicePlatform.WinUI)
            //    await DisplayAlertAsync("Titulo", "Mensaje", "Ok");
            //else
             await  Toast.Make("Hola mundo", ToastDuration.Short).Show();
        }
    }
}
