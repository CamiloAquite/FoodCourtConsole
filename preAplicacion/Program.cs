

using preAplicacion.Modelos;
using preAplicacion.Vistas.VistasModelos;
using preAplicacion.Contoladores;

public class Program
{
    public static void Main(string[] args)
    {
            bool V = true;

        do
        {
            Console.WriteLine("          **************************************");
            Console.WriteLine("            BIENVENIDOS A LA PLAZOLETA ATALAYA");
            Console.WriteLine("          **************************************");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Por favor ingrese la opcion que desea:");
            Console.WriteLine("1. Para crear el usuario administrador de la plazoleta.");
            Console.WriteLine("2. Para crear el usuario propietario de restaurante.");
            Console.WriteLine("3. Para crear el usuario cliente.");
            Console.WriteLine("4. Para salir del menu.");
            Console.WriteLine("");
            var opc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch (opc)
            {
                case 1:
                    var id = 1;
                    var nombre = "Blanca Hernandez";
                    var edad = 56;
                    var telefono = "3208543169";
                    var correo = "Correo.correo@correo.com";
                    var cargo = "Administrador";

                    AdministradorController administradorController = new();
                    administradorController.Crear(id, nombre, edad, telefono, correo, cargo);
                    Console.WriteLine();

                    break;
                case 2:
                    Empleado empleado1 = new Empleado(1, "Camilo Aquite", 24, "3208545522", "Correo@correo.com", "Cajero", "El restaurante Colombiano");
                    Empleado empleado2 = new Empleado(2, "Sebastian Aquite", 21, "3208541422", "Correo1@correo.com", "Mesero(a)", "El restaurante Colombiano");
                    Empleado empleado3 = new Empleado(3, "Camila Gutierrez", 26, "3208316038", "Correo2@correo.com", "Mesero(a)", "El restaurante Colombiano");
                    Empleado empleado4 = new Empleado(4, "Natalia Garcia", 23, "3204522145", "Correo3@correo.com", "Cocinero(a)", "El restaurante Colombiano");

                    PropietarioVM propietarioRestaurante = new(1, "Paola P", 48, "3208543169", "Correo@correo.com", "Propietario",
                                                                                               "El restaurante Colombiano",
                        new List<Empleado>
                        {
                            empleado1,
                            empleado2,
                            empleado3,
                            empleado4
                        }
                        );

                    PropietarioRestauranteController propietarioController = new PropietarioRestauranteController();
                    propietarioController.crearPropietario(propietarioRestaurante);

                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Por favor ingrese el id del usuario:");
                    var idCliente = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Por favor ingrese el nombre del usuario:");
                    var nombreCliente = Console.ReadLine();
                    Console.WriteLine("Por favor ingrese la edad del usuario:");
                    var edadCliente = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Por favor ingrese el telefono del usuario:");
                    var telefonoCliente = Console.ReadLine();
                    Console.WriteLine("Por favor ingrese el correo del usuario");
                    var correoCliente = Console.ReadLine();

                    ClienteController clienteController = new ClienteController();
                    clienteController.crearCliente(idCliente, nombreCliente, edadCliente, telefonoCliente, correoCliente);
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Hasta luego y muchas gracias");
                    V = false;
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("!!! La opcion ingresada es incorrecta, debes ingresar un numero entre el 1 y 4 !!!");
                    break;
                    Console.WriteLine();

            }

        } while (V);  
 
    }
}