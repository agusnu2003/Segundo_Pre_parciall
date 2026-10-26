namespace Ejercicio2_Strategy.BLL.Interfaces;

// interfaz comun para todas las estrategias de envio
public interface IEstrategiaEnvio
{
    double CalcularCosto(double montoPedido);
}
