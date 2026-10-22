namespace Guía1.Loops
{
    public class Ejercicio29
    {
        public void SerieFibonacci()
        {
            // Ingreso de datos
            Console.Write("Ingrese la cantidad de términos para la serie: ");
            int n = int.TryParse(Console.ReadLine(), out int num) ? num : 0;

            // Validación
            if (n <= 0)
            {
                Console.WriteLine("Ingrese una cantidad mayor a cero!");
                return;
            }

            // Inicio de la serie Fibonacci
            int a = 0;
            int b = 1;
            int suma = 0;

            Console.WriteLine($"\nLos {n} términos de la serie Fibonacci son: ");

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{a} "); // Se muestra el valor actual con un espacio
                suma = suma + a;

                // Proceso de la serie Fibonacci
                int siguiente = a + b;
                a = b;
                b = siguiente;
            }

            Console.WriteLine(); 

            double promedio = (double)suma / (double)n;

            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Promedio de los números: {promedio}");
        }
    }
}