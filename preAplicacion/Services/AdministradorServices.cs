using preAplicacion.Modelos;


namespace preAplicacion.Services
{
    internal class AdministradorServices
    {
        public Administrador administrador;

        public AdministradorServices()
        {
        }

        public int Crear(int id, string nombre, int edad, 
                          string telefono, string correo, string cargo)
        {   
            //Creamos una entidad
            Administrador administrador = new( id, nombre, edad, telefono, correo, cargo);

            //validar espacios en blanco
            if (administrador.nombre == null) { 
                Console.WriteLine("El nombre no puede estar vacio");
            }
            else if (administrador.id==null)
            {
                Console.WriteLine("El usuario debe tener un ID");
            }

            return 0;
        }
        //Imprimir
   

    }
}
