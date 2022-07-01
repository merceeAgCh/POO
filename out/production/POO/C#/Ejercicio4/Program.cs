/* Brigada no. 7
 * Ramírez Bartolo Ignacio, Rosado Dominguez Jorge Kareem, López Ortega Diego, Paniagua Broca Eduardo Miguel, Torres Garcia Christian Ivan
 * 31/Dic/2021
 * Práctica 13, ejercicio 4
 * Clase Principal
 * Realizado por: Ramírez Bartolo Ignacio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            CompraPelicula peli = new CompraPelicula();
            CompraObra obra = new CompraObra();
            Registro_clientes registro = new Registro_clientes();
            Compra nuevaCompra = new Compra();
            string option;
            int clientID = -1;
            do
            {
                Console.WriteLine("Bienvenid@\n¿Ya se ha registrado?\na)Sí\nb)No\nc)Salir");
                option = Console.ReadLine();
                switch (option)
                {
                    case "a":
                        clientID = registro.Buscar_Cuenta();
                        if (clientID == -1)
                        {
                            Console.WriteLine("No ha sido posible encontrar su cuenta, presione enter para volver al menú principal");
                            Console.ReadLine();
                            Console.Clear();
                            option = "d";
                        }
                        else
                        {
                            Console.WriteLine("Bienvenid@ " + registro.registro_clientes[clientID].nombre_cliente + " presione enter para continuar");
                            Console.ReadLine();
                            Console.Clear();
                            do
                            {
                                Console.WriteLine("Seleccione la opción a realizar:\na)Ver catálogo de películas\nb)Ver catálogo de obras\nc)Realizar una compra\nd)Ver historial\ne)Salir");
                                option = Console.ReadLine();
                                switch (option)
                                {
                                    case "a":
                                        Console.Clear();
                                        nuevaCompra.catalogo.Mostrar_catalogo();
                                        Console.WriteLine("Presione enter para volver");
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    case "b":
                                        Console.Clear();
                                        nuevaCompra.cartelera.Mostrar_cartelera();
                                        Console.WriteLine("Presione enter para volver");
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    case "c":
                                        Console.Clear();
                                        int opcion;
                                        do
                                        {
                                            try
                                            {
                                                Console.WriteLine("¿Quiere comprar un ticket de pelicula u obra? (Ingrese el número)\n 1 = pelicula, 2 = obra");
                                                opcion = Convert.ToInt32(Console.ReadLine());
                                            }
                                            catch
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Ingrese una opcion correcta");
                                                opcion = 3;
                                            }
                                        } while (opcion != 1 && opcion != 2);
                                        switch (opcion)
                                        {
                                            case 1:
                                                peli.NuevaCompra(registro.registro_clientes, clientID, opcion);
                                                break;
                                            case 2:
                                                obra.NuevaCompra(registro.registro_clientes, clientID, opcion);
                                                break;
                                        }
                                        Console.WriteLine("Presione enter para volver");
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    case "d":
                                        Console.Clear();
                                        registro.registro_clientes[clientID].Imprimir_ticket();
                                        Console.WriteLine("Presione enter para volver");
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    case "e":
                                        Console.Clear();
                                        Console.WriteLine("Muchas gracias por usar nuestro programa, presione enter para salir");
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("No ha elegido una opción válida, presione enter para continuar");
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;
                                }
                            } while (option != "e");
                        }
                        break;
                    case "b":
                        registro.Nueva_cuenta();
                        Console.WriteLine("Su cuenta ha sido creada, por favor presione enter para volver al menú e iniciar sesión");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "c":
                        Console.WriteLine("Gracias, por usar el programa. Presione enter para salir");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("No ha elegido una opción válida, presione enter");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (option != "c");
        }
    }
}
