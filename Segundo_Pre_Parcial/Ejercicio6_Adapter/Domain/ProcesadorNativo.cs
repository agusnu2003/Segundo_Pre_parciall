using Ejercicio6_Adapter.Domain.Interfaces;

namespace Ejercicio6_Adapter.Domain;

public class ProcesadorNativo : IProcesadorPago
{
    public void ProcesarPago(string cliente, double monto)
    {
        Console.WriteLine($"[Sistema Propio] Cobro de ${monto} procesado para {cliente}.");
    }
}
