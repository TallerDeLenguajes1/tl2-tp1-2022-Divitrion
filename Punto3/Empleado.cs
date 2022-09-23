public class Empleado
{
    private string Nombre;

    public string Getnombre()
    {
        return Nombre;
    }

    public void Setnombre(string value)
    {
        Nombre = value;
    }

    private string Apellido;

    public string Getapellido()
    {
        return Apellido;
    }

    public void Setapellido(string value)
    {
        Apellido = value;
    }

    private string Direccion;

    public string Getdireccion()
    {
        return Direccion;
    }

    public void Setdireccion(string value)
    {
        Direccion = value;
    }

    private DateTime FechaNac;

    public DateTime GetfechaNac()
    {
        return FechaNac;
    }

    public void SetfechaNac(string value)
    {
        try
        {
            FechaNac = Convert.ToDateTime(value);
        }
        catch (System.Exception)
        {
            FechaNac= Convert.ToDateTime("1/1/1900");
        }
    }

    private DateTime Fecha_ingreso;

    public DateTime Getfecha_ingreso()
    {
        return Fecha_ingreso;
    }

    public void Setfecha_ingreso(DateTime value)
    {
        Fecha_ingreso = value;
    }

    private DateTime Fecha_divorcio;

    public DateTime Getfecha_divorcio()
    {
        return Fecha_divorcio;
    }

    public void Setfecha_divorcio(DateTime value)
    {
        Fecha_divorcio = value;
    }

    private int Sueldo;

    public int Getsueldo()
    {
        return Sueldo;
    }

    public void Setsueldo(int value)
    {
        Sueldo = value;
    }

    private bool Casado;

    public bool Getcasado()
    {
        return Casado;
    }

    public void Setcasado(bool value)
    {
        Casado = value;
    }

    private int CantHijos;

    public int GetCantHijos()
    {
        return CantHijos;
    }

    public void SetCantHijos(int value)
    {
        CantHijos = value;
    }

    private bool Divorciado;

    public bool Getdivorciado()
    {
        return Divorciado;
    }

    public void Setdivorciado(bool value)
    {
        Divorciado = value;
    }

    private bool TituloUniversitario;

    public bool GettituloUniversitario()
    {
        return TituloUniversitario;
    }

    public void SettituloUniversitario(bool value)
    {
        TituloUniversitario = value;
    }

    private string Universidad;

    public string Getuniversidad()
    {
        return Universidad;
    }

    public void Setuniversidad(string value)
    {
        Universidad = value;
    }
    private string Titulo;

    public string GetTitulo()
    {
        return Titulo;
    }

    public void SetTitulo(string value)
    {
        Titulo = value;
    }

    
    public double salario()
    {
        return this.Getsueldo() + this.Getsueldo() * 0.15 - (this.Getsueldo() * 0.01) * antiguedad();
    }

    public int antiguedad()
    {
        return calcularAños(Getfecha_ingreso());
    }

    public int edad()
    {
        return calcularAños(GetfechaNac());
    }


    public int calcularAños(DateTime fecha)
    {
    DateTime now = DateTime.Today;
    int años = now.Year - fecha.Year;
    if (now < fecha.AddYears(años)) 
        años--;

    return años;
    }
}