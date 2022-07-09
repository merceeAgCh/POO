package Java.Repaso;

public class Agencia {
    /* ToDo
    * Se crearan dos objetos de la clase Automovil en un archivo Agencia.java
    * */
    //metodo principal
    public static void main(String[] args){
        //Objeto
        Duenio David = new Duenio("Azul", "VolksWagen", "Gol GTI", 187000, "David Perez");
        Duenio Liliana = new Duenio("Rojo", "VolksWagen", "Jetta Live", 289000, "Liliana Chavez");
        David.verDatos();
        Liliana.verDatos();
    }
}
