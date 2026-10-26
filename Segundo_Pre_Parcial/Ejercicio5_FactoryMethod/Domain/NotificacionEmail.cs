using Ejercicio5_FactoryMethod.Domain.Interfaces;

namespace Ejercicio5_FactoryMethod.Domain;

public class NotificacionEmail : INotificacion
{
    public void Enviar(string mensaje)
    {
        Console.WriteLine($"[EMAIL] Enviando correo: {mensaje}");
    }
}
