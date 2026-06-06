using HolaMundo.Maui.CrudV1.Models;
using HolaMundo.Maui.CrudV1.Services;

namespace HolaMundo.Maui.CrudV1.Pages;

public partial class DetallesDelProductoPage : ContentPage
{
    private readonly ProductoService service;
    ProductoModel producto;
    public DetallesDelProductoPage(ProductoService service)
    {
        InitializeComponent();
        this.service = service;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is not null)
        {
            producto = (ProductoModel)BindingContext;           
            ColocarDatosAlFormulario(producto);
        }
    }

    private void ColocarDatosAlFormulario(ProductoModel producto)
    {
        LabelNombre.Text = producto.Nombre;
        LabelDescripcion.Text = producto.Descripcion;
    }

    private void ClickedIrAEditar(object sender, EventArgs e)
    {
        EditarProductoPage editarProductoPage = new EditarProductoPage(service);
        editarProductoPage.BindingContext = producto;
        Navigation.PushModalAsync(editarProductoPage);
    }
}