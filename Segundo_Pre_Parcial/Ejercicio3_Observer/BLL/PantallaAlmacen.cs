using Ejercicio3_Observer.BLL.Interfaces;

namespace Ejercicio3_Observer.BLL;

public class PantallaAlmacen : IObservador
{
    public void Actualizar(string nombreProducto, int stockActual)
    {
        Console.WriteLine($"[Pantalla Almacén] Info actualizada -> Producto: {nombreProducto} | Stock disponible: {stockActual}");
    }
}
