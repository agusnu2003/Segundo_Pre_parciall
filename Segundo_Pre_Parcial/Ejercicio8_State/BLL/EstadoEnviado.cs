using Ejercicio8_State.Domain;
using Ejercicio8_State.Domain.Interfaces;

namespace Ejercicio8_State.BLL;

public class EstadoEnviado : IEstadoPedido
{
    public void Siguiente(PedidoContexto pedido)
    {
        Console.WriteLine("-> El paquete llego a destino. Pasa a estado: ENTREGADO.");
        pedido.EstadoActual = new EstadoEntregado();
    }

    public void Cancelar(PedidoContexto pedido)
    {
        Console.WriteLine("-> No se puede cancelar directamente un pedido que ya esta en camino.");
    }

    public string ObtenerDescripcion()
    {
        return "ENVIADO (En viaje al domicilio)";
    }
}
