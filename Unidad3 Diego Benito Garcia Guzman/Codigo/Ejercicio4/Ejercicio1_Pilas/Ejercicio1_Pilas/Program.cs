using Ejercicio1_Pilas;

Pila<char> miPila = new Pila<char>();
string Cadena = "(){}[]";  
bool esValida = true;

bool CompararEnPila(char esperado)
{
    if (miPila.Tamanio == 0) return false;

    char tope = miPila.EliminarPila(); // POP
    return tope == esperado;
}

for (int i = 0; i < Cadena.Length && esValida; i++)
{
    char c = Cadena[i];

    if (c == '(' || c == '{' || c == '[')
    {
        miPila.AgregarPila(c);   // PUSH
    }
    else if (c == ')')
    {
        esValida = CompararEnPila('(');
    }
    else if (c == '}')
    {
        esValida = CompararEnPila('{');
    }
    else if (c == ']')
    {
        esValida = CompararEnPila('[');
    }
}

if (miPila.Tamanio > 0) esValida = false;

Console.WriteLine(esValida ? "Es válida" : "Es inválida");

Console.ReadKey();
