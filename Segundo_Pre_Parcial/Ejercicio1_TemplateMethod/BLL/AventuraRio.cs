namespace Ejercicio1_TemplateMethod.BLL;

public class AventuraRio : Aventura
{
    protected override void MostrarIntroduccion()
    {
        Console.WriteLine("--- Aventura en el Río ---");
        Console.WriteLine("Llegas a la orilla de un río caudaloso con fuertes corrientes.");
        Console.WriteLine("Opciones disponibles:");
        Console.WriteLine("1. Construir una balsa");
        Console.WriteLine("2. Intentar nadar");
    }

    protected override void EjecutarAccion(int opcion)
    {
        Console.WriteLine("\n[Acción]");
        if (opcion == 1)
        {
            Console.WriteLine("Construyes una balsa: permite cruzar con éxito a la otra orilla.");
        }
        else
        {
            Console.WriteLine("Intentas nadar: la corriente te arrastra con fuerza y apenas logras salir con vida.");
        }
    }
}
