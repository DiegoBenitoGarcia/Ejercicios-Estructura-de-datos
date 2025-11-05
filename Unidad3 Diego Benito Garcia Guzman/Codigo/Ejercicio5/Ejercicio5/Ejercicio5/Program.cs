using Ejercicio5;

Cola<int> miCola = new Cola<int>(5);

miCola.Encolar(10);
miCola.Encolar(20);
miCola.Encolar(30);

miCola.Mostrar();   

Console.WriteLine("Primer elemento: " + miCola.Frente());

Console.WriteLine("Desencolado: " + miCola.Desencolar());
miCola.Mostrar();  

Console.WriteLine("Total en cola: " + miCola.Count);

Console.ReadKey();