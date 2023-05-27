

namespace preAplicacion.Modelos
{
    public class TipoUsuario
    {
        public int id;

        public string nombre;

        public int edad;

        public string telefono;

        public string correo;

        public TipoUsuario(int id, string nombre, int edad, string telefono, string correo)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            this.telefono = telefono;
            this.correo = correo;
        }

    }
}
