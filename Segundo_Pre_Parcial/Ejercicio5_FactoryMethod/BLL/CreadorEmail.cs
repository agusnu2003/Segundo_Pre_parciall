using Ejercicio5_FactoryMethod.Domain;
using Ejercicio5_FactoryMethod.Domain.Interfaces;

namespace Ejercicio5_FactoryMethod.BLL;

public class CreadorEmail : CreadorNotificacion
{
    public override INotificacion CrearNotificacion()
    {
        // retorna la instancia concreta de email
        return new NotificacionEmail();
    }
}
