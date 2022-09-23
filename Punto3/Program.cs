var ListaEmpleados= new List<Empleado>();
var flag = 1;

do
{
	Console.WriteLine("-------Ingreso De Empleados-------\n");
	var empleado= new Empleado();
	Console.WriteLine("Ingrese el nombre");
	empleado.Setnombre(Console.ReadLine());
	Console.WriteLine("Ingrese el apellido");
	empleado.Setapellido(Console.ReadLine());
	Console.WriteLine("Ingrese la fecha de nacimiento");
	empleado.SetfechaNac(Console.ReadLine());
    Console.WriteLine("Ingrese la direccion");
    empleado.Setdireccion(Console.ReadLine());
	Console.WriteLine("Ingrese la fecha de ingreso a la empresa");
	empleado.Setfecha_ingreso(Convert.ToDateTime(Console.ReadLine()));
	Console.WriteLine("Ingrese el sueldo del empleado");
	empleado.Setsueldo(Convert.ToInt32(Console.ReadLine()));
	Console.WriteLine("El empleado es casado[0] o divorciado?[1]");
	if (Convert.ToInt32(Console.ReadLine()) == 0)
	{
	    empleado.Setcasado(true);
	    Console.WriteLine("Ingrese su cantidad de hijos");
	    empleado.SetCantHijos(Convert.ToInt32(Console.ReadLine()));
	}else
	{
	    empleado.Setdivorciado(true);
	    Console.WriteLine("Ingrese la fecha de divorcio");
	    empleado.Setfecha_divorcio(Convert.ToDateTime(Console.ReadLine()));
	}
	Console.WriteLine("El empleado tiene titulo universitario? [1] Si [0] No");
	if (Convert.ToInt32(Console.ReadLine())>0)
	{
	    empleado.SettituloUniversitario(true);
	    Console.WriteLine("Ingrese su universidad");
	    empleado.Setuniversidad(Console.ReadLine());
	    Console.WriteLine("Ingrese su titulo");
	    empleado.SetTitulo(Console.ReadLine());
	}
	ListaEmpleados.Add(empleado);
    Console.WriteLine("Quiere cargar otro empleado? [1] Si [0] No");
    flag = Convert.ToInt32(Console.ReadLine());
} while (flag == 1);
int enumerador=1;
foreach(Empleado empleado in ListaEmpleados)
{
    Console.WriteLine("Empleado numero" + enumerador);
    Console.WriteLine("Nombre: "+ empleado.Getnombre());
    Console.WriteLine("Apellido: "+ empleado.Getapellido());
    Console.WriteLine("Edad: "+ empleado.edad());
    Console.WriteLine("Antiguedad: "+ empleado.antiguedad());
    Console.WriteLine("Salario: "+ empleado.salario());
    Console.WriteLine("--------------------------------------------");
    enumerador++;
}
