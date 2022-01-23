#ejercicio en clase 3
"""
ToDo
Mostrar menu
Crear una coleccion de colores (3)
Mostrar la coleccion
Agregar color a la coleccion
Editar un valor de la coleccion
Eliminar dato
Salir del programa.
"""
def crear():
    global colores
    colores = ["Azul","verde","Rojo"]
def mostrar():
    print(colores)
def añadir():
    colores.insert(4,"morado")
    print(colores)
def eliminar():
    colores.remove("Azul")
    print(colores)
def main():
    opc = "1"
    while (opc != "5"):
        print("1)Crear una coleccion de colores")
        print("2)Mostrar la coleccion")
        print("3)Agregar color a la coleccion")
        print("4)Eliminar dato")
        print("5)Salir del programa")
        opc = input()
        if (opc == "1"):
            crear()
        if (opc == "2"):
            mostrar()
        if (opc == "3"):
            añadir()
        if (opc == "4"):  
            eliminar() 
main()

    
