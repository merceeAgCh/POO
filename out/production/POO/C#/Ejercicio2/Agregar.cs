/* Brigada no. 7
 * Ramírez Bartolo Ignacio, Rosado Dominguez Jorge Kareem, López Ortega Diego, Paniagua Broca Eduardo Miguel, Torres Garcia Christian Ivan
 * 31/dic/2021
 * Práctica 13, ejercicip 2: Productos
 * Clase Agregar
 * Realizado por: Jorge Kareem Rosado Domingue
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Agregar
    {
        public Agregar()
        {

        }
        public void datos()
        {
            Console.WriteLine("Ingrese el nombre de la labadora: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la marca de la labadora: ");
            String Marca = Console.ReadLine();
            Console.WriteLine("Ingrese el peso que soporta la labadora: ");
            int peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el color de la lavadora: ");
            string Color = Console.ReadLine();
            Console.WriteLine("Ingrese el costo de la lavadora: ");
            int costo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Se a agregado con exito la lavadora");
        }
    }
}