using Ejercicio4_Decorator.Domain.Interfaces;

namespace Ejercicio4_Decorator.Domain;

// componente concreto base
public class CafeSimple : IBebida
{
    public string ObtenerDescripcion()
    {
        return "Café Simple";
    }

    public double ObtenerCosto()
    {
        return 1200.0;
    }
}
