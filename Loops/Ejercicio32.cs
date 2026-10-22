namespace Guía1.Loops
{
    public class Ejercicio32
    {
        public void PrimosEnRango()
        {
            // Ingreso de datos
            Console.Write("Ingrese un número para iniciar: ");
            int inicio = int.TryParse(Console.ReadLine(), out int n1) ? n1 : 0;

            Console.Write("Ingrese un número para finalizar: ");
            int fin = int.TryParse(Console.ReadLine(), out int n2) ? n2 : 0;

            // Validación
            if (inicio <= 0 || fin <= 0)
            {
                Console.WriteLine("Ingrese números mayores a cero!");
                return;
            }
            if (inicio > fin)
            {
                Console.WriteLine("El número de inicio no puede ser mayor que el fin!");
                return;
            }

            int cantidadPrimos = 0;
            Console.WriteLine($"\nNúmeros primos entre {inicio} y {fin}:");

            // Ciclo for para recorrer todos los números en el rango
            for (int i = inicio; i <= fin; i++)
            {
                int divisores = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        divisores = divisores + 1;
                    }
                }
                if (divisores == 2)
                {
                    Console.Write($"{i} ");
                    cantidadPrimos = cantidadPrimos + 1;
                }
            }

            Console.WriteLine($"\n\nNúmeros primos encontrados: {cantidadPrimos}");
        }
    }
}