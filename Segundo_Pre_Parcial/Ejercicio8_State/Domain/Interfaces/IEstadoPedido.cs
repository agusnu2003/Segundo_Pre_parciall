namespace Ejercicio8_State.Domain.Interfaces;

public interface IEstadoPedido
{
    void Siguiente(PedidoContexto pedido);
    void Cancelar(PedidoContexto pedido);
    string ObtenerDescripcion();
}
