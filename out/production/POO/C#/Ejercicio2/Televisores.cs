/* Brigada no. 7
 * Ramírez Bartolo Ignacio, Rosado Dominguez Jorge Kareem, López Ortega Diego, Paniagua Broca Eduardo Miguel, Torres Garcia Christian Ivan
 * 31/dic/2021
 * Práctica 13, ejercicip 2: Productos
 * Clase Televisores
 * Realizado por: Jorge Kareem Rosado Domingue
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Televisores
    {
        public List<Televisores> television = new List<Televisores>();
        public string marca;
        public string modelo;
        public string serie;
        public int pulgadas;
        public int resolucion;
        public float costo;
        public Televisores()
        {

        }
        public Televisores(string Marca, string Modelo, string serie, int Pulgadas, int Resolucion, float Costo)
        {
            this.marca = Marca;
            this.modelo = Modelo;
            this.serie = serie;
            this.pulgadas = Pulgadas;
            this.resolucion = Resolucion;
            this.costo = Costo;
        }
        public void Inicio2()
        {
            television.Add(new Televisores("sony", "mg250", "k450", 250, 600, 6000));
            television.Add(new Televisores("Tlc", "g562", "b50", 450, 700, 8000));
            television.Add(new Televisores("Samsung", "t250", "k950", 580, 90, 900));
            for (int i = 0; i < television.Count; i++)
            {
                Console.WriteLine(television.ElementAt(i).marca, television.ElementAt(i).modelo, television.ElementAt(i).serie, television.ElementAt(i).pulgadas, television.ElementAt(i).pulgadas, television.ElementAt(i).resolucion, television.ElementAt(i).costo);
            }

        }
    }
}