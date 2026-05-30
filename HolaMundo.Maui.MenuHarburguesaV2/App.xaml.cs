using HolaMundo.Maui.MenuHarburguesa.Pages;
using Microsoft.Extensions.DependencyInjection;

namespace HolaMundo.Maui.MenuHarburguesa
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new InicioDeSesionPage());
        }
    }
}