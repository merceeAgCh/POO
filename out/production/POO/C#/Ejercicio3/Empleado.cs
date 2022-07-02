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
 *      Clase: Empleado.cs
 *      Atributos y Métodos correspondientes a un Empleado (clase padre de Ejecutivo y Cajero)
 *      Realizado por: Eduardo Miguel Paniagua Broca      
 */

namespace Ejercicio3
{
    interface Metodos_variantes_empleado
    {
        string RealizarDeposito(long noCuenta, double monto);
        string AtenderCliente();
    }
    class Empleado
    {
        string nombre, apellido;
        double comisiones;
        long numTrabajador;

        public Registro registroclientes = new Registro();
        public Empleado()
        {

        }
        public void SetNombre(string name)
        {
            nombre = name;
        }
        public void SetApellido(string lastname)
        {
            apellido = lastname;
        }
        public void SetComisiones(double c)
        {
            comisiones = c;
        }
        public void SetNumTrabajador(long n)
        {
            numTrabajador = n;
        }
        public void SetRegistroClientes(Registro r)
        {
            registroclientes = r;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellido()
        {
            return apellido;
        }
        public double GetComisiones()
        {
            return comisiones;
        }
        public long GetNumTrabajador()
        {
            return numTrabajador;
        }
        public Registro GetRegistroClientes()
        {
            return registroclientes;
        }
    }
}
