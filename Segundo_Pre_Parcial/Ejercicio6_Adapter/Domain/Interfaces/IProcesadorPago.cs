namespace Ejercicio6_Adapter.Domain.Interfaces;

// interfaz objetivo que espera nuestro sistema
public interface IProcesadorPago
{
    void ProcesarPago(string cliente, double monto);
}
