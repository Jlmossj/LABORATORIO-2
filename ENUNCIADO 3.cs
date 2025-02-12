var usuario = "Juan";
var contraseña = "Luis123";

Console.WriteLine("Ingresa tu nombre de usuario:");
string nombreUsuario = Console.ReadLine();

Console.WriteLine("Ingresa tu contraseña:");
string contraseña1 = Console.ReadLine();

if (nombreUsuario == usuario)
{
    if (contraseña1 == contraseña)
    {
        Console.WriteLine("Bienvenido Juan");
    }
    else
    {
        Console.WriteLine("Contraseña incorrecta");
    }
}
else
{
    Console.WriteLine("Usuario incorrecto");
}

Console.WriteLine("");
Console.WriteLine("En este caso use el If - else, unicamente que esta vez añadi un if en otro if, para que al momento de que la condicion del nombre de usuario se cumpla, " +
    "se active otra condicion a evaluar, en este caso, la contraseña");