using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFinal
{
    public class Ponentes : Horario
    {
        public static List<Horario> Sala1 = new List<Horario>();
        public static List<Horario> Sala2 = new List<Horario>();
        public static List<Horario> Sala3 = new List<Horario>();
        public static List<Horario> Sala4 = new List<Horario>();
        public static List<Horario> Sala5 = new List<Horario>();
        public static List<Horario> Centro1 = new List<Horario>();
        public static List<Horario> Centro2 = new List<Horario>();

        //public static void horarioSalas()
        //{
        //    Sala1.Add(new Horario("31623841","Sala 1","7 de dciembre","9:00 a 11:00","Exposicion de Evolucion del hombre")); //ejemplo de nombre de la ponencia
        //    Sala2.Add(new Horario("313538179", "Sala 2","7 de dieiembre","11:00 a 13:00", "Exposicion de la comunidad")); //ejemplo de la ponencia
        //    Sala3.Add(new Horario("21563948","Sala 3","7 de diciembre","13:00 a 15:00","Exposicion 3"));
        //    Sala4.Add(new Horario("21265385", "Sala 4", "7 de diciembre", "15:00 a 17:00", "Exposicion 4"));
        //    Sala5.Add(new Horario("45697823", "Sala 5", "7 de diciembre", "17:00 a 19:00", "Exposicion 5"));
        //    Centro1.Add(new Horario("1258493", "Sala 6", "7 de diciembre", "17:00 a 19:00", "Exposicion 6"));
        //    Centro2.Add(new Horario("15263948", "Sala 7", "7 de diciembre", "13:00 a 15:00", "Exposicion 7"));
        //}

       //string nombre; ya lo hereda de admin 

        int tiempo; //ingresar en minutos
        int aforo;
        public Ponentes()
        {

        }
        public void getTiempo()
        {

        }
        public void setTiempo(int time)
        {
            this.tiempo = time;
            Console.WriteLine("La duracion de la ponencia es de: " + time);
        }
        public void getAforo()
        {

        }
        public void setAforo(int aforo)
        {
            this.aforo = aforo;
            Console.WriteLine("El maximo de personas es: " + aforo);
        }


    }
}
