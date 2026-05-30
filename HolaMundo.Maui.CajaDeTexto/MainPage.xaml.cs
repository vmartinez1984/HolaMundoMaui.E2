namespace HolaMundo.Maui.CajaDeTexto
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void ClickedHolaMundo(object sender, EventArgs e)
        {
            string nombre = EntryNombre.Text;
            LabelSaludo.Text = "Hola" + nombre;
        }
    }
}
