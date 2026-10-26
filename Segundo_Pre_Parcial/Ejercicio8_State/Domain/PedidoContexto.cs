using Ejercicio8_State.Domain.Interfaces;
using Ejercicio8_State.BLL;

namespace Ejercicio8_State.Domain;

public class PedidoContexto
{
    public IEstadoPedido EstadoActual { get; set; }

    public PedidoContexto()
    {
        // estado inicial por defecto
        EstadoActual = new EstadoPendiente();
    }

    public void AvanzarPaso()
    {
        EstadoActual.Siguiente(this);
    }

    public void CancelarPedido()
    {
        EstadoActual.Cancelar(this);
    }

    public void VerEstado()
    {
        Console.WriteLine($"Estado actual del pedido: {EstadoActual.ObtenerDescripcion()}");
    }
}
