namespace HolaMundo.Maui.Navegacion.Pages;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}

    private void ClickedRegresar(object sender, EventArgs e)
    {
		Navigation.PopModalAsync();
    }
}