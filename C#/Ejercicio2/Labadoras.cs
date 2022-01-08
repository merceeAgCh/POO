/* Brigada no. 7
 * Ramírez Bartolo Ignacio, Rosado Dominguez Jorge Kareem, López Ortega Diego, Paniagua Broca Eduardo Miguel, Torres Garcia Christian Ivan
 * 31/dic/2021
 * Práctica 13, ejercicip 2: Productos
 * Clase Labadoras
 * Realizado por: Jorge Kareem Rosado Dominguez
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Labadoras
    {
        public List<Labadoras> labadoras = new List<Labadoras>();
        public string marca;
        public string modelo;
        public string serie;
        public int peso;
        public int dimensiones;
        public string color;
        public float costo;

        public Labadoras()
        {

        }

        public Labadoras(string Marca, string Modelo, string serie, int Peso, int Dimensiones, string Color, float Costo)
        {
            this.marca = Marca;
            this.modelo = Modelo;
            this.serie = serie;
            this.peso = Peso;
            this.dimensiones = Dimensiones;
            this.color = Color;
            this.costo = Costo;
        }
        public void Inicio()
        {
            labadoras.Add(new Labadoras("Wirpool", "Afa25", "Trumba72", 150, 320, "azul", 6900));
            labadoras.Add(new Labadoras("axtra", "Afa372", "Trumba150", 205, 320, "amarillo", 4900));
            labadoras.Add(new Labadoras("Wirpool", "fever25", "fever263", 150, 320, "rojo", 7800));
            for (int i = 0; i < labadoras.Count; i++)
            {
                Console.WriteLine(labadoras.ElementAt(i).marca, labadoras.ElementAt(i).modelo, labadoras.ElementAt(i).serie, labadoras.ElementAt(i).peso, labadoras.ElementAt(i).dimensiones, labadoras.ElementAt(i).color, labadoras.ElementAt(i).costo);
            }
        }
    }
}
