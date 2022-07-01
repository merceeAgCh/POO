package Java.EjercicioPolimorfismo;


public class Ejercicio3{
	public static void main(String... args){
	Computadora escritorioJorge = new ComponentesExternos("Boton de encendido");
		escritorioJorge.encender();//llamar al metodo
		escritorioJorge = new Computadora("La computadora prendio con el boton de encendido. ");
		escritorioJorge.encender();
		escritorioJorge.escribir();
		escritorioJorge = new teclado("El teclado funciona de una manera perfecta en la computadora. ");
		escritorioJorge.escribir();
		escritorioJorge.usarElRaton();
		escritorioJorge = new raton("El nuevo raton funciona de una manera perfecta en la computdora. ");
		escritorioJorge.usarElraton();
	}
}
class Computadora{
	public Computadora(){}
	//variable
	private String nombres;
	// constructor de la clase Computadora.
	public Computadora(String names){ nombres = names;}
	//metodo
	public void encender(){
		System.out.println("El equipo se ha encendido. " + nombres);
	}
}
class ComponentesExternos extends Computadora{
	public ComponentesExternos(){}
	//variable
	private String nombres;
	private String teclear;
	private String raton;
	// constructor de la clase Computadora.
	public ComponentesExternos (String nombres) { nombres = nombres;}
	//metodo
	public void encender(){System.out.println("El equipo se ha encendido con el componente externo. " + nombres);}
	/* ToDo 
	*   Realizar dos metodos mas a la clase ComponentesExternos.
	* */
	public void escribir() { System.out.println("El usuario esta usando el  nuevo teclado de la computadora. " + teclear);}
	public void usarElRaton() { System.out.println("El usuario esta usando el nuevo raton. " + raton);}
}
class ComponentesInternos extends ComponentesExternos{
	/* ToDo
	 *   Completar clase, agregar polimorfismo y sobreescritura de metodos.
	 * */
	public ComponentesInternos(){}
	//variable
	private String discoDuro;
	private String tarjetaGrafica;
	private String fuenteDeAlimentacion;
	//constructor de la clase Compo
	public ComponentesInternos(String discoDuro) { discoDuro = discoDuro;}
	//metodo
    public void cambiarElDiscoDuro() { System.out.println("El usuario esta cambiando el disco duro. " + discoDuro);}
	public void cambiarLaTarjetaGrafica () { System.out.println("El usuario esta cambiando de tarjeta grafica. " + tarjetaGrafica);}
	public void setFuenteDeAlimentacion () { System.out.println("El usuario esta cambiando la fuente de alimentacion. " + fuenteDeAlimentacion);}

}