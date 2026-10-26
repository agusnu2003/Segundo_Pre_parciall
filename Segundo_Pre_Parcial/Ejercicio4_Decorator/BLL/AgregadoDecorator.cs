using Ejercicio4_Decorator.Domain.Interfaces;

namespace Ejercicio4_Decorator.BLL;

// clase abstracta decoradora que envuelve una bebida
public abstract class AgregadoDecorator : IBebida
{
    protected IBebida _bebida;

    public AgregadoDecorator(IBebida bebida)
    {
        _bebida = bebida;
    }

    public virtual string ObtenerDescripcion()
    {
        return _bebida.ObtenerDescripcion();
    }

    public virtual double ObtenerCosto()
    {
        return _bebida.ObtenerCosto();
    }
}
