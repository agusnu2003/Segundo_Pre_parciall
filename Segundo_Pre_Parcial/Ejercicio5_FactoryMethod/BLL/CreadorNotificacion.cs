using Ejercicio5_FactoryMethod.Domain.Interfaces;

namespace Ejercicio5_FactoryMethod.BLL;

// clase creadora abstracta que define el factory method
public abstract class CreadorNotificacion
{
    // este es el factory method que cada subclase va a implementar
    public abstract INotificacion CrearNotificacion();

    // logica de negocio que usa el producto creado
    public void Notificar(string mensaje)
    {
        var notificacion = CrearNotificacion();
        notificacion.Enviar(mensaje);
    }
}
