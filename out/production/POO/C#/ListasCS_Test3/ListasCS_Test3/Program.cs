using System;
using System.Collections.Generic;

class Lista
{
    static void Main(string[] args)
    {
        //definimos nuestra lista
        var list = new List<string>();

        //añadimos elementos a la lista
        list.Add("Elemento 1 de la lista");
        list.Add("Elemento 2 de la lista");
        //editamos un elemento de la lista
        list[1] = "Editando el elemento";

        //recorrer los elementos de la lista (impresion)
        foreach (var x in list)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine("===============================");
        //nos retornara el total de elementos
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
        //eliminamos elementos
        list.RemoveAt(0);
        Console.WriteLine("===============================");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
        //Podemos eliminar diciendo el elemento string
        list.Remove("Editando el elemento");
        Console.WriteLine("===============================");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }


        Console.ReadKey();
    }
}