public class Persona{
// atributos: edad, sexo, estatura y nombre
	private String sexo;
	private int edad;
	private String nombre;

	public static void main(String... args){
		// metodo principal....
		System.out.println("Segunda clase de JAVA.");
		//creamos el objeto y su instancia
		Persona personaJorge = new Persona();
		//referenciar instancia
		int edadPersona = personaJorge.obtenerEdad(2022, 1995);
		System.out.println("La edad de Jorge es: " + edadPersona);

	}
	public int obtenerEdad(int annioNacimiento, int annioActual){
		edad = annioActual - annioNacimiento;
		return edad;
	}
}