namespace Guía1.One_DimensionalArrays
{
    public class Ejercicio40 
    {
        public void FrecuenciaElementos()
        {
            // Arreglo de números
            int[] números = new int[20];
            Random rand = new Random();

            Console.WriteLine("Números generados al azar:");
            
            // Generación de los 20 números
            for (int i = 0; i < números.Length; i++)
            {
                números[i] = rand.Next(1, 11);
                Console.Write(números[i] + " "); 
            }
            Console.WriteLine("\n"); 

            int[] frecuencias = new int[11];

            foreach (int numero in números)
            {
                frecuencias[numero]++;
            }

            int maxFrecuencia = -1;
            int minFrecuencia = 21; 
            
            int numeroMasFrecuente = 0;
            int numeroMenosFrecuente = 0;
            
            // Evaluamos solo del 1 al 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Número {i}: {frecuencias[i]} veces");
                
                if (frecuencias[i] > maxFrecuencia)
                {
                    maxFrecuencia = frecuencias[i];
                    numeroMasFrecuente = i;
                }
                if (frecuencias[i] < minFrecuencia)
                {
                    minFrecuencia = frecuencias[i];
                    numeroMenosFrecuente = i;
                }
            }

            Console.WriteLine($"El número más frecuente:   El {numeroMasFrecuente} apareció {maxFrecuencia} veces");
            Console.WriteLine($"El número menos frecuente: El {numeroMenosFrecuente} apareció {minFrecuencia} veces");
        }
    }
}