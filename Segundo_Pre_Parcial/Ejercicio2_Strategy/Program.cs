using Ejercicio2_Strategy.Domain;
using Ejercicio2_Strategy.BLL;

namespace Ejercicio2_Strategy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE PEDIDOS (PATRON STRATEGY) ===");
        
        double monto = 5000.0;
        Console.WriteLine($"Monto base del pedido: ${monto}");

        // creamos el pedido con envio estandar inicialmente
        Pedido pedido = new Pedido(monto, new EnvioEstandar());
        Console.WriteLine($"Con Envío Estándar -> Costo Envío: ${pedido.CalcularCostoEnvio()} | Total: ${pedido.CalcularTotal()}");

        // cambiamos a express
        pedido.CambiarEstrategia(new EnvioExpress());
        Console.WriteLine($"Cambiando a Envío Express -> Costo Envío: ${pedido.CalcularCostoEnvio()} | Total: ${pedido.CalcularTotal()}");

        // cambiamos a retiro en sucursal
        pedido.CambiarEstrategia(new EnvioRetiroSucursal());
        Console.WriteLine($"Cambiando a Retiro en Sucursal -> Costo Envío: ${pedido.CalcularCostoEnvio()} | Total: ${pedido.CalcularTotal()}");

        // probamos tambien el envio internacional
        pedido.CambiarEstrategia(new EnvioInternacional());
        Console.WriteLine($"Cambiando a Envío Internacional -> Costo Envío: ${pedido.CalcularCostoEnvio()} | Total: ${pedido.CalcularTotal()}");

        // otro ejemplo: procesar una lista de pedidos variados
        Console.WriteLine("\n--- Ejemplo con lista de pedidos ---");
        List<Pedido> listaPedidos = new List<Pedido>()
        {
            new Pedido(1500.0, new EnvioRetiroSucursal()),
            new Pedido(8000.0, new EnvioEstandar()),
            new Pedido(12000.0, new EnvioExpress()),
            new Pedido(30000.0, new EnvioInternacional())
        };

        int i = 1;
        foreach (var p in listaPedidos)
        {
            Console.WriteLine($"Pedido #{i} | Monto: ${p.Monto} | Costo Envío: ${p.CalcularCostoEnvio()} | Total: ${p.CalcularTotal()}");
            i++;
        }

        // ejemplo con un pedido de monto bajo
        Console.WriteLine("\n--- Ejemplo con pedido chico ---");
        Pedido pedidoChico = new Pedido(750.0, new EnvioExpress());
        Console.WriteLine($"Pedido chico express -> Envío: ${pedidoChico.CalcularCostoEnvio()} | Total: ${pedidoChico.CalcularTotal()}");
    }
}

