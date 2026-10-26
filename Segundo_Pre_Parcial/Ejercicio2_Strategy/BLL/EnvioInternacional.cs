using Ejercicio2_Strategy.BLL.Interfaces;

namespace Ejercicio2_Strategy.BLL;

public class EnvioInternacional : IEstrategiaEnvio
{
    public double CalcularCosto(double montoPedido)
    {
        // tarifa fija de 3500 + 20% del pedido
        return 3500.0 + (montoPedido * 0.20);
    }
}
