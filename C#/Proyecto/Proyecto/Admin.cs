using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFinal
{
    public class Admin
    {
        //atributos
        public string nombre;
        public int numTrabajador;
        public string dependencia;
        public string usuario;
        public string contraseña;
        public string correo;
        public long celular;


        //constructor 
        public List<Admin> baseAdmin = new List<Admin>();
        public void AltaAdmin()
        {
            //podemos hacer lo siguiente//

            baseAdmin.Add(new Admin( "Kareem", 318259478, "Estudiante", "user003", "pass7894", "kareem@gmail.com", 5587496210));
            baseAdmin.Add(new Admin("Mariela", 318325961, "Estudiante", "user001", "pass1234", "mariela@gmail.com", 5586143837));
            baseAdmin.Add(new Admin("Ivan", 318592776, "Estudiante", "user002", "pass4567", "ivan@gmail.com", 5562070569));
        }
        public Admin(string nombres, int numTrabajadores, string dependencias, string usuarios, string password, string email, long cel)
        {
            this.nombre = nombres;
            this.numTrabajador = numTrabajadores;
            this.dependencia = dependencias;
            this.usuario = usuarios;
            this.contraseña = password;
            this.correo = email;
            this.celular = cel;
        }
        public Admin()
        {

        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nom)
        {
            this.nombre = nom;
            Console.WriteLine("Tu nombre de usuario es: " + nom);
        }
        public int getNumTrabajador()
        {
            return numTrabajador;
        }
        public void setNumTrabajador(int numT)
        {
            this.numTrabajador = numT;
            Console.WriteLine("Tu numero de trabajador es: " + numT);
        }
        public string getDependencia()
        {
            return dependencia;
        }
        public void setDependencia(string dep)
        {
            this.dependencia = dep;
            Console.WriteLine("Tu numero de trabajador es: " + dep);
        }
        public string getUsuario()
        {
            return usuario;
        }
        public void setUsuario(string user)
        {
            this.usuario = user;
            Console.WriteLine("Tu numero de trabajador es: " + user);
        }
        public string getContraseña()
        {
            return contraseña;
        }
        public void setContraseña(string pass)
        {
            this.contraseña = pass;
            Console.WriteLine("Tu numero de trabajador es: " + pass);
        }
        public string getCorreo()
        {
            return correo;
        }
        public void setCorreo(string email)
        {
            this.correo = email;
            Console.WriteLine("Tu numero de trabajador es: " + email);
        }
        public long getCelular()
        {
            return celular;
        }
        public void setCelular(int cel)
        {
            this.celular = cel;
            Console.WriteLine("Tu numero de trabajador es: " + cel);
        }
        public void registroEmpresa()
        {
            int i = 0;
            string[] nombre = new string[5];
            Console.WriteLine("Ingrese el nombre de la empresa: ");
            i++;
            nombre[i] = Console.ReadLine();
            Console.WriteLine("\tDatos del representante de la empresa: ");
            Console.WriteLine("Nombre: ");
            string[] nomRep = new string[5];
            nomRep[i] = Console.ReadLine();
            Console.WriteLine("Email: ");
        }
    }
}
