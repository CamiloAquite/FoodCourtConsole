
namespace preAplicacion.Modelos
{
    public class PropietarioRestaurante : TipoUsuario
    {
        public string cargo;

        public string nombreRestaurante;

        public List<Empleado> empleado;

        public PropietarioRestaurante(int id, string nombre, int edad, string telefono, string correo, string cargo, 
                                      string nombreRestaurante, List<Empleado> empleado) : base(id, nombre, edad, telefono, correo)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            this.telefono = telefono;
            this.correo = correo;
            this.cargo = cargo;
            this.nombreRestaurante = nombreRestaurante;
            this.empleado = empleado;
        }
    }
}
