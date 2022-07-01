/* Brigada no. 7
 * Ramírez Bartolo Ignacio, Rosado Dominguez Jorge Kareem, López Ortega Diego, Paniagua Broca Eduardo Miguel, Torres Garcia Christian Ivan
 * 31/Dic/2021
 * Práctica 13, ejercicio 4
 * Clase Funcion
 * Realizado por: Ramírez Bartolo Ignacio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4
{
    class Funcion
    {
        String titulos;
        float costos;
        String horarios;
        public void setTitulo(string titulo)
        {
            titulos = titulo;
        }
        public void setCostos(float costos)
        {
            this.costos = costos;
        }
        public void setHorario(string horario)
        {
            horarios = horario;
        }

        public String getTitulo()
        {
            return titulos;
        }
        public float getCostos()
        {
            return costos;
        }
        public String getHorario()
        {
            return horarios;
        }
        public int Buscar(int opcion)
        {
            Peliculas catalogo = new Peliculas();
            Obras cartelera = new Obras();
            String nombre;
            int id = -1;
            if (opcion == 1)
            {
                while (id == -1)
                {
                    Console.WriteLine("Ingrese el nombre de la pelicula");
                    nombre = Console.ReadLine();
                    for (int i = 0; i < 6; i++)
                    {
                        if (catalogo.nombre[i] == nombre)
                            id = i;
                    }
                    if (id == -1)
                    {
                        Console.WriteLine("No se ha encontrado la pelicula buscada, intente de nuevo");
                    }
                }
            }
            else if (opcion == 2)
            {
                while (id == -1)
                {
                    Console.WriteLine("Ingrese el nombre de la obra");
                    nombre = Console.ReadLine();
                    for (int i = 0; i < cartelera.titulo.Length; i++)
                    {
                        if (cartelera.titulo[i] == nombre)
                            id = i;
                    }
                    if (id == -1)
                    {
                        Console.WriteLine("No se ha encontrado la obra buscada, intente de nuevo");
                    }
                }
            }
            return id;
        }
    }
}
