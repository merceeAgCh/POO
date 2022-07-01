#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <time.h>
#define max 3

void tick_tack_toe(int matx[max][max]);
void producto_cruz(float matx[max][max]);
void print_matriz(int matx[max][max]);
void inicia_matriz(int matx[max][max]);

/*La funcion main es un menu desde el cual se pueden elegir 3 diferentes 
opciones, la primera es jugar gato (o tick-tack-toe) contra el CPU.
La segunda es ingresar dos vectores y por el metodo de determinantes, 
encontrar el producto cruz o vectorial entre estos, y la ultima opcion
es para salir del programa*/
int main(void){
	srand(time(NULL));
	int gato[max][max];
	float provec[max][max];
	char opc;
	do{
		printf("Elija una opcion\n");
		printf("1. Jugar gato\n");
		printf("2. Calcular producto vectorial\n");
		printf("3. Salir\n");
		printf("Opcion: ");
		scanf(" %c", &opc);
		printf("\n");
		switch(opc){
			case '1':
				tick_tack_toe(gato);
			break;
			
			case '2':
				producto_cruz(provec);
			break;
			
			case '3':
			break;
			
			default:
			printf("La opcion ingresada es incorrecta\n\n");
		}
	} while(opc != '3');	
	return 0;
}

/*Esta funcion ocupa ciclos for para imprimir la matriz, separandola
por renglones y columnas*/
void print_matriz(int matx[max][max]){
	int i, j;
	for(i = 0; i < max; i++){
		for(j = 0; j < max; j++){
			printf(" %d  ", matx[i][j]);
		}
		printf("\n\n");
	}
}

/*Esta funcion la ocupo en la funcion tick-tack-toe, y es para que todos 
los elementos dentro de la matriz tomen el valor de 2.*/
void inicia_matriz(int matx[max][max]){
	int i, j;
	for(i = 0; i < max; i++){
		for(j = 0; j < max; j++){
			matx[i][j] = 2;
		}
	}
}

/*Esta funcion es compleja, por lo que la voy a comentar directamente
en los renglones*/
void tick_tack_toe(int matx[max][max]){
	int p, q, i, j, acu = 0, a, b, c, d, e, f, g, h; //inicia variables
	printf("Bienvenido, en este juego, debe lograr tener 3 1's seguidos para ganar. \nSi el CPU logra 3 3's seguidos, gana\n");
	inicia_matriz(matx);//pone todos los elementos de la matriz como 2
	print_matriz(matx);// despliega la matriz para el usuario
	do{
		/*Esta seccion, recibe input del usuario, para saber
		que celda de la matriz quiere utilizar como su "tiro"*/
		printf("Que renglon quiere modificar? (1, 2, 3)\n");
		scanf(" %i", &p);
		printf("Que columna quiere modificar? (1, 2, 3)\n");
		scanf(" %i", &q);
		/*Este if es el que revisa que el espacio especificado por el usuario
		sea valido, es decir que este "limpio", con un 2. Si tiene cualquier
		otro valor, se le mencionaal usuario que perdio un turno*/
		if (matx[p-1][q-1] == 2){
			matx[p-1][q-1] = 1;
		} else{
			printf("Lo siento, ese renglon esta ocupado, pierde este turno\n");
		}
		print_matriz(matx);//despliega la matriz al usuario
		printf("\n");
		i = (rand() % (max + 1)) - 1;//numero aleatorio de renglon
		j = (rand() % (max + 1)) - 1;//numero aleatroio de columna
		acu = 0;/*esta variable la ocupo para evitar que en un ciclo
		do-while que ocupo despues se cicle*/
		
		/*La siguiente seccion es la que le permite al programa saber
		si alguien ya gano, esto lo hace multiplicando todas las 
		combinaciones posibles, si dan igual a un valor 1 o 27, significa
		que o el usuario o el CPU ya lograron tener 3 numeros iguales
		seguidos*/
		a = matx[0][0]*matx[1][0]*matx[2][0];
		b = matx[0][1]*matx[1][1]*matx[2][1];
		c = matx[0][2]*matx[1][2]*matx[2][2];
		d = matx[0][0]*matx[0][1]*matx[0][2];
		e = matx[1][0]*matx[1][1]*matx[1][2];
		f = matx[2][0]*matx[2][1]*matx[2][2];
		g = matx[0][0]*matx[1][1]*matx[2][2];
		h = matx[0][2]*matx[1][1]*matx[2][0];
		/*El if no es completamente necesario, pero ayuda a prevenir que
		la computadora realice su movimiento si el usuario ya gano. Y con
		esto evitar que haya alg[un problema con el criterio para elegir
		al ganador. Aunque por la forma en com esta estructurada la 
		funcion, hace que no sea vital*/
		if( a != 1 && b != 1 && c != 1 && d != 1 && e != 1 && f != 1 && g != 1 && h != 1){
			do{
				/*Este if es para checar si el espacio dado por los numeros 
				aleatorios son validos para que la computadora tire, y como
				la computadora no puede perder turno porque es "inteligente"
				es necesario que el proceso se repita hasta que se pueda
				escribir el '3'*/
				if (matx[i][j] == 2){
					matx[i][j] = 3;//escribe 3 en el espacio dentro de la matriz
					acu = 1;/*este lo ocupo para evitar que el programa se cicle
					ya que es una condicion adicional para indicarle al programa
					que el CPU ya tiro, si no lo incluyera, es posible
					que al volver a buscar un numero aleatorio, cayera en una 
					posicion donde hay un 3 con lo que el while pensaria
					que ya se llego al fin, lo cual no habria sucedido aun*/
				} else{
					i = (rand() % (max + 1)) - 1;//vuelve a buscar un renglon aleatorio
					j = (rand() % (max + 1)) - 1;//vuelve a buscar una columna aleatoria
				}			
			} while ( ( (matx[i][j] != 3) || acu == 0 ) && ( matx[0][0] == 2 || matx[0][1] == 2 || matx[0][2] == 2 || matx[1][0] == 2 || matx[1][1] == 2 || matx[1][2] == 2 || matx[2][0] == 2 || matx[2][1] == 2 || matx[2][2] == 2 ) );	
			// La CPU ya tiro
			print_matriz(matx);	//imprime la matriz
		}
		/*Vuelve a evaluar las combinaciones ganadoras*/
		a = matx[0][0]*matx[1][0]*matx[2][0];
		b = matx[0][1]*matx[1][1]*matx[2][1];
		c = matx[0][2]*matx[1][2]*matx[2][2];
		d = matx[0][0]*matx[0][1]*matx[0][2];
		e = matx[1][0]*matx[1][1]*matx[1][2];
		f = matx[2][0]*matx[2][1]*matx[2][2];
		g = matx[0][0]*matx[1][1]*matx[2][2];
		h = matx[0][2]*matx[1][1]*matx[2][0];
	} while( (a != 27 && a != 1 && b != 27 && b != 1 && c != 27 && c != 1 && d != 27 && d != 1 && e != 27 && e != 1 && f != 27 && f != 1 && g != 27 && g != 1 && h != 27 && h != 1) && ( matx[0][0] == 2 || matx[0][1] == 2 || matx[0][2] == 2 || matx[1][0] == 2 || matx[1][1] == 2 || matx[1][2] == 2 || matx[2][0] == 2 || matx[2][1] == 2 || matx[2][2] == 2 ) );
	/*En este punto el juego ya termino, porque ya se cumplio
	la condicion que alguna combinacion ganadora se haya dado, 
	o bien, que ya no es posible hacer mas movimientos*/
	/*Aqui unicamente se comprueba si gano el usuario, el CPU, o fue empate*/
	if( a == 1 || b == 1 || c == 1 || d == 1 || e == 1 || f == 1 || g == 1 || h ==1 ){
		printf("Felicidades, ha ganado!\n\n");
	} else if( a == 27 || b == 27 || c == 27 || d == 27 || e == 27 || f == 27 || g == 27 || h == 27){
		printf("Lo ha derrotado el CPU, es un dia triste para la raza humana\n\n");
	} else {
		printf("Con el empate perdemos todos\n\n");
	}
	//FIN de la funcion
}	

