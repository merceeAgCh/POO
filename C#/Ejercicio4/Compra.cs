/* Brigada no. 7
 * Ramírez Bartolo Ignacio, Rosado Dominguez Jorge Kareem, López Ortega Diego, Paniagua Broca Eduardo Miguel, Torres Garcia Christian Ivan
 * 31/Dic/2021
 * Práctica 13, ejercicio 4
 * Clase Compra
 * Realizado por: Ramírez Bartolo Ignacio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4
{
    interface metodo
    {
        void NuevaCompra(List<Cuenta> registro_clientes, int idCliente, int opcion);
    }
    class Compra
    {
        public Cuenta cliente;
        public Peliculas catalogo = new Peliculas();
        public Obras cartelera = new Obras();
        public int idObra;
        public List<float> precioTicketsPeli = new List<float>();
        public List<float> precioTicketsObra = new List<float>();
        public int idPeli;
        public int IdPeli { get => idPeli; set => idPeli = value; }
        public int IdObra { get => idObra; set => idObra = value; }

        public Compra()
        {

        }
    }
}
