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
 *      Clase: Registro.cs
 *      Conjunto de las cuentas creadas
 *      Realizado por: Eduardo Miguel Paniagua Broca      
 */
using System.Collections.Generic;
namespace Ejercicio3
{
    class Registro
    {
        LinkedList<Cuentas> registroClientes = new LinkedList<Cuentas>();

        public Registro()
        {

        }

        public void SetRegistroClientes(LinkedList<Cuentas> registry)
        {
            registroClientes = registry;
        }

        public LinkedList<Cuentas> GetRegistroClientes()
        {
            return registroClientes;
        }
    }
}
