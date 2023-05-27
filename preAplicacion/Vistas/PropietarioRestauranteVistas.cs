using preAplicacion.Modelos;
using preAplicacion.Vistas.VistasModelos;

namespace preAplicacion.Vistas
{
    public class PropietarioRestauranteVistas
    {

        public void mostrarPropietario(PropietarioVM propietarioVM)
        {
            Console.WriteLine();

            Console.WriteLine("Se guardo el propietario "+propietarioVM.nombrePropietario+" del restaurante "+ propietarioVM.nombreRestaurantePropietario + ".");

            Console.WriteLine();

            Console.WriteLine("El empleado con id " + propietarioVM.empleado[0].id + " se creo con nombre "+ propietarioVM.empleado[0].nombre + ", cargo "
                                + propietarioVM.empleado[0].cargo + " y trabaja para el restaurante " + propietarioVM.empleado[0].nombreRestaurante + ".");
            
            Console.WriteLine("El empleado con id " + propietarioVM.empleado[1].id + " se creo con nombre " + propietarioVM.empleado[1].nombre + ", cargo "
                                + propietarioVM.empleado[1].cargo + " y trabaja para el restaurante " + propietarioVM.empleado[1].nombreRestaurante + ".");

            Console.WriteLine("El empleado con id " + propietarioVM.empleado[2].id + " se creo con nombre " + propietarioVM.empleado[2].nombre + ", cargo "
                                + propietarioVM.empleado[2].cargo + " y trabaja para el restaurante " + propietarioVM.empleado[2].nombreRestaurante + ".");

            Console.WriteLine("El empleado con id " + propietarioVM.empleado[3].id + " se creo con nombre " + propietarioVM.empleado[3].nombre + ", cargo "
                                + propietarioVM.empleado[3].cargo + " y trabaja para el restaurante " + propietarioVM.empleado[3].nombreRestaurante + ".");

        }

        public void lanzarError()
        {
            Console.WriteLine("Error....");
        }
    }
}
