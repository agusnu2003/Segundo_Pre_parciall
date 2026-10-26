using Ejercicio4_Decorator.Domain.Interfaces;

namespace Ejercicio4_Decorator.BLL;

public class Leche : AgregadoDecorator
{
    public Leche(IBebida bebida) : base(bebida) { }

    public override string ObtenerDescripcion()
    {
        return _bebida.ObtenerDescripcion() + " + Leche";
    }

    public override double ObtenerCosto()
    {
        // suma 300 pesos
        return _bebida.ObtenerCosto() + 300.0;
    }
}
