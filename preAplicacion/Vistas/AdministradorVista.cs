

namespace preAplicacion.Vistas
{
    public class AdministradorVista
    {
        public void mostrarUsuarioAdministrador(int id, string nombre, int edad, string telefono, string correo, string cargo)
        {
            Console.WriteLine();
            Console.WriteLine("Él nombre del usuario registrado es " + nombre + ", con id " + id + ", telefono es " +
                               telefono + " y su correo es " + correo + ".");
        }

        public void lanzarError()
        {
            Console.WriteLine("Error....");
        }
    }
}