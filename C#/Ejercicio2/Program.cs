/* Brigada no. 7
 * Ramírez Bartolo Ignacio, Rosado Dominguez Jorge Kareem, López Ortega Diego, Paniagua Broca Eduardo Miguel, Torres Garcia Christian Ivan
 * 31/dic/2021
 * Práctica 13, ejercicip 2: Productos
 * Clase Program
 * Realizado por: Jorge Kareem Rosado Domingue
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            int escoger;
            Labadoras labadora = new Labadoras();
            Televisores televisor = new Televisores();
            Agregar agregando = new Agregar();
            venta Ventas = new venta();
            Console.WriteLine("Ingrese el nombre del usuario");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el numero del tabajador");
            long num = Convert.ToInt64(Console.ReadLine());
            if (nombre == "Jorge")
            {
                if (num == 316238371)
                {
                    do
                    {
                        Console.WriteLine("Has ingresado al sistema");
                        Console.WriteLine("Ingrese las siguientes opciones: ");
                        Console.WriteLine("1)Lista de lavadoras");
                        Console.WriteLine("2)Lista de televisores");
                        Console.WriteLine("3)Agregar una nueva lavadora");
                        Console.WriteLine("4)venta");
                        Console.WriteLine("5)Salir");
                        escoger = Convert.ToInt32(Console.ReadLine());
                        if (escoger == 1)
                        {
                            labadora.Inicio();

                        }
                        if (escoger == 2)
                        {
                            televisor.Inicio2();
                        }
                        if (escoger == 3)
                        {
                            agregando.datos();
                        }
                        if (escoger == 4)
                        {
                            Ventas.ventas();

                        }
                    } while (escoger != 5);
                }
                else
                {
                    Console.WriteLine("El numero del trabajador es erroneo");
                }
            }
            else
            {
                Console.WriteLine("Usuario erroneo");
            }
            Console.ReadLine();
        }
    }
}
