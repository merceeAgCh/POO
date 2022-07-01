/* Brigada no. 7
 * Ramírez Bartolo Ignacio, Rosado Dominguez Jorge Kareem, López Ortega Diego, Paniagua Broca Eduardo Miguel, Torres Garcia Christian Ivan
 * 31/dic/2021
 * Práctica 13, ejercicio 1: hospital
 * Clase Paciente
 * Realizado por: Ramírez Bartolo Ignacio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Paciente : Interfaz, metodoscomun
    {
        public string curp;
        public string numPaciente;
        public string numeroDeHabitacion;
        public List<Paciente> listapacientes = new List<Paciente>();
        public Paciente()
        {

        }
        public Paciente(string nombre, string apellido, string curp, string direccion, string numPaciente, string numeroDeHabitacion)
        {
            this.nombre = nombre;
            this.apellidos = apellido;
            this.curp = curp;
            this.direccion = direccion;
            this.numPaciente = numPaciente;
            this.numeroDeHabitacion = numeroDeHabitacion;
        }

        public void inicializar()
        {
            listapacientes.Add(new Paciente("Roberto", "Torres Bravo", "ATREdf52Ts3aa42E1t", "Avenida 9", "1", "54"));
            listapacientes.Add(new Paciente("María", "Gomez Romero", "SDNJdf1fd45df13fd5", "Poniente 2", "2", "31"));
            listapacientes.Add(new Paciente("Angela", "Hernandez Barreda", "NJBD51fhjm5d4dff5", "Avenida 9", "3", "74"));
        }
        public string getNombre()
        {
            return nombre;
        }
        public string setNombre()
        {
            Console.WriteLine("ingrese nombre del Paciente sin sus apellidos: ");
            nombre = Console.ReadLine();
            return nombre;
        }
        public string getApellido()
        {
            return apellidos;
        }
        public string setApellido()
        {
            Console.WriteLine("Ingrese los apellidos del paciente: ");
            apellidos = Console.ReadLine();
            return apellidos;
        }
        public string setCurp()
        {
            Console.WriteLine("Ingrese su Curp: ");
            curp = Console.ReadLine();
            return curp;
        }
        public string getCurp()
        {
            return curp;
        }
        public string setDireccion()
        {
            Console.WriteLine("ingrese su direccion: ");
            direccion = Console.ReadLine();
            return direccion;
        }
        public string getDireccion()
        {
            return direccion;
        }
        public void EntraTurno(int turn)
        {
            Console.WriteLine("El turno que tu agarrates fue: " + turn);

        }
        public void SalirTurno()
        {
            Console.WriteLine("Saliendo del turno");
        }
        public void NumeroPaciente(int turn)
        {
            Console.WriteLine("El turno que te toco fue: " + turn);
        }
        public string imprimir()
        {
            return (" Nombre: " + nombre + "\n Apellido: " + apellidos + "\n Curp: " + curp + " \n Direccion: " + direccion +
                "\n Número de paciente: " + numPaciente + "\n Número de habitación: " + numeroDeHabitacion + "\n");
        }
    }
}
