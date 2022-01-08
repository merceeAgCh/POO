/* Brigada no. 7
 * Ramírez Bartolo Ignacio, Rosado Dominguez Jorge Kareem, López Ortega Diego, Paniagua Broca Eduardo Miguel, Torres Garcia Christian Ivan
 * 31/Dic/2021
 * Práctica 13, ejercicio 4
 * Clase Obras. Hereda de la clase Funcion
 * Realizado por: Ramírez Bartolo Ignacio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4
{
    class Obras : Funcion
    {
        public String[] titulo = { "Romeo y Julieta", "Hamlet", "La Celestina", "Don Juan Tenorio" };
        public String[] actores = { "Leonardo DiCaprio, Claire Danes, John Leguizamo",
            "Laurence Olivier, Jean Simmons, Eileen Herlie",
            "Penélope Cruz, Maribel Verdú, Juan Diego Botto",
            "Francisco Fraguas, Ivana Heredia, Amanda Recacha"};
        public String[] director = { "William Shakespeare", "William Shakespeare", "Fernando de Rojas", "José de Zorrilla" };
        public String[] escenario = { "07", "08", "09", "10" };
        public float[] costo = { 25, 30, 20, 15 };
        public String[] horario = { "08:30 a 10:00", "11:40 a 13:00", "10:00 a 11:30", "13:30 a 15:00" };
        String actor, directores, escenarios;
        public void setActores(String actores)
        {
            actor = actores;
        }
        public void setDirector(String director)
        {
            directores = director;
        }
        public void setEscenario(String escenario)
        {
            escenarios = escenario;
        }

        public String getActores()
        {
            return actor;
        }
        public String getDirector()
        {
            return directores;
        }
        public String getEscenario()
        {
            return escenarios;
        }
        public Obras()
        {

        }
        public void Mostrar_cartelera()
        {
            for (int i = 0; i < titulo.Length; i++)
            {
                Console.WriteLine("Nombre de la obra: " + titulo[i] + "\nActores: " + actores[i] + "\nDirector: " + director[i] +
                    "\nEscenario: " + escenario[i] + "\nCosto: " + costo[i] + " mxn\nHorario: " + horario[i] + "\n");
            }
        }
    }
}
