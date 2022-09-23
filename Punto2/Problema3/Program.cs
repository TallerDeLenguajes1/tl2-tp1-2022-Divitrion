int litros= 0,kilometros= 0;
bool flag = true;

do
{
    try
    {
        Console.WriteLine("Ingrese los kilometros conducidos");
        kilometros = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese los litros usados");
        litros = Convert.ToInt32(Console.ReadLine());
        flag = false;
    }
    catch (FormatException)
    {
        Console.WriteLine("Formato invalido, ingrese nuevamente los valores");
    }
    
} while (flag);

Console.WriteLine($"Los kilometros por litro son: {kmPerLiter(kilometros,litros)}");

static float kmPerLiter(int km, int liters)
{
    try
    {
        return (float)km/liters;
    }
    catch (DivideByZeroException)
    {
        return 0;
        
    }
}