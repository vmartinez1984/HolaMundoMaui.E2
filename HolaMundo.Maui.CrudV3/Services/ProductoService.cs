using HolaMundo.Maui.CrudV1.Models;
using SQLite;

namespace HolaMundo.Maui.CrudV1.Services
{
    public class ProductoService
    {
        private readonly SQLiteAsyncConnection _dbase;
        public ProductoService(string dbPath)
        {
            _dbase = new SQLiteAsyncConnection(dbPath);
            _dbase.CreateTableAsync<ProductoModel>().Wait();
        }

        public async Task<List<ProductoModel>> ObtenerTodosAsync()
        {
            List<ProductoModel> lista = await _dbase.Table<ProductoModel>().ToListAsync();

            return lista;
        }

        public async Task<string> AgregarAsync(ProductoModel producto)
        {
            await _dbase.InsertAsync(producto);

            return producto.Encodedkey;
        }

        internal async Task ActualizarAsync(ProductoModel producto)
        {
            var productoOriginal = await _dbase.Table<ProductoModel>()
                .Where(x => x.Encodedkey == producto.Encodedkey)
                .FirstOrDefaultAsync();
            productoOriginal.Nombre = producto.Nombre;
            productoOriginal.Descripcion = producto.Descripcion;

            await _dbase.UpdateAsync(productoOriginal);
        }
    }
}
