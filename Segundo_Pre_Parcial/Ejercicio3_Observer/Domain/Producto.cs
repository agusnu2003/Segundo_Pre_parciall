using Ejercicio3_Observer.Domain.Interfaces;
using Ejercicio3_Observer.BLL.Interfaces;

namespace Ejercicio3_Observer.Domain;

// sujeto concreto que mantiene el estado y notifica
public class Producto : ISujeto
{
    private List<IObservador> _observadores = new List<IObservador>();
    
    public string Nombre { get; set; }
    private int _stock;

    public Producto(string nombre, int stockInicial)
    {
        Nombre = nombre;
        _stock = stockInicial;
    }

    public int Stock
    {
        get => _stock;
        set
        {
            _stock = value;
            // cada vez que cambia el stock avisamos a los suscriptores
            Notificar();
        }
    }

    public void Suscribir(IObservador observador)
    {
        _observadores.Add(observador);
    }

    public void Desuscribir(IObservador observador)
    {
        _observadores.Remove(observador);
    }

    public void Notificar()
    {
        foreach (var observador in _observadores)
        {
            observador.Actualizar(Nombre, _stock);
        }
    }
}
