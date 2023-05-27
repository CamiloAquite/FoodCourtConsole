using preAplicacion.Modelos;
using preAplicacion.Vistas.VistasModelos;

namespace preAplicacion.Services
{
    public class PropietarioRestauranteServices
    {
        public PropietarioRestaurante propietarioRestaurante;

        public PropietarioRestauranteServices()
        { 
        }
        
        public int asignarEmpleadoAPropietarioRestaurante(PropietarioVM propietarioVM) {

            //Creamos entidad
            PropietarioRestaurante propietarioRestaurante = new PropietarioRestaurante(
                id: propietarioVM.idPropietario,
                nombre: propietarioVM.nombrePropietario,
                edad:propietarioVM.edadPropietario,
                telefono:propietarioVM.telefonoPropietario,
                correo:propietarioVM.correoPropietario,
                cargo:propietarioVM.cargoPropietario,
                nombreRestaurante:propietarioVM.nombreRestaurantePropietario,
                empleado:propietarioVM.empleado

                );
            //validar espacios en blanco
            if (propietarioRestaurante.nombre == null)
            {
                Console.WriteLine("El nombre no puede estar vacio");
            }
            else if (propietarioRestaurante.id == null)
            {
                Console.WriteLine($"El usuario debe tener un ID");
            }

            return 0;
        }

    }
}
