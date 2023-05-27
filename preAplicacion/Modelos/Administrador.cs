
namespace preAplicacion.Modelos
{
    public class Administrador : TipoUsuario
    {   
        public string cargo;

        public Administrador(int id, string nombre, int edad, string telefono, string correo, string cargo)
            : base(id, nombre, edad, telefono, correo)
        {
            this.cargo = cargo;
        }

    }
}
