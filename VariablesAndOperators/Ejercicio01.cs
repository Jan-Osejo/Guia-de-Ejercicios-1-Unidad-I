namespace Guía1.VariablesAndOperators
{
    public class Ejercicio01
    { public void MoneyConverter()
        {
            Console.Write("Ingrese la cantidad de Lempiras: ");
            double lempiras = double.TryParse(Console.ReadLine(), out double l) ? l : 0;

            Console.Write("Ingrese la tasa de cambio a Dólares actual: ");
            double tasaDolar = double.TryParse(Console.ReadLine(), out double td) && td > 0 ? td : 1;

            Console.Write("Ingrese la tasa de cambio a Euros actual: ");
            double tasaEuro = double.TryParse(Console.ReadLine(), out double te) && te > 0 ? te : 1;

            double totalDolares = lempiras / tasaDolar;
            double totalEuros = lempiras / tasaEuro;
            
            Console.WriteLine($"Cantidad de Lempiras: L {lempiras:F2}");
            Console.WriteLine($"Equivalente en Dólares: $ {totalDolares:F2}");
            Console.WriteLine($"Equivalente en Euros: € {totalEuros:F2}");
        }
    }
}