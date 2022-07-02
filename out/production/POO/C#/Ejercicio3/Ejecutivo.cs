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
 *      Clase: Ejecutivo.cs
 *      Atributos y Métodos correspondientes a un ejecutivo
 *      Realizado por: Eduardo Miguel Paniagua Broca      
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio3
{
    class Ejecutivo : Empleado, Metodos_variantes_empleado
    {
        int numEjecutivo;
        public void SetNumEjecutivo(int n)
        {
            numEjecutivo = n;
        }

        public int GetNumEjecutivo()
        {
            return numEjecutivo;
        }
        public Ejecutivo()
        {
            SetComisiones(0);
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
            monto += registroclientes.GetRegistroClientes().ElementAt(clientID).GetSaldo();
            temporal.ElementAt(clientID).SetSaldo(monto);
            registroclientes.SetRegistroClientes(temporal);
            return "Saldo tras la operación: $" + registroclientes.GetRegistroClientes().ElementAt(clientID).GetSaldo();
        }

        public string CrearCDebito(long n, double s)
        {
            LinkedList<Cuentas> temporal = registroclientes.GetRegistroClientes();
            Cuentas nueva = new Cuentas();
            while (s < 1000)
            {
                Console.WriteLine("No puede abrir una cuenta con menos de $1000.00\nIntroduzca un nuevo monto");
                try
                {
                    s = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {

                }
            }
            while (s <= 0)
            {
                Console.WriteLine("Por favor ingrese un monto mayor a cero");
                try
                {
                    s = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {

                }

            }
            nueva.SetNumCuentaCliente(n);
            nueva.SetSaldo(s);
            nueva.SetTipoCuenta("Débito");
            temporal.AddLast(nueva);
            registroclientes.SetRegistroClientes(temporal);
            SetComisiones(GetComisiones() + (s * 0.01 * 0.001));
            return "Se ha creado una nueva cuenta de débito";
        }

        public string CrearCCredito(long n, double s)
        {
            while (s <= 0)
            {
                Console.WriteLine("Por favor ingrese un monto mayor a cero");
                try
                {
                    s = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {

                }

            }
            bool ver = false;
            long acNu;
            int i;
            LinkedList<Cuentas> temporal = registroclientes.GetRegistroClientes();
            Cuentas nueva = new Cuentas();
            Console.WriteLine("Introduzca el no. de su cuenta de débito ya existente");
            try
            {
                acNu = Convert.ToInt64(Console.ReadLine());
            }
            catch
            {
                return "No ha ingresado un número de cuenta válido";
            }
            for (i = 0; i < temporal.Count(); i++)
            {
                if (acNu == temporal.ElementAt(i).GetNumCuentaCliente())
                {
                    ver = true;
                    break;
                }
            }
            if (ver == false)
                return "No se ha encontrado una cuenta con ese número de cuenta";
            if (temporal.ElementAt(i).GetSaldo() < 5000)
                return "Se necesita una cuenta con un saldo menor o igual a $5000";
            if (temporal.ElementAt(i).GetTipoCuenta() != "Débito")
                return "No se ha encontrado una cuenta de débito con ese número de cuenta";
            nueva.SetNumCuentaCliente(n);
            nueva.SetSaldo(s);
            nueva.SetTipoCuenta("Crédito");
            temporal.AddLast(nueva);
            registroclientes.SetRegistroClientes(temporal);
            SetComisiones(GetComisiones() + (s * 0.01 * 0.001));
            return "Se ha creado una nueva cuenta de crédito";
        }

        public string CrearCPrestamo(long n, double s)
        {
            while (s <= 0)
            {
                Console.WriteLine("Por favor ingrese un monto mayor a cero");
                try
                {
                    s = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {

                }

            }
            bool ver = false;
            long acNu;
            int i;
            LinkedList<Cuentas> temporal = registroclientes.GetRegistroClientes();
            Cuentas nueva = new Cuentas();
            Console.WriteLine("Introduzca el no. de su cuenta de débito ya existente");
            try
            {
                acNu = Convert.ToInt64(Console.ReadLine());
            }
            catch
            {
                return "No ha ingresado un número de cuenta válido";
            }
            for (i = 0; i < temporal.Count(); i++)
            {
                if (acNu == temporal.ElementAt(i).GetNumCuentaCliente())
                {
                    ver = true;
                    break;
                }
            }
            if (ver == false)
                return "No se ha encontrado una cuenta con ese número de cuenta";
            if (temporal.ElementAt(i).GetSaldo() < 25000)
                return "Se necesita una cuenta con un saldo mayor o igual a $25000";
            if (temporal.ElementAt(i).GetTipoCuenta() != "Débito")
                return "No se ha encontrado una cuenta de débito con ese número de cuenta";
            nueva.SetNumCuentaCliente(n);
            nueva.SetSaldo(s);
            nueva.SetTipoCuenta("Préstamos");
            temporal.AddLast(nueva);
            registroclientes.SetRegistroClientes(temporal);
            SetComisiones(GetComisiones() + (s * 0.01 * 0.001));
            return "Se ha creado una nueva cuenta de préstamos";
        }

        public string CrearFondoInversion(long n, double s)
        {
            while (s <= 0)
            {
                Console.WriteLine("Por favor ingrese un monto mayor a cero");
                try
                {
                    s = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {

                }

            }
            bool ver = false;
            long acNu;
            int i;
            LinkedList<Cuentas> temporal = registroclientes.GetRegistroClientes();
            Cuentas nueva = new Cuentas();
            Console.WriteLine("Introduzca el no. de su cuenta de débito ya existente");
            try
            {
                acNu = Convert.ToInt64(Console.ReadLine());
            }
            catch
            {
                return "No ha ingresado un número de cuenta válido";
            }
            for (i = 0; i < temporal.Count(); i++)
            {
                if (acNu == temporal.ElementAt(i).GetNumCuentaCliente())
                {
                    ver = true;
                    break;
                }
            }
            if (ver == false)
                return "No se ha encontrado una cuenta con ese número de cuenta";
            if (temporal.ElementAt(i).GetSaldo() < 50000)
                return "Se necesita una cuenta con un saldo menor o igual a $50000";
            if (temporal.ElementAt(i).GetTipoCuenta() != "Débito")
                return "No se ha encontrado una cuenta de débito con ese número de cuenta";
            nueva.SetNumCuentaCliente(n);
            nueva.SetSaldo(s);
            nueva.SetTipoCuenta("Fondo");
            temporal.AddLast(nueva);
            registroclientes.SetRegistroClientes(temporal);
            SetComisiones(GetComisiones() + (s * 0.01 * 0.001));
            return "Se ha creado un nuevo fondo de inversión";
        }

        public string AtenderCliente()
        {
            int option;
            long n;
            double m;
            do
            {
                option = -9;
                n = -8;
                m = -85;
                Console.Clear();
                Console.WriteLine("Bienvenid@ " + GetNombre() + ", elija una opción para continuar\n" +
                "1)Realizar un depósito\n" +
                "2)Crear una cuenta de débito\n" +
                "3)Crear una cuenta de crédito\n" +
                "4)Crear una cuenta de préstamos\n" +
                "5)Crear un fondo de inversión\n" +
                "6)Salir");

                while (option <= 0 || option > 6)
                {
                    try
                    {
                        option = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Por favor seleccione una opción válida");
                    }
                    if (option <= 0 || option > 6)
                    {
                        Console.WriteLine("Por favor seleccione una opción válida");
                    }
                }
                Console.Clear();
                if (option != 6)
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
                switch (option)
                {
                    case 1:
                        Console.WriteLine(RealizarDeposito(n, m));
                        Console.WriteLine("Presione enter para continuar");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine(CrearCDebito(n, m));
                        Console.WriteLine("Presione enter para continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine(CrearCCredito(n, m));
                        Console.WriteLine("Presione enter para continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine(CrearCPrestamo(n, m));
                        Console.WriteLine("Presione enter para continuar");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine(CrearFondoInversion(n, m));
                        Console.WriteLine("Presione enter para continuar");
                        Console.ReadKey();
                        break;
                }
            } while (option != 6);
            return "Ha terminado de atender al cliente";
        }

    }
}
