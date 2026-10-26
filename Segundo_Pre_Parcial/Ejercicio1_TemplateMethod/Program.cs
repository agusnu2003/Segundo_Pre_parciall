using Ejercicio1_TemplateMethod.BLL;

namespace Ejercicio1_TemplateMethod;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SIMULADOR DE AVENTURAS ===");
        Console.WriteLine("Selecciona la aventura que deseas jugar:");
        Console.WriteLine("1. Explorar la Cueva");
        Console.WriteLine("2. Navegar el Río");
        Console.Write("Opción: ");

        string? seleccion = Console.ReadLine();
        Console.WriteLine();

        Aventura aventura;

        if (seleccion == "1")
        {
            aventura = new AventuraCueva();
        }
        else if (seleccion == "2")
        {
            aventura = new AventuraRio();
        }
        else
        {
            Console.WriteLine("Opción no válida.");
            return;
        }

        // ejecutamos el flujo definido en el metodo plantilla
        aventura.Jugar();
    }
}
