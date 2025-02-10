double num1;
double num2;

while (true)
{
    Console.WriteLine("Digite el primer numero: ");
    num1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite el segundo numero: ");
    num2 = double.Parse(Console.ReadLine());

    Console.WriteLine("La suma de los dos numeros ingresados es: " + (num1 + num2));
    Console.WriteLine("La resta de los dos numeros ingresados es: " + (num1 - num2));
    Console.WriteLine("La multiplicacion de los dos numeros ingresados es: " + (num1 * num2));
    Console.WriteLine("La division de los dos numeros ingresados es: " + (num1 / num2));

    Console.WriteLine("Desea continuar? (s/n)");
    if (Console.ReadLine() == "n")
    {
        break;
    }
}
