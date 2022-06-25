public class Herencias{
  public static void main(String args[]){
  Paciente NuevoPaciente = new Paciente();
  NuevoPaciente.Heredacion();
 }   
}

class enfermeras{
protected String Paciente;
protected void Atender(){
System.out.println("Las enfermeras estan atendiendo al paciente");
 }
}

class Doctor extends enfermeras{
protected void Atendiendo(){
System.out.println("El doctor esta dando una consulta despues de que le ayudaran las enfermeras");
 }
protected void Atender(){
 System.out.println("La enferemera esta ayudando al doctor");
 }
}

class Residente extends Doctor{
protected String nombreResidente;
 protected void clases(){
  System.out.println("El residente toma clases del doctor");
  }
 protected void ayudar(){
  System.out.println("El residente ayuda al doctor a revisar al paciente");
  }
 protected void Atendiendo(){
  System.out.println("El docotor esta atendiendo al paciente de una manera adecuada");
 }
}

class Paciente extends Residente{
protected String nombreDelPaciente;

 protected void Heredacion(){
  System.out.println("El paciente le esta diciendo los sintomas al doctor");
  Atender();
  Atendiendo();
  clases();
  ayudar(); 
 }
}
