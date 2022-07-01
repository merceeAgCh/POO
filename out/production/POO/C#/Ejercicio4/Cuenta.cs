/* Brigada no. 7
 * Ramírez Bartolo Ignacio, Rosado Dominguez Jorge Kareem, López Ortega Diego, Paniagua Broca Eduardo Miguel, Torres Garcia Christian Ivan
 * 31/Dic/2021
 * Práctica 13, ejercicio 4
 * Clase Cuenta
 * Realizado por: Ramírez Bartolo Ignacio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4
{
    class Cuenta
    {
        public string direccion_cliente;
        public string paypal_cliente;
        public List<Compra> pelis_compradas = new List<Compra>();
        public List<Compra> obras_compradas = new List<Compra>();
        public string nombre_cliente;
        public string apellido_cliente;

        public Cuenta()
        {

        }
        public Cuenta(string nombre, string apellido, string direccion, string paypal)
        {
            nombre_cliente = nombre;
            apellido_cliente = apellido;
            direccion_cliente = direccion;
            paypal_cliente = paypal;
        }

        public string Nombre_cliente { get => nombre_cliente; set => nombre_cliente = value; }
        public string Apellido_cliente { get => apellido_cliente; set => apellido_cliente = value; }
        public string Direccion_cliente { get => direccion_cliente; set => direccion_cliente = value; }
        public string Paypal_cliente { get => paypal_cliente; set => paypal_cliente = value; }

        public void Imprimir_ticket()
        {
            int i = 0;
            long totalAmbos = 0, totalPelis = 0, totalObras = 0;
            float totalBol = 0, totalBolPelis = 0, totalBolObras = 0;
            if (pelis_compradas.Count == 0 && obras_compradas.Count == 0)
            {
                Console.WriteLine("Aún no se ha realizado ninguna compra");
            }
            else
            {
                Console.WriteLine("Tickets comprados");
                Console.WriteLine("Nombre: " + nombre_cliente + " " + apellido_cliente + "\nProductos comprados:");
                for (i = 0; i < pelis_compradas.Count; i++)
                {
                    Console.WriteLine(" Pelicula: " + pelis_compradas[i].catalogo.nombre[pelis_compradas[i].idPeli] + "\n Sala: " +
                        pelis_compradas[i].catalogo.sala[pelis_compradas[i].idPeli] + "\n Duración: " +
                        pelis_compradas[i].catalogo.horario[pelis_compradas[i].idPeli] + "\n Precio del ticket: $" +
                        pelis_compradas[i].catalogo.costo[pelis_compradas[i].idPeli] + " mxn");
                    Console.WriteLine(" Tickets: " + pelis_compradas[i].precioTicketsPeli[0] / pelis_compradas[i].catalogo.costo[pelis_compradas[i].idPeli]);
                    Console.WriteLine(" Precio con tickets incluidos: $" + pelis_compradas[i].precioTicketsPeli[0] + " mxn\n");
                    totalBolPelis = totalBolPelis + pelis_compradas[i].precioTicketsPeli[0] / pelis_compradas[i].catalogo.costo[pelis_compradas[i].idPeli];
                    totalPelis = totalPelis + (long)pelis_compradas[i].precioTicketsPeli[0];
                }
                for (i = 0; i < obras_compradas.Count; i++)
                {
                    Console.WriteLine(" Obras: " + obras_compradas[i].cartelera.titulo[obras_compradas[i].idObra] + "\n Actores: " +
                        obras_compradas[i].cartelera.actores[obras_compradas[i].idObra] + "\n Director: " +
                        obras_compradas[i].cartelera.director[obras_compradas[i].idObra] + "\n Escenario: " +
                        obras_compradas[i].cartelera.escenario[obras_compradas[i].idObra] + "\n Horario: " +
                        obras_compradas[i].cartelera.horario[obras_compradas[i].idObra] + "\n Precio del ticket: $" +
                        obras_compradas[i].cartelera.costo[obras_compradas[i].idObra] + " mxn");
                    Console.WriteLine(" Tickets: " + obras_compradas[i].precioTicketsObra[0] / obras_compradas[i].cartelera.costo[obras_compradas[i].idObra]);
                    Console.WriteLine(" Precio con tickets incluidos: $" + obras_compradas[i].precioTicketsObra[0] + " mxn\n");
                    totalBolObras = totalBolObras + obras_compradas[i].precioTicketsObra[0] / obras_compradas[i].cartelera.costo[obras_compradas[i].idObra];
                    totalObras = totalObras + (long)obras_compradas[i].precioTicketsObra[0];
                }
                totalAmbos = totalPelis + totalObras;
                totalBol = totalBolPelis + totalBolObras;
                Console.WriteLine("Cantidad total de tickets comprados: " + totalBol);
                Console.WriteLine("Total a pagar: $" + totalAmbos + " mxn");
            }
        }
    }
}
