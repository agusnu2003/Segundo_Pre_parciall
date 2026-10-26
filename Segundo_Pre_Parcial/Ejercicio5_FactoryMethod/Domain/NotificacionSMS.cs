using Ejercicio5_FactoryMethod.Domain.Interfaces;

namespace Ejercicio5_FactoryMethod.Domain;

public class NotificacionSMS : INotificacion
{
    public void Enviar(string mensaje)
    {
        Console.WriteLine($"[SMS] Enviando SMS al telefono: {mensaje}");
    }
}
