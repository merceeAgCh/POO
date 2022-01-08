using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFinal
{
    public class Paneles
    {
        public bool listEm { get; private set; }
        public List<Admin> baseAdmin = new List<Admin>();
        public List<Empresa> Empresas = new List<Empresa>();
        public void AltaAdmin()
       {
           //podemos hacer lo siguiente//
           baseAdmin.Add(new Admin( "Kareem", 318259478, "Estudiante", "user003", "pass7894", "kareem@gmail.com", 5587496210));
           baseAdmin.Add(new Admin("Mariela", 318325961, "Estudiante", "user001", "pass1234", "mariela@gmail.com", 5586143837));
           baseAdmin.Add(new Admin("Ivan", 318592776, "Estudiante", "user002", "pass4567", "ivan@gmail.com", 5562070569));
       }
        public void AltaEmpresa()
        {
            Empresas.Add(new Empresa("OfficeDepot", "Ivan", "ivan@gmail.com", 5562070569, "user002", "pass4567"));
            Empresas.Add(new Empresa("HiperLumen", "Mariela", "mariela@gmail.com", 5586143837, "user001", "pass1234"));
            Empresas.Add(new Empresa("Epson", "Kareem", "kareem@gmail.com", 5587496210, "user003", "pass7894"));

        }
        public void panelAdmin() //CECAdmon  .  C3C&2116unam_4d00ñ
        {
            Console.WriteLine("1)Ver horarios \n2)Descargar horario\n3)Publicar horario\n4)Alta empresa\n5)Agregar empresa\n6)Editar empresa\n7)Asignar horarios\n8)Ver usuarios\n9)Alta administrador\n10)Eliminar administrador\n11)Salir\n");
            int op = int.Parse(Console.ReadLine());
            int opA = 0;
            do
            {
                opA = 0;
                switch (op)
                {
                    case 1:

                        Horario Horario1 = new Horario();
                        Horario1.VerHorarios();

                        break;
                    case 2:
                        Console.WriteLine("El archivo se ha descargado :D" +
                            "\n Presiona r para regresar");
                        char opR = Convert.ToChar(Console.ReadLine());
                        if (opR == 'r' || opR == 'R')
                        {
                            opA = 1;
                        }
                        else
                        {
                            Console.WriteLine("Caracter Ivalido ");

                        }

                        break;
                    case 3:// Que es lo que haria ??

                        Horario A1 = new Horario();
                        A1.leer("7D21.txt");


                        Console.WriteLine("--------------------");


                        Horario A2 = new Horario();
                        A2.leer("8D21.txt");
                        Console.WriteLine("--------------------");


                        Horario A3 = new Horario();
                        A3.leer("9D21.txt");
                        Console.WriteLine("--------------------");

                        Horario A4 = new Horario();
                        A4.leer("10D21.txt");

                        break; 

                    case 4: //Agregar elemento lista o arreglo 
                            //Altas Alta1 = new Altas();
                            //Alta1.imprimirAd(baseAdmin)
                        /*for (int i = 0; i < baseAdmin.Count; i++)
                        {
                            Console.WriteLine("\n " + baseAdmin);
                        }*/
                        /*oreach (var item in baseAdmin)
                        {
                            Console.WriteLine(item);
                        }*/
                        break;
                    case 5:
                        //Altas Alta2 = new Altas();
                        //Alta2.imprimirEm(Empresas);
                        /*for(int i=0;i<Empresas.Count;i++)
                        {
                            Console.WriteLine("\n " + Empresas);
                        }*/
                        /*foreach (var item in Empresas)
                        {
                            Console.WriteLine(item);
                        }*/
                        break;
                    case 6:
                        Empresa empresas = new Empresa();
                        empresas.Editardatos();
                        break;
                    case 7:
                        Horario ver = new Horario();
                        ver.VerHorarios();
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    default:
                        break;
                }
            } while (opA == 1);
        }
        public void panelEmpresa()
        {
            Console.WriteLine("Que deseas manejar:" + "\n1) Editar informacion" + "\n2)Reservar horario" + "\n3)Ver horario resrvados de la empresa " + "\n4)Salir");
            int Opn = int.Parse(Console.ReadLine());
            switch (Opn)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    Horario horario2 = new Horario();
                    horario2.VerHorarios();
                    break;

                default:

                    break;

            }


        }
    }
}
