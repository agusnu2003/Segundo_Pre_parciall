using Ejercicio3_Observer.BLL.Interfaces;

namespace Ejercicio3_Observer.Domain.Interfaces;

// interfaz para el sujeto notificable
public interface ISujeto
{
    void Suscribir(IObservador observador);
    void Desuscribir(IObservador observador);
    void Notificar();
}