/*Esta funcion la lleno con numeros del tipo float, ya que si el usuario
quisiera ingresar vectores con decimales podria hacerlo.
Tuve que hacer una funcion para imprimirlo dentro de esta funcion,
ya que el otro trabajaba con matrices int, y no sabia como hacer
que tambien funcionara para esta, por lo que pense que era mas sencillo
volverla a escribir.
Despliega el producto vectorial en su forma de determinantes y da el 
resultado en terminos de los componentes*/
void producto_cruz(float matx[max][max]){
	float i, j, k;
	int m, n;
	printf("Esta funcion le permite conocer el resultado de un producto vectorial entre un vector A y un vector B\n");
	printf("Introduzca los componentes del vector A\n");
	for( m = 0; m < max; m++){	
		scanf(" %f", &matx[1][m]);
	}
	printf("A = %0.2f i + ( %0.2f j ) + ( %0.2f k )\n", matx[1][0], matx[1][1], matx[1][2]);
	printf("Introduzca los componentes del vector B\n");
	for( m = 0; m < max; m++){	
		scanf(" %f", &matx[2][m]);
	}
	printf("B = %0.2f i + ( %0.2f j ) + ( %0.2f k )\n", matx[2][0], matx[2][1], matx[2][2]);
	matx[0][0] = 1;
	matx[0][1] = -1;
	matx[0][2] = 1;
	printf("   (i)        (j)       (k)  \n");
	for(m = 0; m < max; m++){
		for(n = 0; n < max; n++){
			printf("| %0.2f   ", matx[m][n]);
		}
		printf("\n|\n");
	}
	i = (matx[0][0])*(matx[1][1]*matx[2][2] - matx[2][1]*matx[1][2]);
	j = (matx[0][1])*(matx[1][0]*matx[2][2] - matx[2][0]*matx[1][2]);
	k = (matx[0][2])*(matx[1][0]*matx[2][1] - matx[0][2]*matx[1][1]);
	printf(" A x B = %0.2f i + ( %0.2f j) + ( %0.2f k)\n", i, j, k);	
}