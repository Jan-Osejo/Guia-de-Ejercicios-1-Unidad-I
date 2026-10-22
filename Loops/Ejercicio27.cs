namespace Guía1.Loops
{
    public class Ejercicio27
    {
        public void InvertirNumero()
        {
            Console.Write("Ingrese un número entero positivo: ");
            
            // Ingresamos datos
            int num = int.TryParse(Console.ReadLine(), out int n) ? n : 0;

            // Validación 
            if (num < 0)
            {
                Console.WriteLine("Ingrese un número entero positivo");
                return;
            }

            // Variables
            int numero = num;
            int numInvert = 0;

            // ciclo while requerido
            while (numero > 0)
            {
                int dígito = numero % 10;
                numInvert = (numInvert * 10) + dígito;
                numero = numero / 10;
            }

            Console.WriteLine($"\nNúmero original: {num}");
            Console.WriteLine($"Número invertido: {numInvert}");

            // Es palíndromo si son iguales (capícua)
            if (num == numInvert)
            {
                Console.WriteLine("El numero es palíndromo (capicúa)");
            }
            else
            {
                Console.WriteLine("El numero no es palíndromo");
            }
        }
    }
}