using Ejercicio8_State.Domain;
using Ejercicio8_State.Domain.Interfaces;

namespace Ejercicio8_State.BLL;

public class EstadoPendiente : IEstadoPedido
{
    public void Siguiente(PedidoContexto pedido)
    {
        Console.WriteLine("-> El pedido fue despachado. Pasa a estado: ENVIADO.");
        pedido.EstadoActual = new EstadoEnviado();
    }

    public void Cancelar(PedidoContexto pedido)
    {
        Console.WriteLine("-> El pedido estaba pendiente y fue cancelado con exito.");
    }

    public string ObtenerDescripcion()
    {
        return "PENDIENTE (En preparacion en el deposito)";
    }
}
