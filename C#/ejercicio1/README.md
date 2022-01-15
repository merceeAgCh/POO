## Programación Orientada a Objetos (POO).

#### Que son las listas??
	Una lista es: una serie de datos que almacenaremos en una variable.

#### Que es una herencia en POO?
	Es un mecanismo mediante el cual una clase hereda características de otras clases.

## Explicación del código.

	1- ¿Qué hace mi código?
		- Nos permite crear un usuario si es que no contamos con uno.
		- Ingreso de usuario y contraseña previamente creado.
		- Despliega menú con una serie de opciones (a- Tomar turno. b- Ver lista de pacientes. 
			c- Atender al paciente. d- generar reporte. e- salir).
	2.- ¿Que hacen las clases?
	          - Tenenmos el nombre de las clases(Enfermera,Interfaz,Paciente,Program)
		  - Dentro del program se mandan a llamar las clases que son Enfermera Interfaz y Paciente para que se imprimir el contenido de las clases, se le pide al usuario
		  que cree una contraseña si no la tiene y una vez creada la contraseña se le pedira que ingrese la contraseña creada,se va a desplegar un pequeño menu donde se va 
		  a poner lo siguiente(1) Inciar/Terminar turno,2)ver lista de pacientes,3)Atender al paciente,4)Escribir reporte,5)salir), una vez creado el menu se va a poner la 
		  primer opcion con un if que se va a igualar a 1,donde se va a mandar a llamar a Paciente1.listaPacientes.Count != 0 donde se va a ver si el contador es de la 
		  lista pacientes esta vacia en caso de que no este vacio se va a poner lo siguiente, sse va a gregar el turno del paciente poniendo 
		  turno = numpac.Next(1,Paciente1.listapacientes.Count + 1); donde se va a mandar a llamar la lista Paciente1.listaspacientes.Count sumandole un 1, una vez hecho 
		  esto se le asignara un turno poniendo lo siguiente Paciente1.EntraTurno(turno); en caso se de que el usuario quiera salir del turno Paciente1.SalirTurno();
		  en la opcion dos que es el if == 2, se le pide el numero del trabajor, se crea una nueva contraseña,se le pide al usuario pulsar la tecla enter para regresar al 
		  menu principal,si es la opcion 3 se va a salir del programa, en caso de que la opcion sea incorrecta saldra una opcion que diga opcion no valida, si la 
		  contraseña se encuentra se encuntra y es verdadera va a< entrar a un pequeño menu donde se va desplegar las siguientes opciones (1)Inciar/Terminar Turno\n2)Ver 
		  lista de pacientes\n3)Atender pacientes\n4)Escribir reporte\n5)salir), el usuario va a escoger una de las siguientes opciones, si es la opcion 1 
		 
