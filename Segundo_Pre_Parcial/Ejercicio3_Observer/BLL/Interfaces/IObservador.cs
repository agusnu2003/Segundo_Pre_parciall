namespace Ejercicio3_Observer.BLL.Interfaces;

// interfaz que deben implementar todos los observadores
public interface IObservador
{
    void Actualizar(string nombreProducto, int stockActual);
}
