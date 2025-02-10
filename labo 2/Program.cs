int numero;
double dec;
string tex;
bool num;

Console.WriteLine("Ingrese un número entero: ");
while (!int.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero: ");
}

Console.WriteLine("Ingrese un número decimal: ");
while (!double.TryParse(Console.ReadLine(), out dec))
{
    Console.WriteLine("Entrada no válida. Por favor, ingrese un número decimal: ");
}

Console.WriteLine("Ingrese un texto: ");
tex = Console.ReadLine();

Console.WriteLine("Ingrese un valor booleano (true/false): ");
while (!bool.TryParse(Console.ReadLine(), out num))
{
    Console.WriteLine("Entrada no válida. Por favor, ingrese un valor booleano (true/false): ");
}

Console.WriteLine("Número entero ingresado: " + numero);
Console.WriteLine("Número decimal ingresado: " + dec);
Console.WriteLine("Texto ingresado: " + tex);
Console.WriteLine("Valor booleano ingresado: " + num);
