#Ejercicio 2 de listas en python
"""
Menu para manipular nuestra lista:
1 Agregar lista
2 Imprimir lista
3 Agregar dato a la lista
4 Eliminar elemento de la lista
5 Modificar un elemento de la lista
6 Salir
"""
#Captura n elementos de la lista
def crear():
	global list
	list = []
	print("\nCuantos elementos contendra la lista?")
	e = input()
	e = int (e)
	for i in range(0, e):
		print('\nIngresa el elemento del indice ', i)
		elemento = input()
		list.insert(i, elemento)

#funcion que muestra los elementos de la lista	
def mostrar():
	print (list)

#funcion que agrega elemento a la lista
def agregar():
	print('\nIngresa el elemento de la lista: ')
	elemento = input()
	print('\nIndice en el que desea agegar el elemento: ')
	indice = input()
	indice = int(indice)
	longitud = len(list)
	longitud = int(longitud)
	if(indice > longitud or indice < 0):
	 #condicion que toma la longitud para permitir o no ingresar elementos a la lista
	 	print('\nEl indice debe estar entre 0 y ', longitud)
	else: 
		list.insert(indice, elemento) 
		print('\nSe agrego con exito el elemento ')	


#funcion para eliminar un dato de la lista		
def eliminar():
	print('\n Indice en el que desea "eliminar" el elemento: ')
	indice = input()
	indice = int(indice)
	longitud = len(list)
	longitud = int(longitud)
	if(indice > longitud or indice < 0):
	 #condicion que toma la longitud para permitir o no ingresar elementos a la lista
	 	print('\nEl indice debe estar entre 0 y ', longitud -1)
	else: 
		del list[indice] 
		print('\n Se elimino con exito el elemento ')	

#Funcion para editar un elemento de la lista
def modificar():
	print('\n Indice del elemento que desea "editar": ')
	indice = input()
	indice = int(indice)
	print('\nIngresa el valor del elemento: ')
	elemento = input()
	longitud = len(list)
	longitud = int(longitud)
	if(indice > longitud or indice < 0):
	 	print('\nEl indice debe estar entre 0 y ', longitud -1)
	else: 
		list[indice] = elemento
		print('\n Se modifico con exito el elemento ')	
#Funcion main
def main():
	opc = "1"
	while (opc != "6"):
		print("=============================================================================")
		print('                        Bienvenido al menu. \n                    Selecciona la opcion deseada:')
		print("=============================================================================")
		print('1 Agregar lista')
		print('2 Imprimir lista')
		print('3 Agregar dato a la lista')
		print('4 Eliminar elemento de la lista')
		print('5 Modificar un elemento de la lista')
		print('6 Salir')
		opc = input()
		if (opc == "1"):
			crear()
		elif (opc == "2"):
			mostrar()	
		elif (opc == "3"):	
			agregar()
		elif (opc == "4"):	
			eliminar()
		elif (opc == "5"):
			modificar()	
		elif (opc == "6"):
			print("Programa terminado, ¡Hasta luego!")	
		else:
			print("Opcion no valida")
#Llama a la funcion principal		
main()	