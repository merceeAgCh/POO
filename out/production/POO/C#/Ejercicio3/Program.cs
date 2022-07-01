using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int optionA = 0, optionB = 0;
            Registro rC = new Registro();
            LinkedList<Cuentas> R1 = new LinkedList<Cuentas>();
            Cuentas c1, c2, c3;
            c1 = new Cuentas();
            c2 = new Cuentas();
            c3 = new Cuentas();
            c1.SetNumCuentaCliente(845963);
            c2.SetNumCuentaCliente(985321);
            c3.SetNumCuentaCliente(804731);
            c1.SetSaldo(9000);
            c2.SetSaldo(1000);
            c3.SetSaldo(780000);
            c1.SetTipoCuenta("Débito");
            c2.SetTipoCuenta("Débito");
            c3.SetTipoCuenta("Débito");
            R1.AddLast(c1);
            R1.AddLast(c2);
            R1.AddLast(c3);
            rC.SetRegistroClientes(R1);
            Cajero caj01 = new Cajero(), caj02 = new Cajero();
            Ejecutivo ejec01 = new Ejecutivo(), ejec02 = new Ejecutivo();

            caj01.SetNombre("Raúl");
            caj01.SetApellido("Gómez");
            caj01.SetNumTrabajador(89456);
            caj01.SetNoVentanilla(1);
            caj01.SetRegistroClientes(rC);

            caj02.SetNombre("Danila");
            caj02.SetApellido("Ramírez");
            caj02.SetNumTrabajador(15623);
            caj02.SetNoVentanilla(2);
            caj02.SetRegistroClientes(rC);


            ejec01.SetNombre("Saúl");
            ejec01.SetApellido("Pérez");
            ejec02.SetNumTrabajador(32849);
            ejec02.SetNumEjecutivo(1);
            ejec01.SetRegistroClientes(rC);


            ejec02.SetNombre("Arturo");
            ejec02.SetApellido("López");
            ejec02.SetNumTrabajador(84603);
            ejec02.SetNumEjecutivo(2);
            ejec02.SetRegistroClientes(rC);


            Console.WriteLine("Bienvenid@, elija un tipo de trabajador:\n" +
                "1)Cajero\n" +
                "2)Ejecutivo");

            while (optionA < 1 || optionA > 2)
            {
                try
                {
                    optionA = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {

                }
                if (optionA < 1 || optionA > 2)
                    Console.WriteLine("Por favor elija una opción válida");
            }
            Console.WriteLine("Ingrese su número de ventanilla o ejecutivo");
            while (optionB < 1 || optionB > 2)
            {
                try
                {
                    optionB = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {

                }
                if (optionB < 1 || optionB > 2)
                    Console.WriteLine("Por favor elija una opción válida");
            }

            if (optionA == 1)
            {
                if (optionB == 1)
                {
                    Console.WriteLine(caj01.AtenderCliente());
                }
                else
                {
                    Console.WriteLine(caj02.AtenderCliente());
                }
            }
            else
            {
                if (optionB == 1)
                {
                    Console.WriteLine(ejec01.AtenderCliente());
                }
                else
                {
                    Console.WriteLine(ejec02.AtenderCliente());
                }
            }

        }
    }
}
