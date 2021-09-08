using System;

namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            string miString = "15";
            //int valor1 = 15;
           // int valor2 = 10;
            string miSegundoString = "10";
            string resultado;
            //int res;
            resultado = miString + miSegundoString;
            //res = valor1 + valor2;
            int num1 = Int32.Parse(miString);
            int num2 = Int32.Parse(miSegundoString);
            int resultadote;
            resultadote = num1 + num2;
            Console.WriteLine(resultado);
            //Console.WriteLine(res);
            Console.WriteLine(resultadote);
            Console.Read();
        } 
    } 
}
