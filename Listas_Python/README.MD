## Listas en Python.
### Clonamos el repositorio
	ssh-keygen
	git clone git@github.com:merceeAgCh/POO.git
	git pull // actualizar el repositorio
	git push origin  Listas_Jorge_2 // subir cambios a la rama
	git checkout Listas_Jorge_2 // cambia de la rama main a la de listas
### Clonamos el repositorio
	```
	py nombrePrograma.py
	```	
##### ¿Qué es una lista en Python?
	Son variables que almacenan "arrays",
	objetos donde internamente cada posición 
	puede ser un tipo de dato distinto.
#### Ejemplo:
	NombreLista = [7, 'hello', 9.99, true] //Declaramos o creamos nuestra lista.
	print(NombreLista) //Nos devuelve la lista en pantalla.
	len(NombreLista)	//Nos da el tamaño de la lista.
	NombreLista.append('agerega') //Nos sirve para agregar datos a la lista.
	NombreLista.extend([66]) //Este tambien nos sirve para adicionar datos a la lista, solo que puede agregar varios. NombreLista.extend(range(5,19))
	NombreLista.count(5) //Cuenta cuantas veces se repite el dato en la lista.
	NombreLista.insert(i,x) //Agrega datos, pero utilizando un índice, el cual sirve para dar una posición concreta para poner el dato nuevo.
	NombreLista.remove(y) //Elimina datos de la lista
	NombreLista.pop(i) //Elimina un dato utilizando el indice del mismo, si no se pone el indice, elimina el ultimo dato.
	NombreLista.index(y) //Me devuelve el indice del dato.
	NombreLista.reverse() //Invierte los elementos dentro de la lista.
	NombreLista.sort(y) // Ordena los datos de menor a mayor.

### ToDo
	"Crea 5 listas como se vio en el ejemplo"
