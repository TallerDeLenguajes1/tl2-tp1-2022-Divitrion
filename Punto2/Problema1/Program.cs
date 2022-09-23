int numero;

Console.WriteLine("Ingrese un numero");
numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"El cuadrado del numero ingresado es: {cuadrado(numero)}");

static double cuadrado(int num)
{
    return Math.Pow(num, 2);
}