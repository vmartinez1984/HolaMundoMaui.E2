namespace HolaMundo.Maui.CompartirDatos.Pages;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{ 
		base.OnAppearing();
		string cadena = BindingContext as string;
		Label.Text = cadena;		
	}
}