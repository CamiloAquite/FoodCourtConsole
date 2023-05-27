using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preAplicacion.Modelos
{
    public class Empleado : TipoUsuario
    {
        public string cargo;

        public string nombreRestaurante;

        public PropietarioRestaurante propietarioRestaurante;

        public Empleado(int id, string nombre, int edad, string telefono, string correo,string cargo, string nombreRestaurante)
                        : base(id, nombre, edad, telefono, correo)
        {
            this.cargo = cargo;
            this.nombreRestaurante = nombreRestaurante;
            
        }
    }
}
