using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Bienvenido***");
            Console.WriteLine("1)Administrador \n2)Empresa \n3)Usuario unico \n4) Salir (Para salir oprime s)");
            int op = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (op)
                {
                    case 1: // Inicio de sesión del administrador 
                        /*ingresar un usario y una contraseña, funcion incio de administrador*/
                        admin();
                        
                        break;
                    case 2: // Inicio de sesión de la empresa
                        Altas case2 = new Altas();
                        case2.EmpresaR();
                        break;
                    case 3: // Inicio de sesión unico usario 
                        //Horario read = new Horario();
                        //read.leer();
                        Ponente();
                        break;
                    default:
                        break;
                }
            } while (op < 4);
        }


        public static void admin()
        {
            Console.WriteLine("Ingrese su nombre de usuario: ");
            string user = Console.ReadLine();
            if (user == "CECAdmon")
            {
                Console.WriteLine("Ingrese su contraseña: ");
                string password = Console.ReadLine();
                if (password == "C3C&2116unam_4d00ñ")
                {
                    Console.WriteLine("Bienvenido");
                    Paneles panel = new Paneles();
                    panel.panelAdmin();
                }
                else
                {
                    Console.WriteLine("Constraseña erronea");
                }
            }
            else
                Console.WriteLine("Usuario erroneo");
        }

        public static void Ponente() // cargar los horarios
        {
            Console.WriteLine("Ingresa el nombre tu empresa completo: ");
            string userP = Console.ReadLine();


            Console.WriteLine("Ingresa el nombre de la ponecia: ");
            string nameP = Console.ReadLine();


            //Console.WriteLine("Ingresa en tiempo de la ponecia: ");
            //string time = Console.ReadLine();

            Horario VerHoario = new Horario();
            VerHoario.VerHorarios();
           

        }

       
        public void bussiness()
        {
            Console.WriteLine("Ya tiene cuenta? \n\n1) Sí \n2) No");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1: //ya tiene cuenta

                    break;
                case 2: //registro
                    break;
                default:
                    break;
            }
        }

    }
}
