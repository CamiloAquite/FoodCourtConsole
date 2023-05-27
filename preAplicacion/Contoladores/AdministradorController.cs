using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using preAplicacion.Modelos;
using preAplicacion.Services;
using preAplicacion.Vistas;

namespace preAplicacion.Contoladores
{
    public class AdministradorController
    {
        private AdministradorServices administradorServices;
        private AdministradorVista administradorVista;
        public Administrador administrador;

        public AdministradorController()
        {
            //Composicion
            this.administradorServices = new AdministradorServices();
            this.administradorVista = new AdministradorVista();

        }

        public void Crear(int id, string nombre, int edad,
                          string telefono, string correo, string cargo)
        {
            //se desarrolla logica 
            int resultado = this.administradorServices.Crear(id, nombre, edad, telefono, correo, cargo);

            if(resultado == 0)
            {
                this.administradorVista.mostrarUsuarioAdministrador(id, nombre, edad, telefono, correo, cargo);
            }
            else
            {
                this.administradorVista.lanzarError();
            }
        }


    


    }
}
