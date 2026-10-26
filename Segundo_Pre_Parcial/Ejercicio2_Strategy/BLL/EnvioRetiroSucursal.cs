using Ejercicio2_Strategy.BLL.Interfaces;

namespace Ejercicio2_Strategy.BLL;

public class EnvioRetiroSucursal : IEstrategiaEnvio
{
    public double CalcularCosto(double montoPedido)
    {
        // retiro gratis
        return 0.0;
    }
}
