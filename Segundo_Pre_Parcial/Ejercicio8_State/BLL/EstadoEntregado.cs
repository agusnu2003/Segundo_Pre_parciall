using Ejercicio8_State.Domain;
using Ejercicio8_State.Domain.Interfaces;

namespace Ejercicio8_State.BLL;

public class EstadoEntregado : IEstadoPedido
{
    public void Siguiente(PedidoContexto pedido)
    {
        Console.WriteLine("-> El pedido ya fue entregado al cliente, no hay mas estados siguientes.");
    }

    public void Cancelar(PedidoContexto pedido)
    {
        Console.WriteLine("-> No se puede cancelar, el pedido ya fue entregado.");
    }

    public string ObtenerDescripcion()
    {
        return "ENTREGADO (Finalizado)";
    }
}
