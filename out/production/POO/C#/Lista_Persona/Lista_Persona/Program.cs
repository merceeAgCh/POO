using System;
using System.Collections.Generic;

public class Persona
{
    public int id;
    public string name;
    public int age;

    public override string ToString()
    {
        return "El id es: " + id + " \nSu edad es:" + age + "\nNombre:  " + name;
    }
}
class ListaA
{
    static void Main(string[] args)
    {
        //creamos lista
        var listaA = new List<Persona>();

        listaA.Add(new Persona { age =24, id = 186, name = "Mercedes"});
        listaA.Add(new Persona { age =16, id = 94, name = "Pepito"});
        //creo una lista nueva agregando una persona mas
        var list2 = new List<Persona>();
        list2.Add(new Persona { age = 7, id = 3, name = "Modif" });
        //impresion de la variable "list2"
        foreach (var ele in list2)
        {
            Console.WriteLine(ele);
        }
        //impresion de la lista "listaA"
        foreach (var el in listaA)
        {
            Console.WriteLine(el);
        }
        //eliminacion del elemento ubicado en el indice 0
        listaA.RemoveAt(0);
        Console.WriteLine("===============================");
        for (int i = 0; i < listaA.Count; i++)
        {
            Console.WriteLine(listaA[i]);
        }

        Console.ReadKey();
    }
}