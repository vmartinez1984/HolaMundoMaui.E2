namespace HolaMundo.Maui.Bindingv1
{
    public partial class MainPage : ContentPage
    {
        private string texto;

        public string Texto
        {
            get { return texto; }
            set
            {
                OnPropertyChanged();
                texto = value;
            }
        }


        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
