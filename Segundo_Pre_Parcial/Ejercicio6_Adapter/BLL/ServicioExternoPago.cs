namespace Ejercicio6_Adapter.BLL;

// clase de una libreria externa con metodos y tipos distintos
public class ServicioExternoPago
{
    public void EjecutarTransaccion(string emailUsuario, decimal valorEnPesos)
    {
        Console.WriteLine($"[API Externa] Transaccion exitosa por ${valorEnPesos} a la cuenta {emailUsuario}.");
    }
}
