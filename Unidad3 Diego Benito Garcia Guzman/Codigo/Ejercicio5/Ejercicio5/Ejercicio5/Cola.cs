using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Cola<T>
    {
        private T[] elementos;
        private int frente;
        private int final;
        private int tamaño;
        private int capacidad;

        public int Count => tamaño;     // Propiedad: cantidad de elementos
        public bool EstaVacia => tamaño == 0;
        public bool EstaLlena => tamaño == capacidad;

        public Cola(int capacidad = 10)
        {
            this.capacidad = capacidad;
            elementos = new T[capacidad];
            frente = 0;
            final = -1;
            tamaño = 0;
        }

        // Encolar
        public void Encolar(T elemento)
        {
            if (EstaLlena)
            {
                Console.WriteLine("La cola está llena.");
                return;
            }
            final = (final + 1) % capacidad;
            elementos[final] = elemento;
            tamaño++;
        }

        // Desencolar
        public T Desencolar()
        {
            if (EstaVacia)
            {
                Console.WriteLine("La cola está vacía.");
                return default(T);
            }

            T elemento = elementos[frente];
            frente = (frente + 1) % capacidad;
            tamaño--;
            return elemento;
        }

        // Regresa el primer elemento sin eliminarlo
        public T Frente()
        {
            if (EstaVacia) return default(T);
            return elementos[frente];
        }

        // Mostrar contenido
        public void Mostrar()
        {
            if (EstaVacia)
            {
                Console.WriteLine("La cola está vacía.");
                return;
            }

            Console.WriteLine("Contenido de la cola:");
            int index = frente;
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write($"{elementos[index]} ");
                index = (index + 1) % capacidad;
            }
            Console.WriteLine();
        }
    }
}
