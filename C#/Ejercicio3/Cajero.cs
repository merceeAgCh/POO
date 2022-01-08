/*
 * Práctica 13: Patrones de diseño
 * 18 de Diciembre de 2021
 * Equipo #07
 * Integrantes:
 *      López Ortega Diego
 *      Paniagua Broca Eduardo Miguel
 *      Ramírez Bartolo Ignacio
 *      Rosado Domínguez Jorge Kareem
 *      Torres Gracian Christian Ivan
 * Ejercicio 3: El Banco de la Buena Responsabilidad Financiera (BBRF) desea un sistema para sus cajeros y ejecutivos
 * Realizado por: Eduardo Miguel Paniagua Broca 
 *      Clase: Cajero.cs
 *      Atributos y Métodos correspondientes a un Cajero
 *      Realizado por: Eduardo Miguel Paniagua Broca      
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio3
{
    class Cajero : Empleado, Metodos_variantes_empleado
    {
        int noVentanilla;

        public Cajero()
        {
            SetComisiones(0);
        }
        public void SetNoVentanilla(int n)
        {
            noVentanilla = n;
        }

        public int GetNoVentanilla()
        {
            return noVentanilla;
        }
        public string RealizarDeposito(long noCuenta, double monto)
        {
            LinkedList<Cuentas> temporal = registroclientes.GetRegistroClientes();
            int clientID = -8;
            while (clientID < 0)
            {
                for (int i = 0; i < registroclientes.GetRegistroClientes().Count(); i++)
                {
                    if (registroclientes.GetRegistroClientes().ElementAt(i).GetNumCuentaCliente() == noCuenta)
                    {
                        clientID = i;
                        break;
                    }
                }
                if (clientID < 0)
                {
                    Console.WriteLine("No se ha encontrado la cuenta solicitada, ingrese de nuevo el no. de cuenta");
                    noCuenta = Convert.ToInt64(Console.ReadLine());
                }
            }
            while (monto <= 0)
            {
                Console.WriteLine("Por favor ingrese un monto mayor a cero");
                try
                {
                    monto = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {

                }
            }

            SetComisiones(GetComisiones() + (monto * 0.01 * 0.0001));
            monto += registroclientes.GetRegistroClientes().ElementAt(clientID).GetSaldo();
            temporal.ElementAt(clientID).SetSaldo(monto);
            registroclientes.SetRegistroClientes(temporal);
            return "Saldo tras la operación: $" + registroclientes.GetRegistroClientes().ElementAt(clientID).GetSaldo();
        }

        public string RealizarRetiro(long noCuenta, double monto)
        {
            LinkedList<Cuentas> temporal = registroclientes.GetRegistroClientes();
            int clientID = -8;
            while (clientID < 0)
            {
                for (int i = 0; i < registroclientes.GetRegistroClientes().Count(); i++)
                {
                    if (registroclientes.GetRegistroClientes().ElementAt(i).GetNumCuentaCliente() == noCuenta)
                    {
                        clientID = i;
                        break;
                    }
                }
                if (clientID < 0)
                {
                    Console.WriteLine("No se ha encontrado la cuenta solicitada, ingrese de nuevo el no. de cuenta");
                    try
                    {
                        noCuenta = Convert.ToInt64(Console.ReadLine());
                    }
                    catch
                    {

                    }
                }
            }
            while (monto > temporal.ElementAt(clientID).GetSaldo())
            {
                Console.WriteLine("El monto ingresado excede el saldo en la cuenta, ingrese otra cantidad");
                monto = Convert.ToInt64(Console.ReadLine());
            }
            SetComisiones(GetComisiones() + monto * 0.01 * 0.0001);
            monto = registroclientes.GetRegistroClientes().ElementAt(clientID).GetSaldo() - monto;
            temporal.ElementAt(clientID).SetSaldo(monto);
            registroclientes.SetRegistroClientes(temporal);
            return "Saldo tras la operación: $" + registroclientes.GetRegistroClientes().ElementAt(clientID).GetSaldo();
        }
        public string AtenderCliente()
        {
            char option;
            long n;
            double m;

            do
            {
                option = 'f';
                n = -999;
                m = -8;
                Console.Clear();
                Console.WriteLine("Bienvenid@ " + GetNombre() + ", elija una opción para continuar\na)Realizar un depósito\nb)Retirar efectivo\nc)Salir");

                while (option != 'a' && option != 'b' && option != 'c')
                {
                    try
                    {
                        option = Convert.ToChar(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Por favor seleccione una opción válida");
                    }
                    if (option != 'a' && option != 'b' && option != 'c')
                    {
                        Console.WriteLine("Por favor seleccione una opción válida");
                    }
                }
                Console.Clear();
                if (option != 'c')
                {
                    Console.WriteLine("Ingrese un no. de cuenta:");
                    try
                    {
                        n = Convert.ToInt64(Console.ReadLine());
                    }
                    catch
                    {

                    }
                    Console.WriteLine("Ingrese un monto");
                    try
                    {
                        m = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {

                    }
                }
                Console.Clear();
                if (option == 'a')
                {
                    Console.WriteLine(RealizarDeposito(n, m));
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadKey();
                }
                else if (option == 'b')
                {
                    Console.WriteLine(RealizarRetiro(n, m));
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadKey();
                }
            } while (option != 'c');
            return "Ha terminado de atender al cliente";
        }
    }
}
