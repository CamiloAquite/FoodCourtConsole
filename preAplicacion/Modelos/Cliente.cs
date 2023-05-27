
namespace preAplicacion.Modelos
{
    public class Cliente : TipoUsuario
    {
        public Cliente(int id, string nombre, int edad, string telefono, string correo) 
                        : base(id, nombre, edad, telefono, correo)
        {
        }
    }
}
