namespace Ejercicio7_Singleton.Domain;

public class ConfiguracionSistema
{
    // variable estatica que guarda la unica instancia
    private static ConfiguracionSistema? _instancia;

    public string Idioma { get; set; }
    public string ServidorBD { get; set; }
    public int Puerto { get; set; }

    // constructor privado para evitar new desde afuera
    private ConfiguracionSistema()
    {
        Idioma = "Español";
        ServidorBD = "localhost";
        Puerto = 5432;
    }

    // metodo para acceder a la instancia
    public static ConfiguracionSistema ObtenerInstancia()
    {
        if (_instancia == null)
        {
            _instancia = new ConfiguracionSistema();
        }
        return _instancia;
    }

    public void MostrarConfig()
    {
        Console.WriteLine($"Config actual -> Idioma: {Idioma} | Servidor: {ServidorBD}:{Puerto}");
    }
}
