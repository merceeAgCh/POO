using System;

namespace DiferenciasWrite_WriteLine
{
    class WriteWriteLine
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe tu nombre y presiona enter para continuar: \n");
            string name = Console.ReadLine();
            Console.WriteLine("Bienvenido " + name);
            Console.ReadKey();
        }
    }
}
