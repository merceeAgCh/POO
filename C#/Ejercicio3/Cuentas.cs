/*
 * Práctica 7: Herencia
 * 4 de Noviembre de 2021
 * Equipo #07
 * Integrantes:
 *      López Ortega Diego
 *      Paniagua Broca Eduardo Miguel
 *      Ramírez Bartolo Ignacio
 *      Rosado Domínguez Jorge Kareem
 *      Torres Gracian Christian Ivan
 * Ejercicio 3: El Banco de la Buena Responsabilidad Financiera (BBRF) desea un sistema para sus cajeros y ejecutivos
 * Realizado por: Eduardo Miguel Paniagua Broca 
 *      Clase: Cuentas.cs
 *      Clase que representa la cuenta de un cliente
 *      Realizado por: Eduardo Miguel Paniagua Broca      
 */
namespace Ejercicio3
{
    class Cuentas
    {
        long numCuentaCliente;
        string tipoCuenta;//Crédito o Débito
        double saldo;
        public Cuentas()
        {

        }

        public void SetNumCuentaCliente(long num)
        {
            numCuentaCliente = num;
        }

        public void SetTipoCuenta(string type)
        {
            tipoCuenta = type;
        }
        public void SetSaldo(double balance)
        {
            saldo = balance;
        }

        public long GetNumCuentaCliente()
        {
            return numCuentaCliente;
        }

        public string GetTipoCuenta()
        {
            return tipoCuenta;
        }
        public double GetSaldo()
        {
            return saldo;
        }
    }
}
