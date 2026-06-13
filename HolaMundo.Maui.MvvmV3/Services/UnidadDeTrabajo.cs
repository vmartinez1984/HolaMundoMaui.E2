namespace HolaMundo.Maui.MvvmV1.Services
{
    public class UnidadDeTrabajo
    {
        public ClienteService Cliente { get; set; }
        //mas servicios ....

        public UnidadDeTrabajo(ClienteService clienteService)
        {
            Cliente = clienteService;
        }
    }
}
