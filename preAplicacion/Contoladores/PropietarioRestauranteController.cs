using preAplicacion.Modelos;
using preAplicacion.Services;
using preAplicacion.Vistas;
using preAplicacion.Vistas.VistasModelos;


namespace preAplicacion.Contoladores
{
    public class PropietarioRestauranteController
    {
        public PropietarioRestauranteServices propietarioRestauranteServices;
        public PropietarioRestauranteVistas propietarioRestauranteVistas;

        public PropietarioRestauranteController()
        {
            this.propietarioRestauranteServices = new PropietarioRestauranteServices();
            this.propietarioRestauranteVistas=new PropietarioRestauranteVistas();

        }

        public void crearPropietario( PropietarioVM propietarioVM)
        {
            int result =this.propietarioRestauranteServices.asignarEmpleadoAPropietarioRestaurante(propietarioVM);

            if (result == 0)
            {
                this.propietarioRestauranteVistas.mostrarPropietario(propietarioVM);
            }
            else
            {
                this.propietarioRestauranteVistas.lanzarError();
            }
        }

    }
}
