using Ejercicio3_Observer.Domain;
using Ejercicio3_Observer.BLL;

namespace Ejercicio3_Observer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE STOCK (PATRON OBSERVER) ===");

        // creamos el producto (sujeto)
        Producto monitor = new Producto("Monitor 24 pulgadas", 12);

        // creamos los observadores
        PantallaAlmacen pantalla = new PantallaAlmacen();
        AlertaCompras compras = new AlertaCompras();

        // suscribimos ambos observadores
        monitor.Suscribir(pantalla);
        monitor.Suscribir(compras);

        Console.WriteLine("\n--- Venta de 4 unidades ---");
        monitor.Stock -= 4; // stock pasa a 8

        Console.WriteLine("\n--- Venta de 5 unidades ---");
        monitor.Stock -= 5; // stock pasa a 3 (activa la alerta)

        Console.WriteLine("\n--- Desuscribimos la pantalla de almacen ---");
        //monitor.Desuscribir(pantalla);

        Console.WriteLine("\n--- Venta de 1 unidad adicional ---");
        monitor.Stock -= 1; // solo notifica a compras
    }
}
