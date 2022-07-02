/* Brigada no. 7
 * Ramírez Bartolo Ignacio, Rosado Dominguez Jorge Kareem, López Ortega Diego, Paniagua Broca Eduardo Miguel, Torres Garcia Christian Ivan
 * 31/Dic/2021
 * Práctica 13, ejercicio 4
 * Clase CompraPeli. Hereda de la clase Compra y del interfaz método
 * Realizado por: Ramírez Bartolo Ignacio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4
{
    class CompraPelicula : Compra, metodo
    {
        public void NuevaCompra(List<Cuenta> registro_clientes, int idCliente, int opcion)
        {
            Compra compra = new Compra();
            float numTicP;
            compra.cliente = registro_clientes[idCliente];
            compra.idPeli = compra.catalogo.Buscar(1);
            Console.WriteLine("¿Cuántos tickets va a comprar?");
            numTicP = float.Parse(Console.ReadLine());
            compra.precioTicketsPeli.Add((compra.catalogo.costo[compra.idPeli]) * numTicP);
            Console.Clear();
            Console.WriteLine("Datos de la compra de tickets:\nDatos del cliente:");
            Console.WriteLine(" Nombre y apellidos: " + compra.cliente.nombre_cliente + " " + compra.cliente.apellido_cliente +
                              "\nDatos de la pelicula:" + "\n Nombre: " + compra.catalogo.nombre[compra.idPeli] + "\n Sala: " +
                              compra.catalogo.sala[compra.idPeli] + "\n Horario: " + compra.catalogo.horario[compra.idPeli] +
                              "\n Precio del ticket: $" + compra.catalogo.costo[compra.idPeli] +
                              " mxn\n Número de tickets: " + numTicP +
                              "\n Precio total de esta pelicula: $" + compra.catalogo.costo[compra.idPeli] * numTicP + " mxn");
            registro_clientes[idCliente].pelis_compradas.Add(compra);
        }
    }
}
