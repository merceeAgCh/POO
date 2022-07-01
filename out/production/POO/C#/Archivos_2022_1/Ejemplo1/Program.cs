using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;//Necesario para leer y escribir archivos

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.- Escribir un archivo
            Console.WriteLine("Paso 1: Escribir un archivo");
            string nombreArchivoNuevo = "prueba.txt";
            //StreamWriter escribirArchivo;//o sw
            FileStream stream = new FileStream(nombreArchivoNuevo, FileMode.OpenOrCreate, FileAccess.Write);//OpenOrCreate si no existe lo crea
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine("Esta es la primera línea del archivo.");
            writer.Close();
            Console.WriteLine("Paso 1 Terminado, presiona Enter para continuar...");
            Console.ReadLine();
            Console.Clear();


            //2.- escribir un archivo usando File
            Console.WriteLine("Paso 2: Escribir un archivo usando la clase File");
            string nombreArchivoNuevo2 = "pruebaFile.txt";
            StreamWriter writer2 = File.CreateText(nombreArchivoNuevo2);
            writer2.WriteLine("Este es mi Nuevo archivo creado.");
            writer2.WriteLine("Gracias");
            writer2.Close();
            Console.WriteLine("Paso 2 Terminado, presiona Enter para continuar...");
            Console.ReadLine();
            Console.Clear();


            //3.- Leer un archivo por línea
            Console.WriteLine("Paso 3: Leer un archivo por línea");
            string nombreArchivoLeer = "prueba.txt";
            StreamReader leerArchivo = new StreamReader(nombreArchivoLeer);
            string linea = leerArchivo.ReadLine(); //Leo la primera línea
            Console.WriteLine(linea);
            linea = leerArchivo.ReadLine(); //leo la sigueinte línea
            Console.WriteLine(linea);
            leerArchivo.Close();//cerramos el archivo
            Console.WriteLine("Paso 3 Terminado, presiona Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
            //
            //4.- Leer todo el archivo en una variable
            Console.WriteLine("Paso 4: Leer un archivo completo");
            string nombreLeer = "pruebaFile.txt";
            Console.WriteLine("Añadiendo texto con File...");
            File.AppendAllText(nombreLeer, "Esta línea se adicionó al final :O");
            leerArchivo = new StreamReader(nombreLeer);
            string lines = leerArchivo.ReadToEnd();
            Console.WriteLine("Leo todo el archivo: \n" + lines);
            leerArchivo.Close();
            Console.WriteLine("***************");            
            Console.WriteLine("Paso 4 Terminado, presiona Enter para continuar...");
            Console.ReadLine();
            Console.Clear();

            //5.- Leer archivo y procesar información
            Console.WriteLine("Paso 5: Procesar la información de un archivo");
            string[] lineas = new string[10];
            Console.WriteLine("Leyendo el archivo...");
            int contador = 0;
            nombreArchivoLeer = "datos.txt";
            try
            {
                StreamReader sr = new StreamReader(nombreArchivoLeer);
                //leo y verifico que no sea null (archivo vacío)

                while ((linea = sr.ReadLine()) != null)
                {
                    lineas[contador] = linea;
                    Console.WriteLine(linea);
                    contador++;
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al leer el archivo: " + e.Message);
            }
            Console.ReadLine();
            Console.WriteLine("Información obtenida:");
            for (int j = 0; j < contador; j++)
            {
                Console.WriteLine("Contenido de la Línea {0}: {1}", j + 1, lineas[j]);
            }
            //Proceso la información
            Console.ReadLine();
            Console.WriteLine("Inicia proceso de separación de datos...");
            string[] nombre = new string[contador];
            string[] apellido = new string[contador];
            string[] fuerza = new string[contador];
            string[] grupo = new string[contador];

            for (int i = 0; i < contador; i++)
            {
                //Separar el contenido de la slíneas con split y guardar en el archivo
                string[] datos = lineas[i].Split('|');
                for (int j = 0; j <= nombre.Length; j++)
                {
                    //Console.WriteLine("Datos :"+datos[i] +datos.Length+datos[0]);
                    if (j == 0)
                        nombre[i] = datos[j];
                    else if (j == 1)
                        apellido[i] = datos[j];
                    else if (j == 2)
                        fuerza[i] = datos[j];
                    else if (j == 3)
                        grupo[i] = datos[j];
                }
                Console.WriteLine("Linea {0} de datos procesada: nombre[{1}]: {2}, apellido[{1}]: {3}, fuerza[{1}]: {4}, grupo[{1}]: {5}",
                    i + 1, i, nombre[i], apellido[i], fuerza[i], grupo[i]);
            }
            Console.WriteLine("Paso 5 Terminado, presiona Enter para continuar...");
            Console.ReadLine();
      

            //6.- Actualizar el archivo
            Console.WriteLine("Paso 6: Actualizar el archivo");
            string newApellido, newFuerza;
            Console.Write("Ingresa el nuevo apellido de Luke: ");
            newApellido = Console.ReadLine();
            Console.Write("Ingresa el nuevo valor de fuerza de Luke: ");
            newFuerza = Console.ReadLine();
            //asigno los valores al arreglo
            apellido[0] = newApellido;
            fuerza[0] = newFuerza;
            //verifico cambios
            for (int i = 0; i < apellido.Length; i++)
                Console.WriteLine("Nombre: {0} Apellido: {1} Fuerza: {2} Facción: {3}", nombre[i], apellido[i], fuerza[i], grupo[i]);
            //creo mis cadenas de cada línea a guardar usando el separador
            string[] lineasAguardar = new string[apellido.Length];
            for (int i = 0; i < apellido.Length; i++)
            {
                lineasAguardar[i] = nombre[i] + "|" + apellido[i] + "|" + fuerza[i] + "|" + grupo[i];
            }
            File.WriteAllLines("guardado.txt", lineasAguardar);

            Console.WriteLine("Paso 1 Terminado, presiona Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Fin del programa :´)");
            Console.ReadLine();
        }
    }
}
