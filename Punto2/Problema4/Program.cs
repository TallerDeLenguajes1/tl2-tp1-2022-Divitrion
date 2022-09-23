using System.Net;
using System.Text.Json;

get();

static void get()
{
    var url = $"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
    var request = (HttpWebRequest)WebRequest.Create(url);
    request.Method = "GET";
    request.ContentType = "application/json";
    request.Accept = "application/json";

    try
    {
        using (WebResponse response = request.GetResponse())
        {
            using (Stream strReader = response.GetResponseStream())
            {
                if (strReader == null) return;
                using (StreamReader objReader = new StreamReader(strReader))
                {
                    string responseBody = objReader.ReadToEnd();
                    var ListaProvincias = JsonSerializer.Deserialize<Provincias>(responseBody);
                    foreach (var provincia in ListaProvincias.provincias)
                    {
                        Console.WriteLine($"Nombre de la provincia: {provincia.nombre}");
                        Console.WriteLine($"Id de la provincia: {provincia.id}");
                        Console.WriteLine("-----------------------");
                    }
                }
            }
        }

    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine($"Tipo de excepcion: {ex.GetType().Name}");
        Console.WriteLine($"{ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Tipo de excepcion: {ex.GetType().Name}");
        Console.WriteLine($"{ex.Message}");
    }
}
