namespace Guía1.One_DimensionalArrays
{
    public class Ejercicio39
    {
        public void EstadísticasDeCalificaciones()
        {  
            //Ingreso de calificaciones
            Console.Write("Calificaciones a ingresar: ");
            int n = int.TryParse(Console.ReadLine(), out int cant) ? cant : 0;

            if (n <= 0)
            {
                Console.WriteLine("\nIngrese un valor mayor a cero");
            }

            double[] calificaciones = new double[n];
            double suma = 0;

            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.Write($"Ingrese la calificación {i + 1}: ");
                calificaciones[i] = double.TryParse(Console.ReadLine(), out double nota) ? nota : 0;
                suma += calificaciones[i]; 
            }

            double promedio = suma / n;
            
            double maxima = calificaciones[0];
            double minima = calificaciones[0];
            int aprobados = 0;
            int reprobados = 0;
            
            double notaParaAprobar = 65.0; 

            foreach (double calificación in calificaciones)
            {
                if (calificación > maxima) maxima = calificación;
                if (calificación < minima) minima = calificación;
                
                if (calificación >= notaParaAprobar)
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
            }

            double sumaDiferenciasCuadrado = 0;
            
            for (int i = 0; i < calificaciones.Length; i++)
            {
                // Diferencia entre la calificación y el promedio, elevada al cuadrado
                double diferencia = calificaciones[i] - promedio;
                sumaDiferenciasCuadrado += Math.Pow(diferencia, 2);
            }
            
            double varianza = sumaDiferenciasCuadrado / n; 
            double desviaciónEstándar = Math.Sqrt(varianza);

            // Resultados
            Console.WriteLine($"Calificaciones ingresadas:  {n}");
            Console.WriteLine($"Promedio:           {promedio:F2}");
            Console.WriteLine($"Calificación máxima:       {maxima:F2}");
            Console.WriteLine($"Calificación mínima:       {minima:F2}");
            Console.WriteLine($"Aprobados (>= {notaParaAprobar}):        {aprobados}");
            Console.WriteLine($"Reprobados (< {notaParaAprobar}):         {reprobados}");
            Console.WriteLine($"Desviación estándar:       {desviaciónEstándar:F2}");

        }
    }
}