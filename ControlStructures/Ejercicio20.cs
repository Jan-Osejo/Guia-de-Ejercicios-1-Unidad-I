namespace Guía1.ControlStructures
{
    public class Ejercicio20
    {
        public void ComprobarAñoBisiesto()
        {

            // Ingreso de datos
            Console.Write("Ingrese un año: ");
            int año = int.TryParse(Console.ReadLine(), out int nro) ? nro : 0;

            // Evaluación
            if (año > 0)
            {
                // Formula para años bisiestos
                if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                {
                    Console.WriteLine($"El año {año} es bisiesto");
                }
                else
                {
                    Console.WriteLine($"El año {año} no es bisiesto");
                }
            }
            else
            {
                Console.WriteLine("Ingrese un número válido.");
            }
        }
    }
}