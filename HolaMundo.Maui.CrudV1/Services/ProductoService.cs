using HolaMundo.Maui.CrudV1.Models;

namespace HolaMundo.Maui.CrudV1.Services
{
    public class ProductoService
    {
        List<ProductoModel> productos;

        public ProductoService()
        {
            productos = new List<ProductoModel>();
            productos.Add(new ProductoModel
            {
                Encodedkey = Guid.NewGuid().ToString(),
                Nombre = "Mexicana",
                Descripcion = "Carne con jalapeño"
            });
            productos.Add(new ProductoModel
            {
                Encodedkey = Guid.NewGuid().ToString(),
                Nombre = "Hawaiina",
                Descripcion = "JAmón y piña"
            });
        }

        public async Task<List<ProductoModel>> ObtenerTodosAsync()
        {
            await Task.Delay(1500);
            return productos;
        }

        public async Task<string> AgregarAsync(ProductoModel producto)
        {
            await Task.Delay(1500);            
            productos.Add(producto);

            return producto.Encodedkey;
        }

        internal async Task ActualizarAsync(ProductoModel producto)
        {
            var productoOriginal = productos
                .Where(x => x.Encodedkey == producto.Encodedkey)
                .FirstOrDefault();
            productoOriginal.Nombre = producto.Nombre;
            productoOriginal.Descripcion = producto.Descripcion;
        }
    }
}
