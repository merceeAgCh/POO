using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; //necesaria para usar hilos
using System.Diagnostics;

namespace Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch tiempoSecuencial = new Stopwatch();
            Stopwatch tiempoHilos = new Stopwatch();

            tiempoSecuencial.Start();
            Console.WriteLine("Programa Secuencial/Serial");
            tiempoSecuencial.Stop();
            Console.WriteLine("El programa secuencial tomó {0} ms en ejecutarse",
                tiempoSecuencial.Elapsed.TotalMilliseconds);

            Thread hilo1 = new Thread(new ThreadStart(Tabla1));
            Thread hilo2 = new Thread(new ThreadStart(Tabla2));

            tiempoHilos.Start();
            Console.WriteLine("Programa con Hilos");
            hilo1.Start();
            hilo2.Start();
            /*
             * Hilo Principal (Main)
             *      ->Hilo1 Trabaja
             *      ->Hilo2 Trabaja
             * 
             */

            tiempoHilos.Stop();
            Console.WriteLine("El programa con hilos tomó {0} ms en ejecutarse",
                tiempoHilos.Elapsed.TotalMilliseconds);

            //Thread hilo3 = new Thread(new ThreadStart(Tabla1));
            //Thread hilo4 = new Thread(new ThreadStart(Tabla2));
            //hilo3.Start();
            //hilo4.Start();

            Console.ReadLine();
        }



        static void Tabla1()
        {
            int cont = 1;
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 10; j++) 
                Console.WriteLine("Hilo 1: {0}x{1}={2}", i, j, i * j);
                cont++;           
            }
            
        }
        static void Tabla2()
        {
            int cont = 6;
            for (int i = 6; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                Console.WriteLine("Hilo 2: {0}x{1}={2}",i,j, i*j);
                cont++;
            }
        }

    }
}