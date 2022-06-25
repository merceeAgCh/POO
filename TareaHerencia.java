/*
ToDo:
Elegir un tema y crear 4 clases que hereden la una de la otra.
 */
public class TareaHerencia{
public static void main(String args[]){
  Futbolista nuevoFutbolista = new Futbolista();
  nuevoFutbolista.HeredarMetodo();
 }
}

class Seleccion{
    protected int id;
    protected String nombre;
    protected String apellidos;
    protected int edad;
    
    protected void viajar(){
    System.out.println("Los futbolistas estan viajando");
   }
    protected void concentrarse(){
    System.out.println("Los futbolistas se esta concentrando");
    }
    protected void partido(){
    System.out.println("Los futbolistas estan jugando");
   }
}
class Entrenador extends Seleccion{
  protected String idFeeracion;
  protected void dirigirPartido(){
   System.out.println("El entrenador esta dirigiendo el partido");
 }
  protected void partido(){
    System.out.println("Los futbolistas estan jugando de esta clase");
 }
}

class Masajista extends Entrenador{
  protected String titulacion;
  protected int aniosExperencia;
  protected void darMasaje(){
   System.out.println("El masajista esta dando un masaje a un jugador");
 }
  protected void concentrarse(){
  System.out.println("Los futbolistas se estan concentrando con el masajista");
 }
}

class Futbolista extends Masajista{
   public void HeredarMetodo(){
   System.out.println("El jugador esta jugando un partido");
   System.out.println("El jugador esta entrenando");
   viajar();
   concentrarse();
   partido();
   dirigirPartido();
   darMasaje();
  }
}
