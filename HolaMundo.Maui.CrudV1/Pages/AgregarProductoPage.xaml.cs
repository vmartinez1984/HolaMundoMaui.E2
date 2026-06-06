using HolaMundo.Maui.CrudV1.Models;
using HolaMundo.Maui.CrudV1.Services;

namespace HolaMundo.Maui.CrudV1.Pages;

public partial class AgregarProductoPage : ContentPage
{
    private readonly ProductoService service;

    public AgregarProductoPage(ProductoService service)
    {
        InitializeComponent();
        this.service = service;
    }

    private async void ClickedGuardar(object sender, EventArgs e)
    {
        if (EsValido())
        {
            ProductoModel producto = ObtenerProducto();
            await service.AgregarAsync(producto);
            //Notificar que se guardo
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
            Descripcion = descripcion
        };

        return producto;
    }

    private bool EsValido()
    {
        return true;
    }
}