# Teoría básica de estructuras de datos

Las **estructuras de datos** son formas de organizar y almacenar información en la memoria de la computadora para que puedan ser utilizadas de manera eficiente.  
Entre las más comunes se encuentran: **Pila (Stack)**, **Cola (Queue)** y **Lista (List)**.

---

## 1. Pila (Stack)

### Definición
Una **Pila** es una estructura de datos lineal donde los elementos se almacenan y eliminan siguiendo el principio **LIFO (Last In, First Out)**, es decir, **el último en entrar es el primero en salir**.

### Operaciones básicas
- **Push:** insertar un elemento en la pila.  
- **Pop:** eliminar el elemento superior de la pila.  
- **Peek/Top:** consultar el elemento superior sin eliminarlo.  

### Ejemplo
Imagina una pila de platos:
> El último plato que colocas arriba es el primero que puedes quitar.

### Uso común
- Control de llamadas en funciones (stack de ejecución)  
- Deshacer/rehacer acciones (en editores)  
- Validar paréntesis en expresiones  

---

## 2. Cola (Queue)

### Definición
Una **Cola** es una estructura de datos lineal que sigue el principio **FIFO (First In, First Out)**, es decir, **el primero en entrar es el primero en salir**.

### Operaciones básicas
- **Enqueue:** agregar un elemento al final de la cola.  
- **Dequeue:** eliminar el primer elemento de la cola.  
- **Front:** ver el primer elemento sin eliminarlo.  

### Ejemplo
Piensa en una fila de personas en una tienda:
> La primera persona en llegar es la primera en ser atendida.

### Uso común
- Manejo de tareas en impresión  
- Control de procesos en sistemas operativos  
- Comunicación entre componentes (colas de mensajes)  

---

## 3. Lista (List)

### Definición
Una **Lista** es una colección ordenada de elementos donde cada uno ocupa una posición específica.  
Puede ser **estática** (como un arreglo) o **dinámica** (como una lista enlazada).

### Tipos principales
- **Lista simple enlazada:** cada elemento apunta al siguiente.  
- **Lista doblemente enlazada:** cada elemento apunta al anterior y al siguiente.  
- **Lista circular:** el último elemento apunta al primero.  

### Ejemplo
Una lista de tareas pendientes:
1. Comprar leche  
2. Hacer ejercicio  
3. Estudiar  

### Uso común
- Almacenamiento dinámico de datos  
- Implementación de otras estructuras (colas, pilas, grafos)  
- Manipulación de secuencias de datos  

---

## Resumen comparativo

| Estructura | Orden de salida | Inserción | Eliminación | Ejemplo cotidiano |
|-------------|-----------------|------------|--------------|-------------------|
| **Pila** | Último en entrar, primero en salir (LIFO) | Arriba | Arriba | Pila de platos |
| **Cola** | Primero en entrar, primero en salir (FIFO) | Final | Inicio | Fila de espera |
| **Lista** | Depende del tipo | Cualquier posición | Cualquier posición | Lista de tareas |

---
