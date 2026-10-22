namespace Guía1.Loops
{
    public class Ejercicio30
    {
        public void FactorialYCombinaciones()
        {
            // Ingreso de datos
            Console.Write("Valor para N: ");
            int n = int.TryParse(Console.ReadLine(), out int numN) ? numN : 0;

            Console.Write("Valor para R: ");
            int r = int.TryParse(Console.ReadLine(), out int numR) ? numR : 0;

            // Validaciones básicas de tu maestro
            if (n < 0 || r < 0)
            {
                Console.WriteLine("Ingrese números positivos!");
                return;
            }
            if (n < r)
            {
                Console.WriteLine("N debe ser mayor o igual a R!");
                return;
            }

            int factorialN = 1; 
            for (int i = 1; i <= n; i++)
            {
                factorialN = factorialN * i;
            }

            int factorialR = 1;
            for (int i = 1; i <= r; i++)
            {
                factorialR = factorialR * i;
            }

            int resta = n - r;
            int factorialResta = 1;
            for (int i = 1; i <= resta; i++)
            {
                factorialResta = factorialResta * i;
            }

            // Resultado final
            int combinaciones = factorialN / (factorialR * factorialResta);
            Console.WriteLine($"\nEl factorial de {n} es: {factorialN}");
            Console.WriteLine($"Posibles combinaciones: {combinaciones}");
        }
    }
}