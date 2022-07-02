/* Brigada no. 7
 * Ramírez Bartolo Ignacio, Rosado Dominguez Jorge Kareem, López Ortega Diego, Paniagua Broca Eduardo Miguel, Torres Garcia Christian Ivan
 * 31/dic/2021
 * Práctica 13, ejercicio 1: hospital
 * Clase Program
 * Realizado por: Ramírez Bartolo Ignacio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenid@");
            Random numpac = new Random();
            Enfermera Enfermera1 = new Enfermera();
            Enfermera1.inicializar();
            Paciente Paciente1 = new Paciente();
            Paciente1.inicializar();
            int opcion, NumeroTrabajador, turno, areaAt, opcion2, k = Paciente1.listapacientes.Count, m = Enfermera1.listaenfermeras.Count;
            bool encontrado = false;
            NumeroTrabajador = numpac.Next(1, 100);
            string nuevaContraseña = "", contraseña = "", nom, ap, curp, dir, rfc;
            do
            {
                Console.WriteLine("Buen día. ¿Ya tiene creada la cuenta?  1=Sí  2=No 3=Salir (Ingrese el número)");
                opcion2 = Convert.ToInt32(Console.ReadLine());
                if (opcion2 == 1)
                {
                    Console.WriteLine("Ingrese la contraseña");
                    contraseña = Console.ReadLine();
                    if (nuevaContraseña != contraseña || !encontrado)
                    {
                        Console.WriteLine("Contraseña incorrecta. Ingrese la correcta.\nPresione enter para volver");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else if (opcion2 == 2)
                {
                    Console.WriteLine("Tu numero de trabajador es: " + NumeroTrabajador);
                    Console.WriteLine("Cree una nueva contraseña: ");
                    nuevaContraseña = Console.ReadLine();
                    Console.WriteLine("Contraseña nueva ingresada.\nPresione enter para volver");
                    Console.ReadLine();
                    Console.Clear();
                    encontrado = true;
                }
                else if (opcion2 == 3)
                {
                    Console.WriteLine("Gracias por usar el programa, presione enter para salir.");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opción no válida, presione enter para volver.");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (nuevaContraseña == contraseña && encontrado == true && opcion2 == 1)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Ingrese una de las siguientes opciones: ");
                        Console.WriteLine("1) Iniciar/Terminar turno");
                        Console.WriteLine("2) Ver lista de pacientes");
                        Console.WriteLine("3) Atender al paciente");
                        Console.WriteLine("4) Escribir reporte");
                        Console.WriteLine("5) Salir");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        if (opcion == 1)
                        {
                            Console.Clear();
                            if (Paciente1.listapacientes.Count != 0)
                            {
                                turno = numpac.Next(1, Paciente1.listapacientes.Count + 1);
                                Paciente1.EntraTurno(turno);
                                Paciente1.SalirTurno();
                                Paciente1.NumeroPaciente(turno);
                            }
                            else
                                Console.WriteLine("No hay pacientes. Espere a que uno venga.");
                            Console.WriteLine("Presione enter para regresar al menú");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (opcion == 2)
                        {
                            Console.Clear();
                            if (Paciente1.listapacientes.Count != 0)
                            {
                                Console.WriteLine("---LISTA DE PACIENTES EN EL HOSPITAL---");
                                for (int i = 0; i < Paciente1.listapacientes.Count; i++)
                                {
                                    Console.WriteLine("Paciente "+(i+1));
                                    Console.WriteLine(" Nombre completo: {0} {1}\n CURP: {2}\n Dirección: {3}\n Número de habitación: {4}\n", Paciente1.listapacientes.ElementAt(i).nombre,
                                        Paciente1.listapacientes.ElementAt(i).apellidos, Paciente1.listapacientes.ElementAt(i).curp, Paciente1.listapacientes.ElementAt(i).direccion,
                                        Paciente1.listapacientes.ElementAt(i).numeroDeHabitacion);
                                }
                            }
                            else
                                Console.WriteLine("No hay pacientes en el hospital. Espere a que llegue uno");
                            Console.WriteLine("Presione enter para regresar al menú");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (opcion == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Usted eligió atender un paciente");
                            nom = Paciente1.setNombre();
                            ap = Paciente1.setApellido();
                            curp = Paciente1.setCurp();
                            dir = Paciente1.setDireccion();
                            k++;
                            Paciente nuevopac = new Paciente(nom, ap, curp, dir, Convert.ToString(k), Convert.ToString(numpac.Next(1, 100)));
                            Paciente1.listapacientes.Add(nuevopac);
                            nuevopac.NumeroPaciente(Paciente1.listapacientes.Count);
                            nuevopac.imprimir();
                            Console.WriteLine("Datos ingresados\nPresione enter para regresar al menú");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (opcion == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Usted eligió escribir el reporte");
                            string reporte;
                            nom = Enfermera1.setNombres();
                            ap = Enfermera1.setApellidos();
                            rfc = Enfermera1.setRFC();
                            dir = Enfermera1.setDirecciones();
                            areaAt = Enfermera1.area();
                            m=Enfermera1.setNum();
                            reporte = Enfermera1.imprimir();
                            Enfermera1.listaenfermeras.Add(new Enfermera(nom, ap, rfc, dir, areaAt, reporte, Convert.ToString(m)));
                            Console.WriteLine("Reporte y enfermera ingresados");
                            Console.WriteLine("Presione enter para regresar al menú");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (opcion == 5)
                        {
                            Console.Clear();
                            Console.WriteLine("Gracias por usar el programa. Presione enter para volver al menú principal.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    } while (opcion != 5);
                }
            } while (opcion2 != 3);
        }
    }
}
