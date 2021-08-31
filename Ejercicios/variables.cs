namespace ejemplo1{
using System;	
	public class variables{
		public static void Main (){
			/*
			Declaración de variables
			*/
			bool may = new bool();
			char resp = new char();

			Console.Write("Eres mayor de 23 anios? (S)");
			resp=(char) Console.Read();

			//Se implementan operadores logicos
			may= (resp =='s') | (resp == 'S');
			Console.WriteLine(may);
		}
	}
}