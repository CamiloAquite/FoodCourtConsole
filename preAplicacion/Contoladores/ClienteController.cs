using preAplicacion.Services;
using preAplicacion.Vistas;


namespace preAplicacion.Contoladores
{
    public class ClienteController
    {
        public ClienteServices clienteServices;
        public ClienteVistas clienteVistas;

        public ClienteController()
        {
            this.clienteServices = new ClienteServices();
            this.clienteVistas = new ClienteVistas();
        }

        public void crearCliente(int id, string nombre, int edad, string telefono, string correo) 
        {
            int resultado = this.clienteServices.crearCliente(id, nombre, edad, telefono, correo);

            if (resultado == 0)
            {
                this.clienteVistas.mostrarcliente(nombre, telefono, correo);
            }else
            {
                this.clienteVistas.lanzarError();
            }

        }
    }
}
