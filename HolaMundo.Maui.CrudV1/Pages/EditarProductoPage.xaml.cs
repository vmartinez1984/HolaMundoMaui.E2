using HolaMundo.Maui.CrudV1.Models;
using HolaMundo.Maui.CrudV1.Services;

namespace HolaMundo.Maui.CrudV1.Pages;

public partial class EditarProductoPage : ContentPage
{
    string productoEncodedkey;
    private readonly ProductoService service;

    public EditarProductoPage(ProductoService service)
	{
		InitializeComponent();
        this.service = service;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is not null)
        {
            ProductoModel producto = (ProductoModel)BindingContext;
            productoEncodedkey = producto.Encodedkey;
            ColocarDatosAlFormulario(producto);
        }
    }

    private void ColocarDatosAlFormulario(ProductoModel producto)
    {
        EntryNombre.Text = producto.Nombre;
        EntryDescripcion.Text = producto.Descripcion;
    }

    private async void ClickedGuardar(object sender, EventArgs e)
    {
        if (EsValido())
        {
            ProductoModel producto = ObtenerProducto();
            await service.ActualizarAsync(producto);
            //Notificacion de exito
            //Regresar a la lista
            await Navigation.PopModalAsync();
        }
    }

    private ProductoModel ObtenerProducto()
    {
        string nombre = EntryNombre.Text;
        string descripcion = EntryDescripcion.Text;
        ProductoModel producto = new ProductoModel
        {
            Nombre = nombre,
            Descripcion = descripcion,
            Encodedkey = productoEncodedkey
        };

        return producto;
    }

    private bool EsValido()
    {
        return true;
    }

    private void ClickedCancelar(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}