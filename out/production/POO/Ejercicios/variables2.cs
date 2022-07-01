using System;

namespace Variables2
{
    class variables2
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int i = new int(), j = 0; //Variables de tipo entero
            double m = 4, n = 3.1, p = 8D; //Variables reales
            long h, k; // TODO ¿que tipo de variables son?
            h = 6;
            k = 2L;
            //Realizacion de invocaciones legales
            System.Console.WriteLine("i=" + i + '\r' + '\n' + "i+j=");
            System.Console.WriteLine(i + j);
            System.Console.WriteLine(m * n + p);
            System.Console.WriteLine(System.Math.Pow(k, h));
        }
    }
}
