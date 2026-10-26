using Ejercicio6_Adapter.Domain.Interfaces;

namespace Ejercicio6_Adapter.BLL;

// adaptador que envuelve el servicio externo para que coincida con nuestra interfaz
public class AdaptadorPagoExterno : IProcesadorPago
{
    private ServicioExternoPago _servicioExterno;

    public AdaptadorPagoExterno(ServicioExternoPago servicioExterno)
    {
        _servicioExterno = servicioExterno;
    }

    public void ProcesarPago(string cliente, double monto)
    {
        // convertimos los tipos y adaptamos los parametros
        string email = $"{cliente.ToLower().Replace(" ", "")}@correo.com";
        decimal importeDecimal = (decimal)monto;

        _servicioExterno.EjecutarTransaccion(email, importeDecimal);
    }
}
