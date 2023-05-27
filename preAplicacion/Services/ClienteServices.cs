using preAplicacion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preAplicacion.Services
{
    public class ClienteServices
    {
        public Cliente cliente;

        public ClienteServices()
        {

        }

        public int crearCliente(int id, string nombre, int edad, string telefono, string correo)
        {
            //Creamos una entidad
            Cliente cliente = new Cliente(id, nombre, edad, telefono, correo);

            //validar espacios en blanco

            if(cliente.nombre == null)
            {
                Console.WriteLine("El nombre del cliente no puede estar vacio.");
            }else if (cliente.edad == null)
            {
                Console.WriteLine("El cliente debe tener edad.");
            }else if(cliente.telefono == null)
            {
                Console.WriteLine("El cliente debe tener un telefono.");
            }else if (cliente.correo==null)
            {
                Console.WriteLine("El cliente debe tener un correo.");
            }

            return 0;
        }

    }
}
