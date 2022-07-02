using Microsoft.VisualBasic;
using System;
using System.Collections;
namespace Lista_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opc = -1;
            /*
             * Creamos un menu para poder acceder a cada una de las opciones mencionadas
             * Este menu se creo con un switch case 
             */
            while (opc != 0)
            {
                Console.WriteLine("Selecione una opcion:");
                Console.WriteLine("[1] opcion 1: ArrayList");
                Console.WriteLine("[2] opcion 2 Queue");
                Console.WriteLine("[3] opcion 3: Stack");
                Console.WriteLine("[4] opcion 4: Error");
                Console.WriteLine("[5] opcion 5: For");
                Console.WriteLine("[6] opcion 5: Foreach");
                Console.WriteLine("[7] opcion 6: ArrayList");
                Console.WriteLine("[8] opcion 6: Queue");
                Console.WriteLine("[9] opcion 6: Stack");
                Console.WriteLine("[10] opcion 7: Demo de opcion 7 que invierte una arraylist");
                Console.WriteLine("[11] opcion 8: Funcion de retornar suma (Stack)");
                Console.WriteLine("[12] opcion 9: Positivos");
                Console.WriteLine("[13] opcion 10: Ocurrencias");
                Console.WriteLine("[0] - Salir");
                Console.Write("=> ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Presiona enter");
                        break;
                    case 1:
                        Opcion1();
                        break;
                    case 2:
                        Opcion2();
                        break;
                    case 3:
                        Opcion3();
                        break;
                    case 4:
                        Opcion4();
                        break;
                    case 5:
                        Opcion5For();
                        break;
                    case 6:
                        Opcion5Foreach();
                        break;
                    case 7:
                        Opcion6ArrayList();
                        break;
                    case 8:
                        Opcion6Queue();
                        break;
                    case 9:
                        Opcion6Stack();
                        break;
                    case 10:
                        testaOpcion7();
                        break;
                    case 11:
                        Opcion8Stack();
                        break;
                    case 12:
                        Opcion9();
                        break;
                    case 13:
                        Opcion10();
                        break;
                    default:
                        Console.Write("Cable");
                        Console.Clear();
                        Console.WriteLine("---x--- Opcion invalida! ---x---");
                        break;
                }
            }
            Console.ReadKey();
        }

        public static void Opcion1()
        {
            /*1 – Programa que lee n numeros enteros y los almacene en un ArrayList. 
            Calcule la suma aritmética y la media (use el comando FOR y luego el FOREACH).*/
            Console.Clear();

            ArrayList AL = new ArrayList();
            double suma = 0;
            int num = 0;

            Console.WriteLine("opcion 1");
            Console.Write("Cuantos números enteros desea insertar? \n=> ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los numeros");

            for (int i = 0; i < num; i++)
            {
                Console.Write("=> ");
                AL.Add(int.Parse(Console.ReadLine()));
            }
            AL.TrimToSize();
            foreach (int n in AL)
            {
                suma += n;
            }

            Console.WriteLine("suma = {0}", suma);
            Console.WriteLine("Média = {0}", suma / AL.Count);

            Console.Write("Presiona cualquier tecla para vovler al menu.....");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Opcion2()
        {
            /*
             * 2 – Programa que lee los n numeros enteros y los almacena en una cola. 
             * Calcular la suma y la media aritmética 
             * (utilizando el comando FOREACH para obtener información sobre los elementos)
            */
            Console.Clear();
            Console.WriteLine("opcion 2");

            Queue queue = new Queue();
            int num, qnt, suma = 0;
            double media;

            Console.Write("Cuantos números enteros desea insertar? \n=> ");
            qnt = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los numeros");

            for (int i = 0; i < qnt; i++)
            {
                Console.Write("=> ");
                num = int.Parse(Console.ReadLine());

                queue.Enqueue(num);
            }

            foreach (int numero in queue)
            {
                suma += numero;
            }
            media = suma / qnt;
            Console.WriteLine($"La suma es: {suma} y la media: {media}");

            Console.Write("Presiona cualquier tecla para vovler al menu.....");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Opcion3()
        {
            /*
             * 3 –Haga un programa que lea n entero números y los almacene en una pila. 
             * Calcular la suma y la media aritmética 
             * (utilice el comando FOREACH para obtener información sobre los elementos).	
             */
            Console.Clear();
            Console.WriteLine("opcion 3");

            Stack stack = new Stack();
            int num, qnt, suma = 0;
            double media;

            Console.Write("Cuantos números desea insertar? \n=> ");
            qnt = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los numeros");

            for (int i = 0; i < qnt; i++)
            {
                Console.Write("=> ");
                num = int.Parse(Console.ReadLine());

                stack.Push(num);
            }

            foreach (int numero in stack)
            {
                suma += numero;
            }
            media = suma / qnt;
            Console.WriteLine($"La suma es: {suma} y la media: {media}");

            Console.Write("Presiona cualquier tecla para vovler al menu.....");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Opcion4()
        {
            /*4 –Crear un programa que llene una ArrayList con elementos de diferentes 
             * tipos (int, doble, float, booleano, string). 
             * Intenta calcular la suma de los elementos. 
             * Por supuesto, esto causará un mensaje de error. 
             * ¿Qué mensaje devuelve Visual Studio?
             */
            Console.Clear();
            Console.WriteLine("opcion 4");

            int suma = 0;

            ArrayList al = new ArrayList() { 1, 2, 1.2, 3.10, "C#", "teste", false, true };
            try
            {
                foreach (int posicao in al)
                    suma += posicao;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error generado {0}", ex);
            }

            Console.Write("Presiona cualquier tecla para vovler al menu.....");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Opcion5For()
        {
            /*5 – Haga un programa que llene una ArrayList con los números entre 1 y 25. Usted pregunta:
                • Imprimir todos los elementos
                • Imprima todos los elementos en orden inverso
                • Imprima todos los elementos en posiciones impares (elemento de posición 1, 3, 5, ...)
                • Imprimir todos los elementos impares
                • Imprima solo los elementos de la primera mitad del vector (posición 0 a 12).
             */

            ArrayList numeros = new ArrayList();
            for (int i = 1; i <= 25; i++)
            {
                numeros.Add(i);
            }

            //Imprimimos todos los elementos
            Console.WriteLine("Imprimiendo todos os elementos");
            for (int num = 0; num < numeros.Count; num++)
                Console.Write($"{numeros[num]}, ");
            Console.WriteLine();

            //Impresion en orden invertido
            numeros.Reverse();
            Console.WriteLine("Imprimiendo todos os elementos em ordem invertida");
            for (int num = 0; num < numeros.Count; num++)
                Console.Write($"{numeros[num]}, ");
            Console.WriteLine();
            numeros.Reverse();

            //impresion de posiciones impares
            Console.WriteLine("Imprimiendo todos los elementos em posiciones impares");
            for (int num = 0; num < numeros.Count; num++)
                if (num % 2 != 0)
                    Console.Write($"{numeros[num]}, ");
            Console.WriteLine();

            //Imprime todos los elementos ímpares
            Console.WriteLine("Imprimiendo todos los elementos ímpares");
            for (int num = 0; num < numeros.Count; num++)
                if ((int)numeros[num] % 2 != 0)
                    Console.Write($"{numeros[num]}, ");
            Console.WriteLine();

            //Imprime solo los elementos de la primera mitad del vector (posición 0 a 12).
            Console.WriteLine("Imprimiendo todos los elementos da primeira metade do vetor");
            for (int num = 0; num < numeros.Count / 2; num++)
                Console.Write($"{numeros[num]}, ");
            Console.WriteLine();

            Console.WriteLine("Presiona cualquier tecla para vovler al menu.....");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Opcion5Foreach()
        {
            /*5 – 
             * Haga un programa que llene una ArrayList con los números entre 1 y 25. Usted pregunta:
             * • Imprimir todos los elementos
             * • Imprima todos los elementos en orden inverso
             * • Imprima todos los elementos en posiciones impares (elemento de posición 1, 3, 5, ...)
             * • Imprimir todos los elementos impares
             * • Imprima solo los elementos de la primera mitad del vector (posición 0 a 12).
            */

            ArrayList numeros = new ArrayList();
            for (int i = 1; i <= 25; i++)
            {
                numeros.Add(i);
            }

            //Imprimiendo todos los elementos
            Console.WriteLine("Imprimiendo todos los elementos");
            foreach (int num in numeros)
                Console.Write($"{num}, ");
            Console.WriteLine();

            //Imprimiendo en orden invertida
            numeros.Reverse();
            Console.WriteLine("Imprimiendo todos los elementos em ordem invertida");
            foreach (int num in numeros)
                Console.Write($"{num}, ");
            Console.WriteLine();
            numeros.Reverse();

            //imprime en posiciones impares
            Console.WriteLine("Imprimiendo todos los elementos em posiciones impares");
            int qnt = numeros.Count - 1;
            foreach (int num in numeros)
            {
                if (qnt % 2 != 0)
                    Console.Write($"{num}, ");
                qnt--;
            }
            Console.WriteLine();

            //Imprima todos los elementos ímpares
            Console.WriteLine("Imprimiendo todos los elementos ímpares");
            foreach (int num in numeros)
                if (num % 2 != 0)
                    Console.Write($"{num}, ");
            Console.WriteLine();

            //Imprima apenas los elementos da primeira metade do vetor (posição 0 a 12).
            Console.WriteLine("Imprimiendo todos los elementos da primeira metade do vetor");
            qnt = numeros.Count / 2;
            foreach (int num in numeros)
            {
                if (qnt >= 0)
                    Console.Write($"{num}, ");
                qnt--;
            }

            Console.WriteLine();

            Console.WriteLine("Presiona cualquier tecla para vovler al menu.....");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Opcion6ArrayList()
        {
            /*6 -
             * Hacer un programa que genere una colección con n entero números entero aleatorios 
             * (el valor de n debe ser informado por el usuario al comienzo de la ejecución 
             * del programa. Imprimir los elementos de la colección.
             */
            int n;
            Random random = new Random();
            Console.WriteLine("opcion 6");
            Console.Write("Cuantos números desea ingresar? \n=> ");
            n = int.Parse(Console.ReadLine());

            ArrayList colec = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                colec.Add(random.Next(0, 200));
            }
            foreach (int i in colec)
            {
                Console.WriteLine(i);
            }
        }
        public static ArrayList Opcion7(ArrayList colec)
        {
            Stack stack = new Stack();


            foreach (int i in colec)
            {
                stack.Push(i);
            }

            colec.Clear();
            foreach (int i in stack)
            {
                colec.Add(i);
            }
            return colec;
        }
        public static void Opcion6Queue()
        {
            /*6 -Hacer un programa que genere una colección con n entero números entero aleatorios
             * (el valor de n debe ser informado por el usuario al 
             * comienzo de la ejecución del programa. Se imprimen los elementos de la colección. 
             */
            int n;
            Random random = new Random();
            Console.WriteLine("opcion 6");
            Console.Write("Cuantos números desea ingresar? \n=> ");
            n = int.Parse(Console.ReadLine());

            Queue colec = new Queue();
            for (int i = 0; i < n; i++)
            {
                colec.Enqueue(random.Next(0, 200));
            }
            foreach (int i in colec)
            {
                Console.WriteLine(i);
            }
        }
        public static void Opcion6Stack()
        {
            /*6 - Hacer un programa que genere una colección con n entero números entero aleatorios (el valor de n debe ser
            informado por el usuario al comienzo de la ejecución del programa. Imprima los elementos de la colección.*/
            int n;
            Random random = new Random();
            Console.WriteLine("opcion 6");
            Console.Write("Cuantos números desea ingresar? \n=> ");
            n = int.Parse(Console.ReadLine());

            Stack colec = new Stack();
            for (int i = 0; i < n; i++)
            {
                colec.Push(random.Next(0, 200));
            }
            foreach (int i in colec)
            {
                Console.WriteLine(i);
            }
        }



        public static void testaOpcion7()
        {
            ArrayList al = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("ArrayList original");
            foreach (int i in al)
                Console.Write($"{i} -");
            Opcion7(al);
            Console.WriteLine();

            Console.WriteLine("ArrayList invertido");
            foreach (int i in al)
                Console.Write($"{i} -");
            Console.WriteLine();

            Console.Write("Presiona cualquier tecla para vovler al menu.....");
            Console.ReadKey();
            Console.Clear();
        }

        public static int sumaOpcion8(Stack st)
        {
            int suma = 0;

            foreach (int num in st)
            {
                suma += num;
            }


            return suma;
        }

        public static void Opcion8Stack()
        {
            /*8 - Cree un Funcion que reciba la colección como parámetro y vuelva a la suma de sus elementos
             * NOTA: Tenga en cuenta que todos sus datos son de tipo int.
             */
            Console.Clear();
            Console.WriteLine("opcion 8 - Stack");

            int qtd;
            Stack st = new Stack();

            Console.Write("Cuantos números desea sumar? \n=> ");
            qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los numeros");
            for (int i = 0; i < qtd; i++)
            {
                Console.Write("=> ");
                st.Push(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Suma dos elementos da Stack = " + sumaOpcion8(st));

            Console.Write("Presiona cualquier tecla para vovler al menu.....");



            Console.ReadKey();
            Console.Clear();
        }

        public static int Opcion9ElPositivos(ArrayList Al)
        {
            /*
             * Crear una Funcion que calcule el número de elementos positivos
             * de una colección pasada como parámetro.
             */
            int num = 0;
            foreach (int i in Al)
                if (i > 0)
                    num++;
            return num;

        }

        public static void Opcion9()
        {

            Console.Clear();
            ArrayList A = new ArrayList();
            A.Add(5);
            A.Add(10);
            A.Add(15);
            A.Add(15);
            A.Add(-3);

            Console.WriteLine("\nEl numero de elementos positivos es{0}", Opcion9ElPositivos(A));
            Console.Write("Presiona cualquier tecla para vovler al menu.....");
            Console.ReadKey();
            Console.Clear();

        }

        public static int Opcion10Ocorrencias(ArrayList Al, int n)
        {
            /*Funcion que calcule el número de Ocurrencias
             * en una colección de un elemento pasado como parámetro.
             */
            int elm = 0;

            foreach (int i in Al)
                if (i == n)
                    elm++;
            return elm;
        }

        public static void Opcion10()
        {

            Console.Clear();
            ArrayList A = new ArrayList() { 5, 10, 15, 15, -3 };

            Console.WriteLine("El numero de Ocurrencias es{0}", Opcion10Ocorrencias(A, 15));

            Console.Write("Presiona cualquier tecla para vovler al menu.....");
            Console.ReadKey();
            Console.Clear();
        }
    }
}