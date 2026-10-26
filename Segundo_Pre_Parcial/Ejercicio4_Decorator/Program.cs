using Ejercicio4_Decorator.Domain.Interfaces;
using Ejercicio4_Decorator.Domain;
using Ejercicio4_Decorator.BLL;

namespace Ejercicio4_Decorator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== CAFETERIA (PATRON DECORATOR) ===");

        // 1. Cafe solo
        IBebida cafe = new CafeSimple();
        Console.WriteLine($"1. {cafe.ObtenerDescripcion()} -> ${cafe.ObtenerCosto()}");

        // 2. Le agregamos leche
        cafe = new Leche(cafe);
        Console.WriteLine($"2. {cafe.ObtenerDescripcion()} -> ${cafe.ObtenerCosto()}");

        // 3. Le agregamos chocolate encima
        cafe = new Chocolate(cafe);
        Console.WriteLine($"3. {cafe.ObtenerDescripcion()} -> ${cafe.ObtenerCosto()}");

        // 4. Cafe armado directamente encadenado (cafe con doble leche y chocolate)
        IBebida cafeEspecial = new Chocolate(new Leche(new Leche(new CafeSimple())));
        Console.WriteLine($"\n4. Pedido especial (doble leche y chocolate):\n{cafeEspecial.ObtenerDescripcion()} -> ${cafeEspecial.ObtenerCosto()}");

        // 5. Cafe con canela
        IBebida cafeCanela = new Canela(new CafeSimple());
        Console.WriteLine($"\n5. Pedido simple con canela:\n{cafeCanela.ObtenerDescripcion()} -> ${cafeCanela.ObtenerCosto()}");
    }
}
