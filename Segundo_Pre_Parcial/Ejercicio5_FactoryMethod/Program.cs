using Ejercicio5_FactoryMethod.BLL;

namespace Ejercicio5_FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE NOTIFICACIONES (PATRON FACTORY METHOD) ===");

        // creamos el creador de emails
        CreadorNotificacion creador = new CreadorEmail();
        creador.Notificar("Tu compra fue aprobada con exito.");

        // cambiamos al creador de SMS
        creador = new CreadorSMS();
        creador.Notificar("Codigo de verificacion: 4892.");
    }
}
