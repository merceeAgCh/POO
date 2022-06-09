/* ToDo Complementar las siguientes clases, 
tomando en cuenta la herencia entre clases de java 
*/

public class HerenciaEjercicio{
	//metodo main
	public static void main(String args[]){
		Comprador nuevoAuto = new Comprador();
		nuevoAuto.heredarMetodos();
	}
}

class Auto{
	//atributos
	protected String marca;
	protected String modelo;
	protected String color;
	protected double precio;

	//metodos
	protected void arrancar(){
		System.out.println("El auto esta en movimiento. ");
	}
	protected void frenar(){
		System.out.println("El auto esta frenando. ");
	}
}

class Vendedor extends Auto{
	protected void vender(){
		System.out.println("El vendedor quiere vender el auto");
	}
}

class Comprador extends Vendedor{
	public void heredarMetodos(){
		System.out.println("Estamos aprendiendo a heredar. ");
		arrancar();
		frenar();
		vender();
	}
}
