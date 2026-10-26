using Ejercicio7_Singleton.Domain;

namespace Ejercicio7_Singleton;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== CONFIGURACION GLOBAL (PATRON SINGLETON) ===");

        // obtenemos la instancia por primera vez
        ConfiguracionSistema config1 = ConfiguracionSistema.ObtenerInstancia();
        config1.MostrarConfig();

        // modificamos un valor desde la primera referencia
        config1.Idioma = "Inglés";
        config1.Puerto = 8080;

        // pedimos la instancia desde otro lugar del programa
        ConfiguracionSistema config2 = ConfiguracionSistema.ObtenerInstancia();
        config2.MostrarConfig();

        // comprobamos que ambas variables apuntan exactamente al mismo objeto en memoria
        bool sonLaMismaInstancia = ReferenceEquals(config1, config2);
        Console.WriteLine($"¿Apuntan al mismo objeto en memoria? {sonLaMismaInstancia}");
    }
}
