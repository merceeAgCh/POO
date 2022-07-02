using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ProyectoFinal
{
    public class Altas : Admin
    {
        private const int V = 0;

        //Guardar usuarios
        //public List<Admin> baseAdmin = new List<Admin>();
        // public static string[] Empresas = new string[3];
        public List<Empresa>[] Empresas = new List<Empresa>[3];
        //empresas[0] = new List<Empresa> ("Kareem", 318259478, "Estudiante", "user003", "pass7894", "kareem@gmail.com", 5587496210);
        //public static List<Empresa> OfficeDepot = new List<Empresa>(); // almacena a todos aquellos ponentes o trabajadores de esta empresa 
        //public static List<Empresa> HiperLumen = new List<Empresa>();
        //public static List<Empresa> Epson = new List<Empresa>();
        //public static List<Empresa> Hp = new List<Empresa>();
        //public static List<Empresa> Lenovo = new List<Empresa>();
        //public static List<Empresa> Asus = new List<Empresa>();
        //public static List<Empresa> TpLink = new List<Empresa>();
        //public static List<Empresa> Cisco = new List<Empresa>();
        // public static Empresa Empresa1 = new Empresa("OfficeDepot", "Ivan", "ivan@gmail.com", 5562070569, "user002", "pass4567");

        //Métodos
        /*public void AltaAdmin()
        {
            //podemos hacer lo siguiente//

            baseAdmin.Add(new Admin( "Kareem", 318259478, "Estudiante", "user003", "pass7894", "kareem@gmail.com", 5587496210));
            baseAdmin.Add(new Admin("Mariela", 318325961, "Estudiante", "user001", "pass1234", "mariela@gmail.com", 5586143837));
            baseAdmin.Add(new Admin("Ivan", 318592776, "Estudiante", "user002", "pass4567", "ivan@gmail.com", 5562070569));
        }*/
        public void AltaEmpresa()
        {
            Empresas[0].Add(new Empresa("OfficeDepot", "Ivan", "ivan@gmail.com", 5562070569, "user002", "pass4567"));
            Empresas[1].Add(new Empresa("HiperLumen", "Mariela", "mariela@gmail.com", 5586143837, "user001", "pass1234"));
            Empresas[2].Add(new Empresa("Epson", "Kareem", "kareem@gmail.com", 5587496210, "user003", "pass7894"));

        }
        public void imprimirAd(List<Admin> list) //imprimir admin 
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("/" + list[i]);
            }
        }
        public void imprimirEm(List<Empresa> listEm) //imprimir empresa  
        {
            for (int i = 0; i < listEm.Count; i++)
            {
                Console.WriteLine("/" + listEm[i]);
            }
        }
        public void EmpresaR() //Para verificar si exista la cuenta de la empresa
        {
            int  op1 = 0;
            int op2 = 0;
            do //El ciclo se repite infinitamente y no devuelve al menu principal
            {
                Console.WriteLine("¿Ya tiene una cuenta registrada?" +
               "\n1) Sí\n2) No\n");
                op1 = int.Parse(Console.ReadLine());

                switch (op1) //se repite infinitamente
                {
                    case 1:
                        Console.WriteLine("Ingresa el nombre de la empresa: ");
                        string name = Console.ReadLine();
                        for(int a = 0; a<4; ++a)
                        {
                            //if (name == b.getNombreEmpresa)
                            foreach (Empresa b in Empresas[a])
                            {
                                
                                Console.WriteLine("Es esta tu empresa?");
                                Console.WriteLine("El nombre de la empresa es: " + b.getNombreEmpresa() + "El ponete es:" + b.getNombres() + "Su correo es: " + b.getCorreo());
                                Console.WriteLine("1) Si \n2) No");
                                op2 = Convert.ToInt32(Console.ReadLine());
                                switch (op2)
                                {
                                    case 1://

                                        break;

                                    case 2:
                                        op1 = 4;
                                        break;
                                }
                            }
                        }
                     
                        //if (name == "alo" )
                        //{
                        //    Console.WriteLine("Es esta tu empresa?");
                        //    //Console.WriteLine("El nombre de la empresa es: " + Empresa1.getNombreEmpresa() + "El ponete es:" + Empresa1.getNombres() + "Su correo es: " + Empresa1.getCorreo() ) ;
                        //    Console.WriteLine("1) Si \n2) No");
                        //    op2 = Convert.ToInt32(Console.ReadLine());
                        //    switch (op2)
                        //    {
                        //        case 1://
                        //            Console.WriteLine("Hola");
                        //            break;

                        //        case 2:
                        //            op1 = 4;
                        //            break;
                        //    }
                        //}
                        
                        //Mostrar al usuario los datos de la empresa proporcionada
                        //imprimirEm(OfficeDepot); //este metodo no se ejecuta

                        break;
                    case 2:
                        Console.WriteLine("Ingrese el nombre de la empresa a registrar:");
                        string nameR = Console.ReadLine();
                        Console.WriteLine("Tu empresa ha sido registrada!");

                        //Comparar nombrres de la empresa por si ya existierá

                        break;
                    case 3:
                        Console.WriteLine("Hasta luego :D");
                        break;
                    default:
                    Console.WriteLine("Caracter no valido");
                        break;
                }
            } while (op1 == 4);

        }

    }
}
/*
 * En esta clase falta mandar a imprimir la lista completa, ademas de acceder a sus elementos mediante sus setters.
 */