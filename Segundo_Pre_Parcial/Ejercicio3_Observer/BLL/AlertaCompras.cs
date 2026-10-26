using Ejercicio3_Observer.BLL.Interfaces;

namespace Ejercicio3_Observer.BLL;

public class AlertaCompras : IObservador
{
    private int _limiteMinimo = 5;

    public void Actualizar(string nombreProducto, int stockActual)
    {
        if (stockActual < _limiteMinimo)
        {
            Console.WriteLine($"[ALERTA COMPRAS] URGENTE: El stock de '{nombreProducto}' cayó a {stockActual}. Reordenar pedido.");
        }
    }
}
