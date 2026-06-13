using HolaMundo.Maui.MvvmV1.ViewModels;

namespace HolaMundo.Maui.MvvmV1
{
    public partial class MainPage : ContentPage
    {        

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ClienteViewModel();
        }

    }
}
