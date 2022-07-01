/* Brigada no. 7
 * Ramírez Bartolo Ignacio, Rosado Dominguez Jorge Kareem, López Ortega Diego, Paniagua Broca Eduardo Miguel, Torres Garcia Christian Ivan
 * 31/Dic/2021
 * Práctica 13, ejercicio 4
 * Clase Peliculas. Hereda de la clase Funcion
 * Realizado por: Ramírez Bartolo Ignacio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4
{
    class Peliculas : Funcion
    {
        public String[] nombre = { "Shrek", "Toy Story", "Rio", "Avatar", "Avengers", "Aladdin" };
        public String[] sala = { "01", "02", "03", "04", "05", "06" };
        public String[] horario = { "14:30 a 16:00", "11:55 a 14:00", "18:00 a 20:00", "14:30 a 16:00", "20:30 a 22:30", "16:30 a 18:00" };
        public float[] costo = { 30, 45, 50, 25, 45, 35 };
        public String salas;

        public void setSalas(String salas)
        {
            this.salas = salas;
        }

        public String getSalas()
        {
            return salas;
        }

        public Peliculas()
        {

        }
        public void Mostrar_catalogo()
        {
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("Nombre: " + nombre[i] + "\nSala: " + sala[i] + "\nHorario: " + horario[i] + "\nCosto: " + costo[i] + " mxn\n");
            }
        }
    }
}
