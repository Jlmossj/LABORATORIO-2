Console.WriteLine("Ingrese su edad");
int num1 = int.Parse(Console.ReadLine());

if (num1 <= 12)
{
    Console.WriteLine(" Usted es un niño");
}
else if (num1 > 12 && num1 < 18)
{
    Console.WriteLine(" Usted es un adolescente");
}
else if (num1 >= 18 && num1 < 60)
{
    Console.WriteLine(" Usted es un adulto");
}
else
{
    Console.WriteLine(" Usted es un adulto mayor");
}
Console.WriteLine("");
Console.WriteLine("En este caso utilice el If-else ya que me permite evaluar los datos ingresado por medio de rangos y asi poder determinar la edad de la persona");