using Ejercicio2_Strategy.BLL.Interfaces;

namespace Ejercicio2_Strategy.Domain;

// contexto que mantiene la referencia a la estrategia seleccionada
public class Pedido
{
    public double Monto { get; set; }
    private IEstrategiaEnvio _estrategia;

    public Pedido(double monto, IEstrategiaEnvio estrategiaInicial)
    {
        Monto = monto;
        _estrategia = estrategiaInicial;
    }

    // permite cambiar la estrategia en tiempo de ejecucion
    public void CambiarEstrategia(IEstrategiaEnvio nuevaEstrategia)
    {
        _estrategia = nuevaEstrategia;
    }

    public double CalcularCostoEnvio()
    {
        return _estrategia.CalcularCosto(Monto);
    }

    public double CalcularTotal()
    {
        return Monto + CalcularCostoEnvio();
    }
}
