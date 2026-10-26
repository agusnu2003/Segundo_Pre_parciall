using Ejercicio2_Strategy.BLL.Interfaces;

namespace Ejercicio2_Strategy.BLL;

public class EnvioEstandar : IEstrategiaEnvio
{
    public double CalcularCosto(double montoPedido)
    {
        // tarifa fija de 500
        return 500.0;
    }
}
