Console.WriteLine("Ingresa uno de los siguientes numeros para ver mostrar el dia de la semana:\r\n1 = Lunes\r\n2 = Martes\r\n3 = Miércoles\r\n4 = Jueves\r\n5 = Viernes\r\n6 = Sábado\r\n7 = Domingo ");
int dia = int.Parse(Console.ReadLine());

switch (dia)
{
    case 1:
        Console.WriteLine("Es Lunes");
        break;
    case 2:
        Console.WriteLine("Es Martes");
        break;
    case 3:
        Console.WriteLine("Es Miercoles");
        break;
    case 4:
        Console.WriteLine("Es Jueves");
        break;
    case 5:
        Console.WriteLine("Es Viernes");
        break;
    case 6:
        Console.WriteLine("Es Sabado");
        break;
    case 7:
        Console.WriteLine("Es Domingo");
        break;
    default:
        Console.WriteLine("Numero invalido. Por favor ingresa un numero entre 1 y 7.");
        break;
}
Console.WriteLine("");
Console.WriteLine("En este caso utilice el switch, ya que, este me permite asignarle un numero a cada dia de la semana y me permite consultar el dia ingreaso sin hacer uso del If-else");