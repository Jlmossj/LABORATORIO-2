int num1;
int num2;
Console.WriteLine("Ingrese el primer numero: ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"{num1} es mayor que {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"{num1} es menor que {num2}");
}
else
{
    Console.WriteLine($"{num1} es igual a {num2}");
}
if (num1 > 10 && num2 < 20)
{
    Console.WriteLine($"{num1} es mayor que 10 Y {num2} es menor que 20");
}
if (num1 > 10 || num2 < 20)
{
    Console.WriteLine($"{num1} es mayor que 10 O {num2} es menor que 20");
}
Console.WriteLine("Si los dos número ingresados son iguales, se activara la compuerta logica and." +
    "Si los numeros son distintos, se activara la compuerta logica or");