using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFinal
{
    public class Empresa : Admin
    {
        //atributos
        public static string nombreEmpresa;

        //public static List<Empresa>[] Empresas = new List<Empresa>[3];
        //public static void AltaEmpresa()
        //{
        //    Empresas[0].Add(new Empresa(nombreEmpresa = "OfficeDepot", "Ivan", "ivan@gmail.com", 5562070569, "user002", "pass4567"));
        //    Empresas[1].Add(new Empresa(nombreEmpresa = "HiperLumen", "Mariela", "mariela@gmail.com", 5586143837, "user001", "pass1234"));
        //    Empresas[2].Add(new Empresa("Epson", "Kareem", "kareem@gmail.com", 5587496210, "user003", "pass7894"));

        //}

        //constructor 
        public Empresa(string empresa, string nombres, string email, long cel, string usuarios, string password)
        {
            //this.Empresa = empresa;
            this.nombre = nombres;
            this.usuario = usuarios;
            this.contraseña = password;
            this.correo = email;
            this.celular = cel;
        }
        public Empresa()
        {

        }

        public string getEmeil()
        {
            return correo;
        }
        public void setEmeil()
        {
            Console.WriteLine("Ingrese el correo: ");
            correo = Console.ReadLine();
        }

        public string getNombreEmpresa()
        {
            return nombreEmpresa;
        }
        public void setNombreEmpresa()
        {
            Console.WriteLine("Ingrese el nombre de la empresa: ");
            nombreEmpresa = Console.ReadLine();
        }
        public string getNombres()
        {
            return nombre;
        }

        public void setNombres()
        {
            Console.WriteLine("Ingrese el nombre del representante: ");
            nombre = Console.ReadLine();
        }

        public string getUsuarios()
        {
            return usuario;
        }
        public void setUsuarios()
        {
            Console.WriteLine("Ingrese el nombre del usuario: ");
            usuario = Console.ReadLine();
        }
        public string getContraseñas()
        {
            return contraseña;
        }
        public void setContraseñas()
        {
            Console.WriteLine("Ingrese la contraseña: ");
            contraseña = Console.ReadLine();
        }
        public string getId()
        {
            return correo;
        }
        public void setId()
        {
            Console.WriteLine("Ingrese el correo: ");
            correo = Console.ReadLine();
        }
        public long getCel()
        {
            return celular;
        }
        public void setCel()
        {
            Console.WriteLine("Ingrese el numero celular: ");
            celular = Convert.ToInt64(Console.ReadLine());
        }
        public void Ingresodatos()
        {
            int escoger;
            Empresa empresa = new Empresa();
            do
            {
                Console.WriteLine("Deseas agregar mas: ");
                Console.WriteLine("1)Si ");
                Console.WriteLine("2)No ");
                escoger = Convert.ToInt32(Console.ReadLine());
                if (escoger == 1)
                {
                    empresa.setNombreEmpresa();
                    empresa.setNombres();
                    empresa.setUsuarios();
                    empresa.setContraseñas();
                    empresa.setId();
                    empresa.setCel();
                }
            } while (escoger != 2);
        }
        public void Editardatos()
        {
            int editar;
            Empresa empresas = new Empresa();
            do
            {
                Console.WriteLine("Deseas editar los datos: ");
                Console.WriteLine("1)Si");
                Console.WriteLine("2)No");
                editar = Convert.ToInt32(Console.ReadLine());
                if (editar==1)
                {
                    empresas.setNombreEmpresa();
                    empresas.setNombres();
                    empresas.setUsuarios();
                    empresas.setContraseñas();
                    empresas.setId();
                    empresas.setCel();
                }
            } while (editar != 2);
        }
    }
}
