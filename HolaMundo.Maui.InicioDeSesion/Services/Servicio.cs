namespace HolaMundo.Maui.InicioDeSesion.Services
{
    public class Servicio
    {
        public async Task<string> InicaiarSesion(string correo, string contrasenia)
        {
            await Task.Delay(3000);
            if(correo == "victor@correo.com" &&  contrasenia == "123456")
            {
                return "Bienvenido";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
