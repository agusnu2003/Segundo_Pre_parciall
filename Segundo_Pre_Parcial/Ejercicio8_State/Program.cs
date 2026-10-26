using Ejercicio8_State.Domain;

namespace Ejercicio8_State;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SEGUIMIENTO DE PEDIDO (PATRON STATE) ===");

        // creamos el pedido (empieza en Pendiente)
        PedidoContexto pedido = new PedidoContexto();
        pedido.VerEstado();

        Console.WriteLine("\n--- Avanzamos de estado ---");
        pedido.AvanzarPaso();
        pedido.VerEstado();

        Console.WriteLine("\n--- Intentamos cancelar mientras viaja ---");
        pedido.CancelarPedido();

        Console.WriteLine("\n--- Llegada a destino ---");
        pedido.AvanzarPaso();
        pedido.VerEstado();

        Console.WriteLine("\n--- Intentamos avanzar de nuevo ---");
        pedido.AvanzarPaso();
    }
}
