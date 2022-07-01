using System;
class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[5]; //declaramos la lista de numeros

        /*
         * Si queremos que se muestre el arreglo
         * con datos que conocemos, se hace de la siguiente forma
         * int[] nums = {2, 5, 33, 66, 12};
         * y la definicion de los elementos se elimina ya que no es necesaria
         */

        /*Definimos el valor a cada elemento con su respectivo indice*/
        nums[0] = 1;
        nums[1] = 2;
        nums[2] = 3;
        nums[3] = 4;
        nums[4] = 5;

        //Recorremos la lista mediante un for
        for(int i = 0; i < nums.Length; i++)
        {
            //imprimimos los elementos de la lista
            System.Console.WriteLine("El elemento " + "es igual a: " + nums[i]);
        }

        Console.ReadKey();
    }
}