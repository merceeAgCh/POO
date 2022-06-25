public class Herencia2{
// crear objeto del main.
	public static void main(String... args) {
		//Hija del tipo hija (viene de la clase) llamando una variable laurita, es el objeto.
		//la new Hija es la instancia que hace cobre vida el objeto.
		Hija laurita = new Hija();
		laurita.describirHerencia();
	}
}

//por cada archivo .java se permite una clase publica.
class Abuelito{
	//atributos
	protected String colorOjos;
	protected double altura;
	//metodo
	protected void cantar(){
		System.out.println("El abuelito esta cantando");
	}
}

class Madre extends Abuelito{
	protected void bailar(){
		System.out.println("Me gusta bailar");
	}
	//metodo para so breescritura
	protected void cantar(){
		System.out.println("La madre esta cantando");
	}
}

class Hija extends Madre{
	/*crear metodo describir, mostrara en pantalla
	las propiedades que hereda del abuelo y cuales de la madre*/
	public void describirHerencia(){
		System.out.println("La altura es: " + altura);
		bailar();
		cantar();
	}
	
}

class Padre{
	void bailar(){

	}
}