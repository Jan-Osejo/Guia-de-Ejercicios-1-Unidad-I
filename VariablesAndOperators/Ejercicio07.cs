namespace Guía1.VariablesAndOperators
{
    public class Ejercicio07
    {
        public void CalcularTiempoTranscurrido()
        {
            // Datos de la primera hora
            Console.Write("Ingrese la hora 1: ");
            int horas1 = int.TryParse(Console.ReadLine(), out int nro1) ? nro1 : 0;
            Console.Write("Ingrese los minutos 1: ");
            int minutos1 = int.TryParse(Console.ReadLine(), out int nro2) ? nro2 : 0;
            Console.Write("Ingrese los segundos 1: ");
            int segundos1 = int.TryParse(Console.ReadLine(), out int nro3) ? nro3 : 0;
            if (horas1 < 0 || minutos1 < 0 || segundos1 < 0)
            {
                Console.WriteLine("Error: Los datos deben ser positivos.");
            }

            // Datos de la segunda hora
            Console.Write("Ingrese la hora 2: ");
            int horas2 = int.TryParse(Console.ReadLine(), out int nro4) ? nro4 : 0;
            Console.Write("Ingrese los minutos 2: ");
            int minutos2 = int.TryParse(Console.ReadLine(), out int nro5) ? nro5 : 0;
            Console.Write("Ingrese los segundos 2: ");
            int segundos2 = int.TryParse(Console.ReadLine(), out int nro6) ? nro6 : 0;
            if (horas2 < 0 || minutos2 < 0 || segundos2 < 0)
            {
                Console.WriteLine("Error: Los datos deben ser positivos.");
            }

            // Evaluamos la entrada
            if (horas1 >= 0 && minutos1 >= 0 && segundos1 >= 0 && horas2 >= 0 && minutos2 >= 0 && segundos2 >= 0)
            {
                // Proceso para convertir todo a segundos
                int total1 = (horas1 * 3600) + (minutos1 * 60) + segundos1;
                int total2 = (horas2 * 3600) + (minutos2 * 60) + segundos2;
                
                int diferencia = total1 - total2;

               // Si es negativo se multiplica por -1
                if (diferencia < 0)
                {
                    diferencia = diferencia * -1;
                }

                int horas = diferencia / 3600;
                int minutos = (diferencia % 3600) / 60;
                int segundos = diferencia % 60;

                Console.WriteLine($"\nDiferencia de tiempos: {horas} horas, {minutos} minutos y {segundos} segundos.");
            }
            else
            {
                Console.WriteLine("\nIngrese datos válidos.");
            }   
        }
    }
}