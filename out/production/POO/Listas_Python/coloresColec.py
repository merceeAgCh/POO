#ejercicio en clase 3
"""
ToDo
Mostrar menu
Crear una coleccion de colores (3 colores previamente cargados)
Mostrar la coleccion
Agregar color a la coleccion
Editar un valor de la coleccion
Eliminar dato
Salir del programa.
"""
def crear():
    global colores
    colores = ["Azul","verde","Rojo"]
    print("Lista creada con exito\n")

def mostrar():
    print(colores)

def añadir():
    """
    colores.insert(4,"morado")
    print(colores)
    """ #No puedes dejar un agregado asi, el usuario debe agregarlo
    print('\nIngresa un color de la lista: ')
    elemento = input()
    print('\nIndice en el que desea agegar el elemento: ')
    indice = input()
    indice = int(indice)
    longitud = len(colores)
    longitud = int(longitud)
    if(indice > longitud or indice < 0):
     #condicion que toma la longitud para permitir o no ingresar elementos a la lista
        print('\nEl indice debe estar entre 0 y ', longitud)
    else: 
        colores.insert(indice, elemento) 
        print('\nSe agrego con exito el elemento ') 

def eliminar():
    """
    colores.remove("Azul")
    print(colores)
    """#El usuario debe decir que eliminar
    print('\n Indice del color a "eliminar": ')
    indice = input()
    indice = int(indice)
    longitud = len(colores)
    longitud = int(longitud)
    if(indice > longitud or indice < 0):
     #condicion que toma la longitud para permitir o no ingresar elementos a la lista
        print('\nEl indice debe estar entre 0 y ', longitud -1)
    else: 
        del colores[indice] 
        print('\n Se elimino con exito el elemento ')   

#Faltaba en el codigo anterior modificar un color de la lista
def editar():
    print('\n Indice del color a editar: ')
    indice = input()
    indice = int(indice)
    print('\nIngresa el nuevo valor del color: ')
    elemento = input()
    longitud = len(colores)
    longitud = int(longitud)
    if(indice > longitud or indice < 0):
        print('\nEl indice debe estar entre 0 y ', longitud -1)
    else: 
        colores[indice] = elemento
        print('\n ¡¡Color modificado!! ')          

def main():
    opc = "1"
    while (opc != "6"):
        print("=============================================================================")
        print('                        Bienvenido al menu. \n                    Selecciona la opcion deseada:')
        print("=============================================================================\n")
        print("1) Crear lista de colores")
        print("2) Mostrar colores")
        print("3) Agregar un color")
        print("4) Eliminar dato")
        print("5) Editrar el valor de un color")
        print("6) Salir del programa")
        opc = input()
        if (opc == "1"):
            crear()
        elif (opc == "2"):
            mostrar()
        elif (opc == "3"):
            añadir()
        elif (opc == "4"):  
            eliminar() 
        elif (opc == "5"):
            editar()    
        elif (opc == "6"):
            print("Programa terminado, ¡Hasta luego!")  
        else:
            print("Opcion no valida")    
main()

    
