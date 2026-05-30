namespace HolaMundo.Maui.CompartirDatos.Pages;

public partial class NewPage1 : ContentPage
{
	private string Nombre;
	public NewPage1(string nombre)
	{
		InitializeComponent();
		Nombre = nombre;

		Label.Text = Nombre;
	}
}