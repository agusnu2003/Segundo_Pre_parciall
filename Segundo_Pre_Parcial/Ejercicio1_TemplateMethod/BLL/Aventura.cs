namespace Ejercicio1_TemplateMethod.BLL;

// clase base abstracta que define el esqueleto
public abstract class Aventura
{
    // metodo plantilla: define el flujo general invariable
    public void Jugar()
    {
        MostrarIntroduccion();
        int opcion = ValidarEleccion();
        EjecutarAccion(opcion);
        MostrarDesenlaceComun();
    }

    // paso especifico para cada aventura
    protected abstract void MostrarIntroduccion();

    // se valida la eleccion del jugador
    protected virtual int ValidarEleccion()
    {
        int opcion;
        while (true)
        {
            Console.Write("\nIngresa tu opción (1 o 2): ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out opcion) && (opcion == 1 || opcion == 2))
            {
                return opcion;
            }
            Console.WriteLine("Opción no válida. Debe ser 1 o 2.");
        }
    }

    // comportamiento especifico segun la aventura
    protected abstract void EjecutarAccion(int opcion);

    // desenlace comun para todas las aventuras
    protected void MostrarDesenlaceComun()
    {
        Console.WriteLine("\n[Desenlace Común] Tras esta experiencia, el aventurero descansa y reflexiona sobre su viaje.");
    }
}
