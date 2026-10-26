using Ejercicio4_Decorator.Domain.Interfaces;

namespace Ejercicio4_Decorator.BLL;

public class Canela : AgregadoDecorator
{
    public Canela(IBebida bebida) : base(bebida)
    {
    }

    public override double ObtenerCosto()
    {
        return _bebida.ObtenerCosto() + 150.0;
    }

    public override string ObtenerDescripcion()
    {
        return $"{_bebida.ObtenerDescripcion()}, con Canela";
    }
}
