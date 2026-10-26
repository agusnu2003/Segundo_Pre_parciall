using Ejercicio5_FactoryMethod.Domain;
using Ejercicio5_FactoryMethod.Domain.Interfaces;

namespace Ejercicio5_FactoryMethod.BLL;

public class CreadorSMS : CreadorNotificacion
{
    public override INotificacion CrearNotificacion()
    {
        // retorna la instancia concreta de sms
        return new NotificacionSMS();
    }
}
