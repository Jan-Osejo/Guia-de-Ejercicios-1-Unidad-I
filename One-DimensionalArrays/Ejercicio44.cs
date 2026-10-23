namespace Guía1.One_DimensionalArrays
{
    public class Ejercicio44
    {
        public void HistogramaCalificaciones()
        {
            // Arreglo de calificaciones
            Console.Write("Calificaciones a ingresar: ");
            int n = int.TryParse(Console.ReadLine(), out int cant) ? cant : 0;

            if (n <= 0)
            {
                Console.WriteLine("\nSe debe ingresar al menos 1 calificación.");
                return;
            }

            int[] calificaciones = new int[n];

            for (int i = 0; i < calificaciones.Length; i++)
            {
                int nota = -1;
                while (nota < 0 || nota > 100)
                {
                    Console.Write($"Ingrese la calificación {i + 1}: ");
                    nota = int.TryParse(Console.ReadLine(), out int val) ? val : -1;
                    
                    if (nota < 0 || nota > 100)
                    {
                        Console.WriteLine(" Ingrese un valor entre 0 y 100.");
                    }
                }
                calificaciones[i] = nota;
            }

            int[] conteoRangos = new int[5];

            foreach (int nota in calificaciones)
            {
                if (nota >= 0 && nota <= 59)
                {
                    conteoRangos[0]++;
                }
                else if (nota >= 60 && nota <= 69)
                {
                    conteoRangos[1]++;
                }
                else if (nota >= 70 && nota <= 79)
                {
                    conteoRangos[2]++;
                }
                else if (nota >= 80 && nota <= 89)
                {
                    conteoRangos[3]++;
                }
                else if (nota >= 90 && nota <= 100)
                {
                    conteoRangos[4]++;
                }
            }

            string[] etiquetas = { "00 - 59", "60 - 69", "70 - 79", "80 - 89", "90 - 100" };

            for (int i = 0; i < conteoRangos.Length; i++)
            {
                Console.Write($"{etiquetas[i].PadRight(8)} | ");

                for (int j = 0; j < conteoRangos[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine($" ({conteoRangos[i]})");
            }
        }
    }
}