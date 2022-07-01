// See https://aka.ms/new-console-template for more information

using System;

namespace Menu
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al menu!, elige una de las siguientes opciones \n");
            char resp = default;
            do
            {
                Console.WriteLine("¿Que deseas hacer: ?\n 1-Comprar \n 2-Salir del menu\n");
                string s = null;
                Console.WriteLine("Deseas continuar? 's' o 'n' \n");
                Console.ReadLine();
            }
            while (resp == 's');
        }

    }
}