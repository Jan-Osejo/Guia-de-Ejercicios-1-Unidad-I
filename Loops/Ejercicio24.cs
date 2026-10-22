namespace Guía1.Loops
{
    public class Ejercicio24
    {
        public void SumaParesImpares()
        {
            Console.Write("Ingrese el número límite: ");
            int n = int.TryParse(Console.ReadLine(), out int num) ? num : 0;

            if (n <= 0)
            {
                Console.WriteLine("Ingrese un numero mayor a cero");
                return; 
            }

            int sumaPares = 0;
            int cantidadPares = 0;
            
            int sumaImpares = 0;
            int cantidadImpares = 0;

            // Recorremos los números del 1 hasta la "n"
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    // Suma de pares
                    sumaPares = sumaPares + i;
                    cantidadPares = cantidadPares + 1;
                }
                else
                {
                    // Suma de impares
                    sumaImpares = sumaImpares + i;
                    cantidadImpares = cantidadImpares + 1;
                }
            }
            Console.WriteLine($"Cantidad de pares: {cantidadPares}");
            Console.WriteLine($"Suma de pares: {sumaPares}");
            
            Console.WriteLine($"Cantidad de impares: {cantidadImpares}");
            Console.WriteLine($"Suma de impares: {sumaImpares}");
        }
    }
}
