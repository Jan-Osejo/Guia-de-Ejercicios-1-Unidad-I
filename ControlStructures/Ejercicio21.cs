namespace Guía1.ControlStructures
{
    public class Ejercicio21
    {
        public void ValidarFecha()
        {
            Console.Write("Ingrese el día: ");
            int dia = int.TryParse(Console.ReadLine(), out int d) ? d : 0;

            Console.Write("Ingrese el mes: ");
            int mes = int.TryParse(Console.ReadLine(), out int m) ? m : 0;

            Console.Write("Ingrese el año: ");
            int año = int.TryParse(Console.ReadLine(), out int a) ? a : 0;

            // Validamos los datos
            if (año <= 0)
            {
                Console.WriteLine("Año no válido!");
                return;
            }

            if (mes < 1 || mes > 12)
            {
                Console.WriteLine("Ingrese un mes válido!");
                return;
            }

            int díasDelMes = 0;

            // Evaluación de los meses
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                díasDelMes = 31;
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                díasDelMes = 30;
            }
            else if (mes == 2)
            {
                if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                {
                    díasDelMes = 29;
                }
                else
                {
                    díasDelMes = 28;
                }
            }
            if (dia < 1 || dia > díasDelMes)
            {
                Console.WriteLine($"El mes {mes} solo tiene {díasDelMes} días en el año {año}. No es valido!");
                return;
            }
            Console.WriteLine($"\nLa fecha {dia}/{mes}/{año} es real");
        }
    }
}