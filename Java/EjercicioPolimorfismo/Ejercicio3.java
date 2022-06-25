package Java.EjercicioPolimorfismo;

public class Ejercicio3{
	public static void main(String... args){
	Computadora escritorioJorge = new ComponentesExternos("Boton de encendido");
		escritorioJorge.encender();//llamar al metodo
		escritorioJorge = new Computadora("La computadora prendio con el boton de encendido. ");
		escritorioJorge.encender();
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
	// constructor de la clase Computadora.
	public ComponentesExternos(String nombres){ nombres = nombres;}
	//metodo
	public void encender(){
		System.out.println("El equipo se ha encendido con el componente externo. " + nombres);
	}
	/* ToDo 
	*   Realizar dos metodos mas a la clase ComponentesExternos.
	* */
}
class ComponentesInternos{
	/* ToDo
	 *   Completar clase, agregar polimorfismo y sobreescritura de metodos.
	 * */
}