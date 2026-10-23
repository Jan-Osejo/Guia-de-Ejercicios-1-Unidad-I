namespace Guía1.Lists
{
    public class Ejercicio47
    {
        public void Ejecutar()
        {
            List<double> calificaciones = new List<double>();
            string opciónContinuar;

            do
            {
                Console.Write($"\nIngrese la calificación {calificaciones.Count + 1} (0 a 100): ");
                double calificaciónActual = double.TryParse(Console.ReadLine(), out double err) ? err : -1;

                while (calificaciónActual < 0 || calificaciónActual > 100)
                {
                    Console.Write("  -> Valor inválido. Ingrese una nota entre 0 y 100: ");
                    calificaciónActual = double.TryParse(Console.ReadLine(), out err) ? err : -1;
                }

                calificaciones.Add(calificaciónActual);

                Console.Write("¿Desea ingresar otra calificación? (s/n): ");
                opciónContinuar = (Console.ReadLine() ?? "").Trim().ToLower();

            } while (opciónContinuar == "s");

            double notaMasAlta = calificaciones[0];
            double notaMasBaja = calificaciones[0];

            foreach (double calificación in calificaciones)
            {
                if (calificación > notaMasAlta)
                {
                    notaMasAlta = calificación;
                }
                
                if (calificación < notaMasBaja)
                {
                    notaMasBaja = calificación;
                }
            }

            Console.WriteLine($"Promedio inicial:    {CalcularPromedio(calificaciones):F2}");
            Console.WriteLine($"Calificación máxima: {notaMasAlta:F2}");
            Console.WriteLine($"Calificación mínima: {notaMasBaja:F2}");

            calificaciones.Remove(notaMasBaja);
            Console.WriteLine($"\nSe eliminó la calificación más baja del registro ({notaMasBaja:F2}).");

            if (calificaciones.Count == 0)
            {
                Console.WriteLine("No hay calificaciones para calcular el promedio.");
            }
            else
            {
                Console.WriteLine($"Nuevo promedio final: {CalcularPromedio(calificaciones):F2}");
            }

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        private double CalcularPromedio(List<double> listaCalificaciones)
        {
            double sumaTotal = 0;

            foreach (double valor in listaCalificaciones)
            {
                sumaTotal += valor;
            }

            return sumaTotal / listaCalificaciones.Count;
        }
    }
}