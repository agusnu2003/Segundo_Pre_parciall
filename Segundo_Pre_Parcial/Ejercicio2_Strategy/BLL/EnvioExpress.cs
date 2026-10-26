using Ejercicio2_Strategy.BLL.Interfaces;

namespace Ejercicio2_Strategy.BLL;

public class EnvioExpress : IEstrategiaEnvio
{
    public double CalcularCosto(double montoPedido)
    {
        // 1200 fijo + 10% del total
        return 1200.0 + (montoPedido * 0.10);
    }
}
