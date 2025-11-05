using Ejercicio_2;

Pila<char> miPila = new Pila<char>();
String cadena = " ";
String CadenaVoltea = " ";

Console.ReadLine();

for (int i = 0; i < cadena.Length; i++)
{
    miPila.AgregarPila(cadena[i]);
}

if(miPila.Tamanio < 0)
{
    CadenaVoltea += miPila.EliminarPila();
}

if(CadenaVoltea == cadena)
{
    Console.WriteLine("Es Palindromo");
}
else
{
    Console.WriteLine("No es Palindromo");
}

Console.ReadKey();
