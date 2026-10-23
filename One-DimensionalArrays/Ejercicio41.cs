namespace Guía1.One_DimensionalArrays
{
    public class Ejercicio41
    {
        public void ArregloTemperaturas()
        {
            //Arreglo de temperaturas
            double[] temperaturas = new double[7];
            double suma = 0;

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.Write($"Temperatura para el día {i + 1}: ");
                temperaturas[i] = double.TryParse(Console.ReadLine(), out double t) ? t : 0;
                suma += temperaturas[i];
            }

            double promedio = suma / temperaturas.Length;

            double maxima = temperaturas[0];
            double minima = temperaturas[0];
            int diaMax = 1;
            int diaMin = 1;

            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] > maxima)
                {
                    maxima = temperaturas[i];
                    diaMax = i + 1;
                }
                
                if (temperaturas[i] < minima)
                {
                    minima = temperaturas[i];
                    diaMin = i + 1;
                }
            }
            //Resultados de la semana
            Console.WriteLine($"Promedio semanal:     {promedio:F2}°");
            Console.WriteLine($"Día más caluroso:     Día {diaMax} ({maxima:F2}°)");
            Console.WriteLine($"Día más frío:         Día {diaMin} ({minima:F2}°)");
            
            bool hayDiasSobrePromedio = false;
            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] > promedio)
                {
                    Console.WriteLine($"- Día {i + 1}: {temperaturas[i]:F2}°");
                    hayDiasSobrePromedio = true;
                }
            }
            if (!hayDiasSobrePromedio) Console.WriteLine("Ningún día superó el promedio.");

            for (int i = 0; i < temperaturas.Length - 1; i++)
            {
                double variación = temperaturas[i + 1] - temperaturas[i];
                string tendencia = variación > 0 ? "Subió" : (variación < 0 ? "Bajó" : "No cambió");
                Console.WriteLine($"Día {i + 1} a Día {i + 2}: {tendencia} {Math.Abs(variación):F2}°");
            }
        }
    }
}