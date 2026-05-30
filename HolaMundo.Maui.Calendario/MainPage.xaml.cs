namespace HolaMundo.Maui.Calendario
{
    public partial class MainPage : ContentPage
    {        

        public MainPage()
        {
            InitializeComponent();
        }

        
        private void ClickedMostrarFecha(object sender, EventArgs e)
        {
            DateTime? fecha = DatePicker.Date;
            Label.Text = fecha.ToString();
        }
    }
}
