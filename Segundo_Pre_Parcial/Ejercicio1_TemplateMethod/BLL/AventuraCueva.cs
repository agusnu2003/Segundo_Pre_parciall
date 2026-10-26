namespace Ejercicio1_TemplateMethod.BLL;

public class AventuraCueva : Aventura
{
    protected override void MostrarIntroduccion()
    {
        Console.WriteLine("--- Aventura en la Cueva ---");
        Console.WriteLine("Te adentras en una cueva oscura y profunda. Apenas ves lo que tienes adelante.");
        Console.WriteLine("Opciones disponibles:");
        Console.WriteLine("1. Encender antorcha");
        Console.WriteLine("2. Avanzar a ciegas");
    }

    protected override void EjecutarAccion(int opcion)
    {
        Console.WriteLine("\n[Acción]");
        if (opcion == 1)
        {
            Console.WriteLine("Enciendes la antorcha: ilumina el camino y revela un tesoro escondido.");
        }
        else
        {
            Console.WriteLine("Avanzas a ciegas: tropiezas y caes en un pozo profundo.");
        }
    }
}
