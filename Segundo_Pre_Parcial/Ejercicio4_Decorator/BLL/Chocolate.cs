using Ejercicio4_Decorator.Domain.Interfaces;

namespace Ejercicio4_Decorator.BLL;

public class Chocolate : AgregadoDecorator
{
    public Chocolate(IBebida bebida) : base(bebida) { }

    public override string ObtenerDescripcion()
    {
        return _bebida.ObtenerDescripcion() + " + Chocolate";
    }

    public override double ObtenerCosto()
    {
        // suma 450 pesos
        return _bebida.ObtenerCosto() + 450.0;
    }
}
