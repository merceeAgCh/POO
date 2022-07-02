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
		  lista de pacientes\n3)Atender pacientes\n4)Escribir reporte\n5)salir), el usuario va a escoger una de las siguientes opciones, si es la opcion 1 va a ver si la
		  lista no esta vacia, en caso de que la lista no este vacia va a entrar a turno, en caso de que no halla pacientes, se escribe lo siguiente no hay pacientes
		  espera a que uno venga,en la opcion 2 si la lista de pacientes es diferente de 0 se va a poner la lista de pacientes donde se imprime el nombr completo la 
		  direccion, el numero de habitacion, en caso contrario se escribe lo siguiente que es no hay pacientes en el hospital espere a que llegue uno,en la opcion 3
		  lo que va a seguir es que se va a elegir el nombre del paciente,el apellido del paciente,el curp del paciente,la direccion del paciente,una vez que ya se 
		  pusieron estos datos,se mandan a llamar los datos del nuevo paciente,se imprime el numero del pacientente, en la opcion 4 se hace el reporte del paciente
		  mandando el nombre, el apellido del paciente, el rfc, la direccion del paceinte, el area a la que pertenece la enfermera,se va a imprimir el reporte que haga
		  la enfermera, en la opcion 5 se va a rgresar al menu principal.
		 -Para la clase Enfermera lo que se va a hacer es una herencia de la clase Interfaz, metodoscomun en la clase Enfermera, con lo ue se van a poner una lista 
		 publica de lista enfermera que se va a llamar listaenfermeras, se va a crear un metodo publico de nombre Enfermera poniendo las variables a declarar, una vez 
		 hecho esto se va a crear un publi void inicializar donde se va a añadir una lista con el nombre del paciente,sus apellidos,su rfc, su direccion,el area de 
		 atencion, el numero de empleado,se va a crear un public string get Nombres donde se va a retornar el nombre, se va a crear un public string setNombres donde 
		 se pide el nombre de la enfermera sin sus apellidos, se va a crear un public string setApellidos donde se van a pedir los apellidos de la enfermera, se va a 
		 cerar un public void getApellidos donde se vana aretornar los apellidos, se va a poner un public string setRFC donde se va a pedir el rfc del paciente, en el 
		 se va a poner un public string setDirecciones donde se va a ingresar la direccion del usuario, se va a poner un public int area donde se va a escoger una de 
		 las siguientes areas, se va a poner un public string imprimir donde se imprimira el nombre, el apellido, el RFC, la direccion, el numero de empleado,para 
		 empezar a hacer el reporte siguiente
		 -En la clase Interfaz se creo una Interfaz llamada metodoscomun donde se mada a llamar void inicializar y un string inicializar, tabien se crea una clase que se
		 llama Interfaz donde se colocan los geters y seters y se manadn a evaluar.
		 -En la clase Paciente se hace una herencia de las clases Interfaz,metodocum donde se declaran los valres de manera publica, donde se cra una lista publica que
		 se llama Paciente con el nombre de listapacientes, una vez hecho esto se crea un public Paceinte donde se guardan las variables, se crea un public void 
		 inicializar donde se añaden la lista de los pacientes, se pone un public string getNombre donde se hace el retorno de la variable nombre, en el public string 
		 setNombre se pide que se ingrse el nombre del paciente sin sus apellidos, en el public string setCurp se pide que se ingrese el curp, en el public string 
		 setCurp se hace el retorno de la variable, en el public string setDireccion se pide ingresar la idreccion, en public string getDireccion se hace el retorno de 
		 la variable, en public void EntraTurno(int turn) se hace la impresion del turno que habia obtenido previamente, en el public void SalirTurno se sale del turno 
		 que tenia,public void NumeroPaciente(int turn) se pone el numero de paciente que se tiene, al final en el public string imprimir() se imprimen los datos del 
		 paciente 
		 
