using Ejercicio6_Adapter.Domain.Interfaces;
using Ejercicio6_Adapter.Domain;
using Ejercicio6_Adapter.BLL;

namespace Ejercicio6_Adapter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE PAGOS (PATRON ADAPTER) ===");

        // 1. Usando el procesador nativo
        IProcesadorPago pagoNativo = new ProcesadorNativo();
        pagoNativo.ProcesarPago("Juan Perez", 4500.0);

        // 2. Usando el servicio externo a traves del adaptador
        ServicioExternoPago apiExterna = new ServicioExternoPago();
        IProcesadorPago pagoAdaptado = new AdaptadorPagoExterno(apiExterna);
        pagoAdaptado.ProcesarPago("Maria Gomez", 12000.0);
    }
}
