using preAplicacion.Modelos;

namespace preAplicacion.Vistas
{
    public class ClienteVistas
    {
        public void mostrarcliente(string nombre, string telefono, string correo)
        {
            Console.WriteLine();
            Console.WriteLine("Se creo el cliente con nombre " + nombre + ", con telefono "
                                + telefono + " y correo electrónico " + correo + ".");
        }

        public void lanzarError()
        {
            Console.WriteLine("Error....");
        }
    }
}
