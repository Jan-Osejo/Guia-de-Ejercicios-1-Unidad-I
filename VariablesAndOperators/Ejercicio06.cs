namespace Guía1.VariablesAndOperators
{
    public class Ejercicio06
    {
        public void SumarDígitos()
        {
            Console.Write("Ingrese un número entero positivo de 3 dígitos: ");

            // Entrada de datos
            int numero = int.TryParse(Console.ReadLine(), out int n) ? n : 0;

            // Evaluamos la entrada
            if (numero >= 100 && numero <= 999)
            {
                int centenas = numero / 100;

                int decenas = (numero % 100) / 10;

                int unidades = numero % 10;

                int suma = centenas + decenas + unidades;

                Console.WriteLine($"Número a evaluar: {numero}");
                Console.WriteLine($"Resultados matemáticos: {centenas} + {decenas} + {unidades} = {suma}");
                Console.WriteLine($"Suma final: {suma}");
            }
            else
            {
                Console.WriteLine("Error: Debe ingresar un número válido de exactamente 3 dígitos.");
            }
        }
    }
}