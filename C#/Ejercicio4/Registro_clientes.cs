/* Brigada no. 7
 * Ramírez Bartolo Ignacio, Rosado Dominguez Jorge Kareem, López Ortega Diego, Paniagua Broca Eduardo Miguel, Torres Garcia Christian Ivan
 * 31/Dic/2021
 * Práctica 13, ejercicio 4
 * Clase Registro_clientes
 * Realizado por: Ramírez Bartolo Ignacio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4
{
    class Registro_clientes
    {
        public List<Cuenta> registro_clientes = new List<Cuenta>();
        public Registro_clientes()
        {

        }
        public void Nueva_cuenta()
        {
            Console.Clear();
            string nombre_cliente, apellido_cliente, direccion_cliente, paypal_cliente;
            Console.WriteLine("Datos personales:\nIngrese su nombre (sin apellidos):");
            nombre_cliente = Console.ReadLine();
            Console.WriteLine("Ingrese sus apellidos:");
            apellido_cliente = Console.ReadLine();
            Console.WriteLine("Ingrese su dirección:");
            direccion_cliente = Console.ReadLine();
            Console.WriteLine("Ingrese su número de cuenta Paypal:");
            paypal_cliente = Console.ReadLine();
            Cuenta cuentaNueva = new Cuenta(nombre_cliente, apellido_cliente, direccion_cliente, paypal_cliente);
            registro_clientes.Add(cuentaNueva);
        }
        public int Buscar_Cuenta()
        {
            int idCliente = -1;
            string nombre, apellidos, direccion, paypal;

            Console.WriteLine("Ingrese el nombre con el que se ha registrado:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese sus apellidos:");
            apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese su dirección:");
            direccion = Console.ReadLine();
            Console.WriteLine("Ingrese su número de cuenta PayPal:");
            paypal = Console.ReadLine();
            for (int i = 0; i < registro_clientes.Count; i++)
            {
                if (nombre == registro_clientes.ElementAt(i).nombre_cliente &&
                    apellidos == registro_clientes.ElementAt(i).apellido_cliente &&
                    direccion == registro_clientes.ElementAt(i).direccion_cliente &&
                    paypal == registro_clientes.ElementAt(i).paypal_cliente)
                {
                    idCliente = i;
                }
            }
            return idCliente;
        }

    }
}
