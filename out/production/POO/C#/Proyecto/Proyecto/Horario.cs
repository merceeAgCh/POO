using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProyectoFinal
{
    public class Horario : Empresa
    {
        string IdHorario;
        string sala;
        string dia;
        string horario; //se daran opciones para los horarios 
        // string empresa; hereda de empresa 
        string nomPonencia;

        public Horario(string Id,string salas,string dias,string horarios,string nomPonencias)
        {
            this.IdHorario = Id;
            this.sala = salas;
            this.dia = dias;
            this.horario = horarios;
            this.nomPonencia = nomPonencias;
        }
        public Horario()
        {

        }

        public void getIdHorario()
        {

        } //Para que sirve???
        public void setIdHorario(String id)
        {
            this.IdHorario = id;
            Console.WriteLine("El Id de Horario es: " + id);
        }
        public void getSala()
        {

        }
        public void setSala(String salaa)
        {
            this.IdHorario = salaa;
            Console.WriteLine("La sala es: " + salaa);
        }
        public void getHorario()
        {

        }
        public void setHorario(string horario)
        {
            this.horario = horario;
            Console.WriteLine("El horario es: " + horario);
        }
        public void getNomPonencia()
        {
            Console.WriteLine();
        }
        public void setNomPonencia(string nomPonencia)
        {
            this.nomPonencia = nomPonencia;
            Console.WriteLine("El horario es: " + nomPonencia);
        }
        public int leer(string name )
        {

            //3.- Leer un archivo por línea
            Console.WriteLine("\t\tLista de Horarios: ");
            string nombreArchivoLeer = name; //Como hacer para que el usuario ingrese el nombre del archivo??????
            StreamReader leerArchivo = new StreamReader(nombreArchivoLeer);
            string linea = leerArchivo.ReadLine(); //Leo la primera línea
            string[] lineas = new string[100];
            int contador = 0;
            //nombreArchivoLeer = "8D21.txt";
            try
            {
                StreamReader sr = new StreamReader(nombreArchivoLeer);
                //leo y verifico que no sea null (archivo vacío)

                while ((linea = sr.ReadLine()) != null)
                {
                    lineas[contador] = linea;
                    //Console.WriteLine(linea);
                    contador++;
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al leer el archivo: " + e.Message);
            }
            string[] idSala = new string[contador];  
            string[] sala = new string[contador]; 
            string[] dia = new string[contador]; 
            string[] hora = new string[contador];
            string[] titulo = new string[contador];
            string[] ponente = new string[contador];

            for (int i = 0; i < contador; i++)
            {
                //Separar el contenido de la slíneas con split y guardar en el archivo
                string[] datos = lineas[i].Split('|');
                for (int j = 0; j <= 100; j++)
                {
                    if (j == 0)
                        idSala[i] = datos[j]; 
                    else if (j == 1)
                        sala[i] = datos[j];
                    else if (j == 2)
                        dia[i] = datos[j];
                    else if (j == 3)
                        hora[i] = datos[j];
                    else if (j == 4)
                        titulo[i] = datos[j];
                    else if (j == 5)
                        ponente[i] = datos[j];
                }
                Console.WriteLine("idSala: {2}, \tSala:{3}, \tDía: {4}, \tHora: {5}, \tTitulo: {6}, \tPonente: {7}\n",
                    i + 1, i, idSala[i], sala[i], dia[i], hora[i], titulo[i], ponente[i]);
            }
            Console.ReadLine();
            Console.WriteLine(contador);
            return contador;
        }
        public void VerHorarios()
        {
            Console.WriteLine("Indica el dia que nombre del archivo del dia que deceas ....: " +
               "\n 1)Ingrese '7D21.txt' Para el dia 7 de Dic" +
               "\n 2)Ingrese '8D21.txt' para el dia 8 de Dic" +
               "\n 3)Ingrese '9D21.txt' para el dia 9 de Dic" +
               "\n 4)Ingrese '10D21.txt' para el día 10 de Dic");

            int sala = Convert.ToInt32(Console.ReadLine());
            int horario = 0;
            int k;
            switch (sala)
            {
                case 1:
                    int i, j;
                    string[] lineas = new string[10];
                    string linea;
                    int contador = 0;
                    string nombreArchivoleer = "Diauno.txt";
                    try
                    {
                        StreamReader sr = new StreamReader(nombreArchivoleer);
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
                    for (j = 0; j < contador; j++)
                    {
                        Console.WriteLine("Contenido de la Línea {0}: {1}", j + 1, lineas[j]);
                    }
                    Console.WriteLine("Inicia proceso de separación de datos...");
                    string[] idSala = new string[contador];
                    string[] Sala = new string[contador];
                    string[] dia = new string[contador];
                    string[] hora = new string[contador];
                    string[] titulo = new string[contador];
                    string[] ponente = new string[contador];
                    for (i = 0; i < contador; i++)
                    {
                        string[] Diauno = lineas[i].Split('|');
                        for (j = 0; j <= 10; j++)
                        {
                            /*if (j != 0)
                                continue;*/
                            idSala[i+1] = Diauno[j];
                            /*else if (j == 1)
                                Sala[i] = Diauno[j+1];
                            else if (j == 2)
                                dia[i] = Diauno[j];
                            else if (j == 3)
                                hora[i] = Diauno[j];
                            else if (j == 4)
                                titulo[i] = Diauno[j];
                            else if (j == 5)
                                ponente[i] = Diauno[j];*/
                        }
                        Console.WriteLine("Linea {0} de datos procesada: idSala[{1}]: {2}, sala[{1}]: {3}, dia[{1}]: {4}, hora[{1}]: {5} titulo[{1}]: {6} ponente[{1}]: {7}",
                           i + 1, i, idSala[i], Sala[i], dia[i], hora[i], titulo[i], ponente[i]);
                    }
                    Console.WriteLine("¿Qué horario deseas reservar?: " +
                        "\n1) 9 a 11 am" +
                        "\n2) 11 a 13:00 am" +
                        "\n3) 13 a 2 pm " +
                        "\n4) 2:10 a 3:30 pm " +
                        "\n5) 3:40 a 5 pm" +
                        "\n6) 5 a 7pm");
                    horario = Convert.ToInt32(Console.ReadLine());
                    switch (horario)
                    {
                        case 1:
                            Console.WriteLine("El horario ya esta lleno");
                            Console.WriteLine("Ingrese otra horario");
                            break;
                        case 2:
                            Console.WriteLine("El horario ya esta lleno");
                            Console.WriteLine("Ingrese otra horario");
                            break;
                        case 3:
                            string newTitulo, newPonente;
                            Console.WriteLine("Ingrese el titulo de la ponencia: ");
                            newTitulo = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del ponente: ");
                            newPonente = Console.ReadLine();
                            titulo[2] = newTitulo;
                            ponente[2] = newPonente;
                            for (i = 0; i < titulo.Length; i++)
                            {
                                Console.WriteLine("idSala: {0} sala: {1} dia: {2} hora: {3} titulo: {4} ponente: {5}", idSala[i], Sala[i], dia[i], hora[i], titulo[i], ponente[i]);
                            }
                            string[] lineasAguardar = new string[titulo.Length];
                            for (i = 0; i < titulo.Length; i++)
                            {
                                lineasAguardar[i] = idSala[i] + "," + Sala[i] + "," + dia[i] + "," + hora[i] + "," + titulo[i] + "," + ponente[i];
                            }
                            File.WriteAllLines("Diauno.txt", lineasAguardar);
                            break;
                        case 4:
                            Console.WriteLine("Ingrese el titulo de la ponencia: ");
                            newTitulo = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del ponente: ");
                            newPonente = Console.ReadLine();
                            titulo[3] = newTitulo;
                            ponente[3] = newPonente;
                            for (i = 0; i < titulo.Length; i++)
                            {
                                Console.WriteLine("idSala: {0} sala: {1} dia: {2} hora: {3} titulo: {4} ponente: {5}", idSala[i], Sala[i], dia[i], hora[i], titulo[i], ponente[i]);
                            }
                            string[] lineasAguarda = new string[titulo.Length];
                            for (i = 0; i < titulo.Length; i++)
                            {
                                lineasAguarda[i] = idSala[i] + "," + Sala[i] + "," + dia[i] + "," + hora[i] + "," + titulo[i] + "," + ponente[i];
                            }
                            File.WriteAllLines("Diauno.txt", lineasAguarda);
                            break;
                        case 5:
                            Console.WriteLine("Ingrese el titulo de la ponencia: ");
                            newTitulo = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del ponente: ");
                            newPonente = Console.ReadLine();
                            titulo[4] = newTitulo;
                            ponente[4] = newPonente;
                            for (i = 0; i < titulo.Length; i++)
                            {
                                Console.WriteLine("idSala: {0} sala: {1} dia: {2} hora: {3} titulo: {4} ponente: {5}", idSala[i], Sala[i], dia[i], hora[i], titulo[i], ponente[i]);
                            }
                            string[] lineasAguardara = new string[titulo.Length];
                            for (i = 0; i < titulo.Length; i++)
                            {
                                lineasAguardara[i] = idSala[i] + "," + Sala[i] + "," + dia[i] + "," + hora[i] + "," + titulo[i] + "," + ponente[i];
                            }
                            File.WriteAllLines("Diauno.txt", lineasAguardara);
                            break;
                        case 6:
                            Console.WriteLine("Ingrese el titulo de la ponencia: ");
                            newTitulo = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del ponente: ");
                            newPonente = Console.ReadLine();
                            titulo[4] = newTitulo;
                            ponente[4] = newPonente;
                            for (i = 0; i < titulo.Length; i++)
                            {
                                Console.WriteLine("idSala: {0} sala: {1} dia: {2} hora: {3} titulo: {4} ponente: {5}", idSala[i], Sala[i], dia[i], hora[i], titulo[i], ponente[i]);
                            }
                            string[] lineasAguardaras = new string[titulo.Length];
                            for (i = 0; i < titulo.Length; i++)
                            {
                                lineasAguardaras[i] = idSala[i] + "," + Sala[i] + "," + dia[i] + "," + hora[i] + "," + titulo[i] + "," + ponente[i];
                            }
                            File.WriteAllLines("Diauno.txt", lineasAguardaras);
                            break;
                    }
                    break;
                case 2:
                    /*Horario read2 = new Horario();
                    read2.leer("8D21.txt");*/
                    string[] lineass = new string[100];
                    string line;
                    int contadors = 0;
                    string nombreArchivoleers = "Diados.txt";
                    try
                    {
                        StreamReader sr = new StreamReader(nombreArchivoleers);
                        while ((line = sr.ReadLine()) != null)
                        {
                            lineass[contadors] = line;
                            Console.WriteLine(line);
                            contadors++;
                        }
                        sr.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error al leer el archivo: " + e.Message);
                    }
                    Console.ReadLine();
                    for (j = 0; j < contadors; j++)
                    {
                        Console.WriteLine("Contenido de la Línea {0}: {1}", j + 1, lineass[j]);
                    }
                    string[] idSalas = new string[contadors];
                    string[] salas = new string[contadors];
                    string[] dias = new string[contadors];
                    string[] horas = new string[contadors];
                    string[] titulos = new string[contadors];
                    string[] ponentes = new string[contadors];
                    for (i = 0; i < contadors; i++)
                    {
                        string[] datos = lineass[i].Split('|');
                        for (j = 0; j <= titulos.LongLength; j++)
                        {
                            if (j == 0)
                                idSalas[i++] = datos[j];
                            else if (j == 1)
                                salas[i++] = datos[j]+datos[j];
                            else if (j == 2)
                                dias[i] = datos[j];
                            else if (j == 3)
                                horas[i] = datos[j];
                            else if (j == 4)
                                titulos[i] = datos[j];
                            else if (j == 5)
                                ponentes[i] = datos[j];
                        }
                        Console.WriteLine("Linea {0} de datos procesada: idSala[{1}]: {2}, sala[{1}]: {3}, dia[{1}]: {4}, hora[{1}]: {5} titulo[{1}]: {6} ponente[{1}]: {7}",
                   i + 1, i, idSalas[i], salas[i], dias[i], horas[i], titulos[i], ponentes[i]);
                    }
                        Console.WriteLine("Inicia proceso de separación de datos...");
                    Console.WriteLine("¿Qué horario deseas reservar?: " +
                       "\n1) 9 a 10 am" +
                       "\n2) 10 a 11:30 am" +
                       "\n3) 12 a 2 pm " +
                       "\n4) 2:10 a 3:30 pm " +
                       "\n5) 3:40 a 5 pm" +
                       "\n6) 5 a 7pm");
                    horario = Convert.ToInt32(Console.ReadLine());
                    switch (horario)
                    {
                        case 1:
                            string newTitulo1, newPonente1;
                            Console.WriteLine("Ingrese el titulo de la ponencia: ");
                            newTitulo1 = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del ponente: ");
                            newPonente1 = Console.ReadLine();
                            titulos[0] = newTitulo1;
                            ponentes[0] = newPonente1;
                            for (i = 0; i < titulos.LongLength; i++)
                            {
                                Console.WriteLine("idSala: {0} sala: {1} dia: {2} hora: {3} titulo: {4} ponente: {5}", idSalas[i], salas[i], dias[i], horas[i], titulos[i], ponentes[i]);
                            }
                            string[] lineasAguardar1 = new string[titulos.Length];
                            for (i = 0; i < titulos.LongLength; i++)
                            {
                                lineasAguardar1[i] = idSalas[i] + "," + salas[i] + "," + dias[i] + "," + horas[i] + "," + titulos[i] + "," + ponentes[i];
                            }
                            File.WriteAllLines("Diados.txt", lineasAguardar1);
                            break;
                        case 2:
                            string newTitulo2, newPonente2;
                            Console.WriteLine("Ingrese el titulo de la ponencia: ");
                            newTitulo2 = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del ponente: ");
                            newPonente2 = Console.ReadLine();
                            titulos[1] = newTitulo2;
                            ponentes[1] = newPonente2;
                            for (i = 0; i < titulos.Length; i++)
                            {
                                Console.WriteLine("idSala: {0} sala: {1} dia: {2} hora: {3} titulo: {4} ponente: {5}", idSalas[i], salas[i], dias[i], horas[i], titulos[i], ponentes[i]);
                            }
                            string[] lineasAguardar2 = new string[titulos.Length];
                            for (i = 0; i < titulos.Length; i++)
                            {
                                lineasAguardar2[i] = idSalas[i] + "," + salas[i] + "," + dias[i] + "," + horas[i] + "," + titulos[i] + "," + ponentes[i];
                            }
                            File.WriteAllLines("8D21.txt", lineasAguardar2);
                            break;
                        case 3:
                            string newTitulo3, newPonente3;
                            Console.WriteLine("Ingrese el titulo de la ponencia: ");
                            newTitulo3 = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del ponente: ");
                            newPonente3 = Console.ReadLine();
                            titulos[2] = newTitulo3;
                            ponentes[2] = newPonente3;
                            for (i = 0; i < titulos.Length; i++)
                            {
                                Console.WriteLine("idSala: {0} sala: {1} dia: {2} hora: {3} titulo: {4} ponente: {5}", idSalas[i], salas[i], dias[i], horas[i], titulos[i], ponentes[i]);
                            }
                            string[] lineasAguardar3 = new string[titulos.Length];
                            for (i = 0; i < titulos.Length; i++)
                            {
                                lineasAguardar3[i] = idSalas[i] + "," + salas[i] + "," + dias[i] + "," + horas[i] + "," + titulos[i] + "," + ponentes[i];
                            }
                            File.WriteAllLines("8D21.txt", lineasAguardar3);
                            break;
                        case 4:
                            string newTitulo4, newPonente4;
                            Console.WriteLine("Ingrese el titulo de la ponencia: ");
                            newTitulo4 = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del ponente: ");
                            newPonente4 = Console.ReadLine();
                            titulos[3] = newTitulo4;
                            ponentes[3] = newPonente4;
                            for (i = 0; i < titulos.Length; i++)
                            {
                                Console.WriteLine("idSala: {0} sala: {1} dia: {2} hora: {3} titulo: {4} ponente: {5}", idSalas[i], salas[i], dias[i], horas[i], titulos[i], ponentes[i]);
                            }
                            string[] lineasAguardar4 = new string[titulos.Length];
                            for (i = 0; i < titulos.Length; i++)
                            {
                                lineasAguardar4[i] = idSalas[i] + "," + salas[i] + "," + dias[i] + "," + horas[i] + "," + titulos[i] + "," + ponentes[i];
                            }
                            File.WriteAllLines("8D21.txt", lineasAguardar4);
                            break;
                        case 5:
                            string newTitulo5, newPonente5;
                            Console.WriteLine("Ingrese el titulo de la ponencia: ");
                            newTitulo5 = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del ponente: ");
                            newPonente5 = Console.ReadLine();
                            titulos[4] = newTitulo5;
                            ponentes[4] = newPonente5;
                            for (i = 0; i < titulos.Length; i++)
                            {
                                Console.WriteLine("idSala: {0} sala: {1} dia: {2} hora: {3} titulo: {4} ponente: {5}", idSalas[i], salas[i], dias[i], horas[i], titulos[i], ponentes[i]);
                            }
                            string[] lineasAguardar5 = new string[titulos.Length];
                            for (i = 0; i < titulos.Length; i++)
                            {
                                lineasAguardar5[i] = idSalas[i] + "," + salas[i] + "," + dias[i] + "," + horas[i] + "," + titulos[i] + "," + ponentes[i];
                            }
                            File.WriteAllLines("9D21.txt", lineasAguardar5);
                            break;
                        case 6:
                            string newTitulo6, newPonente6;
                            Console.WriteLine("Ingrese el titulo de la ponencia: ");
                            newTitulo6 = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del ponente: ");
                            newPonente6 = Console.ReadLine();
                            titulos[5] = newTitulo6;
                            ponentes[5] = newPonente6;
                            for (i = 0; i < titulos.Length; i++)
                            {
                                Console.WriteLine("idSala: {0} sala: {1} dia: {2} hora: {3} titulo: {4} ponente: {5}", idSalas[i], salas[i], dias[i], horas[i], titulos[i], ponentes[i]);
                            }
                            string[] lineasAguardar6 = new string[titulos.Length];
                            for (i = 0; i < titulos.Length; i++)
                            {
                                lineasAguardar6[i] = idSalas[i] + "," + salas[i] + "," + dias[i] + "," + horas[i] + "," + titulos[i] + "," + ponentes[i];
                            }
                            File.WriteAllLines("9D21.txt", lineasAguardar6);
                            break;
                    }

                    break;
                case 3:

                    /*Horario read3 = new Horario();
                    read3.leer("9D21.txt");*/
                    string[] lineasss = new string[100];
                    string lines;
                    int contadorss = 0;
                    string nombreArchivoleerss = "9D21.txt";
                    try
                    {
                        StreamReader sr = new StreamReader(nombreArchivoleerss);
                        while ((line = sr.ReadLine()) != null)
                        {
                            lineasss[contadorss] = line;
                            Console.WriteLine(line);
                            contadorss++;
                        }
                        sr.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error al leer el archivo: " + e.Message);
                    }
                    Console.ReadLine();
                    for (j = 0; j < contadorss; j++)
                    {
                        Console.WriteLine("Contenido de la Línea {0}: {1}", j + 1, lineasss[j]);
                    }
                    string[] idSalass = new string[contadorss];
                    string[] salass = new string[contadorss];
                    string[] diass = new string[contadorss];
                    string[] horass = new string[contadorss];
                    string[] tituloss = new string[contadorss];
                    string[] ponentess = new string[contadorss];
                    for (i = 0; i < contadorss; i++)
                    {
                        string[] datos = lineasss[i].Split('|');
                        for (j = 0; j <= idSalass.Length; j++)
                        {
                            if (j == 0)
                                idSalass[i] = datos[j];
                            else if (j == 1)
                                salass[i] = datos[j];
                            else if (j == 2)
                                diass[i] = datos[j];
                            else if (j == 3)
                                horass[i] = datos[j];
                            else if (j == 4)
                                tituloss[i] = datos[j];
                            else if (j == 5)
                                ponentess[i] = datos[j];
                        }
                        Console.WriteLine("Linea {0} de datos procesada: idSala[{1}]: {2}, sala[{1}]: {3}, dia[{1}]: {4}, hora[{1}]: {5} titulo[{1}]: {6} ponente[{1}]: {7}",
                   i + 1, i, idSalass[i], salass[i], diass[i], horass[i], tituloss[i], ponentess[i]);
                    }
                    Console.WriteLine("¿Qué horario deseas reservar?: " +
                       "\n1) 9 a 10 am" +
                       "\n2) 10 a 11:30 am" +
                       "\n3) 12 a 2 pm " +
                       "\n4) 2:10 a 3:30 pm " +
                       "\n5) 3:40 a 5 pm" +
                       "\n6) 5 a 7pm");
                    horario = Convert.ToInt32(Console.ReadLine());
                    switch (horario)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;

                    }

                    break;
                case 4:
                    /*Horario read4 = new Horario();
                    read4.leer("10D21.txt");*/
                    
            
                    Console.WriteLine("¿Qué horario deseas reservar?: " +
                       "\n1) 9 a 10 am" +
                       "\n2) 10 a 11:30 am" +
                       "\n3) 12 a 2 pm " +
                       "\n4) 2:10 a 3:30 pm " +
                       "\n5) 3:40 a 5 pm" +
                       "\n6) 5 a 7pm");
                    horario = Convert.ToInt32(Console.ReadLine());
                    switch (horario)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;

                    }
                    break;

            }
        }
    }
}
