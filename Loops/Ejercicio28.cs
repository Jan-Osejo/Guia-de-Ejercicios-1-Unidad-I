namespace Guía1.Loops
{
    public class Ejercicio28
    {
        public void DecimalABinario()
        {
            Console.Write("Ingrese un numero (entero positivo): ");
            int numero = int.TryParse(Console.ReadLine(), out int n) ? n : 0;

            // Validación 
            if (numero < 0)
            {
                Console.WriteLine("Ingrese un número entero positivo");
                return;
            }
            if (numero == 0)
            {
                Console.WriteLine("\nBinario de 0 es 0");
                return;
            }

            string binario = "";
            int numeroTemporal = numero;

            // Ciclo while para convertir el número a binario
            while (numeroTemporal > 0)
            {
                int residuo = numeroTemporal % 2;
                binario = residuo + binario;
                numeroTemporal = numeroTemporal / 2;
            }
            Console.WriteLine($"Binario: {binario}");
        }
    }  
}