/* Brigada no. 7
 * Ramírez Bartolo Ignacio, Rosado Dominguez Jorge Kareem, López Ortega Diego, Paniagua Broca Eduardo Miguel, Torres Garcia Christian Ivan
 * 31/dic/2021
 * Práctica 13, ejercicio 1: hospital
 * Clase Enfermera
 * Realizado por: Ramírez Bartolo Ignacio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Enfermera : Interfaz, metodoscomun
    {
        string RFC;
        int areaAtencion;
        string reporte;
        string numEmpleado;
        public List<Enfermera> listaenfermeras = new List<Enfermera>();
        public Enfermera()
        {
        }

        public Enfermera(string nombres, string apellidos, string rFC, string direcciones, int areaAtencion, string let, string num)
        {
            this.nombre = nombres;
            this.apellidos = apellidos;
            RFC = rFC;
            this.direccion = direcciones;
            this.areaAtencion = areaAtencion;
            reporte = let;
            numEmpleado = num;
        }

        public void inicializar()
        {
            listaenfermeras.Add(new Enfermera("María", "Salgado Perez", "GEC8501014l5", "Avenida Colon", 1, "", "1"));
        }
        public string getNombres()
        {
            return nombre;
        }
        public string setNombres()
        {
            Console.WriteLine("Ingrese nombre de la enfermera sin sus apellidos: ");
            nombre = Console.ReadLine();
            return nombre;
        }
        public string setApellidos()
        {
            Console.WriteLine("Ingrese los apellidos de la enfermera: ");
            apellidos = Console.ReadLine();
            return apellidos;
        }
        public string getApellidos()
        {
            return apellidos;
        }
        public string setRFC()
        {
            Console.WriteLine("Ingrese el RFC del trabajador: ");
            RFC = Console.ReadLine();
            return RFC;
        }
        public string getRFC()
        {
            return RFC;
        }
        public string setDirecciones()
        {
            Console.WriteLine("Ingrese la direccion del usuario: ");
            direccion = Console.ReadLine();
            return direccion;
        }
        public int setNum()
        {
            return Convert.ToInt32(numEmpleado) + 1;
        }
        public int area()
        {
            Console.WriteLine("Escoje una de las siguientes areas y a continuacion se le asignara la correspondiente (1, 2, 3)");
            areaAtencion = Convert.ToInt32(Console.ReadLine());
            if (areaAtencion == 1)
                Console.WriteLine("Ingresaste al area general: ");
            if (areaAtencion == 2)
                Console.WriteLine("Ingresaste al area de terapia intensiva: ");
            if (areaAtencion == 3)
                Console.WriteLine("Ingresaste al area de medicos generales: ");
            return areaAtencion;
        }
        public string imprimir()
        {
            Console.WriteLine(" Nombre: " + nombre + "\n Apellidos: " + apellidos + "\n RFC: " + RFC + "\n Dirección: " + direccion +"\n Número de empleado: " + numEmpleado+1);
            Console.WriteLine("Empieza el reporte: ");
            reporte = Console.ReadLine();
            return reporte;
        }
    }
}
