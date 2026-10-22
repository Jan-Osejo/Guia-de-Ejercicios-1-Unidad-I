namespace Guía1.ControlStructures
{
    public class Ejercicio18
    {
        public void CalcularTarifa()
        {
            Console.Write("Horas de estacionamiento acumulados: ");
            
            int horas = int.TryParse(Console.ReadLine(), out int h) ? h : 0;

            if (horas <= 0)
            {
                Console.WriteLine("Ingrese un valor mayor a cero!");
                return; // Salir del programa si ingresa un valor negativo
            }

            int totalPagar = 20; 

            if (horas > 1)
            {
                totalPagar = 20 + ((horas - 1) * 10);
            }
            if (totalPagar > 100)
            {
                totalPagar = 100;
            }

            Console.WriteLine($"\nEl total a pagar es: L {totalPagar}");
        }
    }
}