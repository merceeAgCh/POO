/* Brigada no. 7
 * Ramírez Bartolo Ignacio, Rosado Dominguez Jorge Kareem, López Ortega Diego, Paniagua Broca Eduardo Miguel, Torres Garcia Christian Ivan
 * 31/Dic/2021
 * Práctica 13, ejercicio 4
 * Clase CompraObra. Hereda de la clase Compra y del interfaz método
 * Realizado por: Ramírez Bartolo Ignacio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4
{
    class CompraObra : Compra, metodo
    {
        public void NuevaCompra(List<Cuenta> registro_clientes, int idCliente, int opcion)
        {
            Compra compra = new Compra();
            float numTicO;
            compra.cliente = registro_clientes[idCliente];
            compra.idObra = compra.cartelera.Buscar(2);
            Console.WriteLine("¿Cuántos tickets va a comprar?");
            numTicO = float.Parse(Console.ReadLine());
            compra.precioTicketsObra.Add((compra.cartelera.costo[compra.idObra]) * numTicO);
            Console.Clear();
            Console.WriteLine("Datos de la compra de tickets:\nDatos del cliente:");
            Console.WriteLine(" Nombre y apellidos: " + compra.cliente.nombre_cliente + " " + compra.cliente.apellido_cliente +
                              "\nDatos de la obra:" + "\n Titulo: " + compra.cartelera.titulo[compra.idObra] + "\n Actores: " +
                              compra.cartelera.actores[compra.idObra] + "\n Director: " + compra.cartelera.director[compra.idObra] +
                              "\n Escenario: " + compra.cartelera.escenario[compra.idObra] + "\n Horario: " + compra.cartelera.horario[compra.idObra] +
                              "\n Precio del ticket: $" + compra.cartelera.costo[compra.idObra] +
                              " mxn\n Número de tickets: " + numTicO +
                              "\n Precio total de esta pelicula: $" + compra.cartelera.costo[compra.idObra] * numTicO + " mxn");
            registro_clientes[idCliente].obras_compradas.Add(compra);
        }
    }
}
