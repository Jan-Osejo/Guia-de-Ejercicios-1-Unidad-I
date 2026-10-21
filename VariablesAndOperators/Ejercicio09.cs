namespace Guía1.VariablesAndOperators
{
    public class Ejercicio09
    {
        public void CalcularSalarioSemanal()
        {
            // Ingreso de datos: Horas y tarifa
            Console.Write("Ingrese las horas trabajadas en la semana: ");
            double horas = double.TryParse(Console.ReadLine(), out double nro1) ? nro1 : 0;

            Console.Write("Ingrese la tarifa por hora en lempiras: ");
            double tarifa = double.TryParse(Console.ReadLine(), out double nro2) ? nro2 : 0;

            // Evaluamos la entrada
            if (horas > 0 && tarifa > 0)
            {
                double salarioNormal = 0;
                double salarioExtra = 0;

                if (horas <= 44)
                {
                    salarioNormal = horas * tarifa;
                }
                else
                {   // Si es mayor a 44 horas se aplica tarifa del 150% y se paga por las horas extras
                    salarioNormal = 44 * tarifa;
                    
                    double horasExtras = horas - 44;
                    salarioExtra = horasExtras * (tarifa * 1.5);
                }

                double salarioTotal = salarioNormal + salarioExtra;

                Console.WriteLine($"Salario base: L {salarioNormal:F2}");
                Console.WriteLine($"Pago por horas extras: L {salarioExtra:F2}");
                Console.WriteLine($"Salario total a pagar: L {salarioTotal:F2}");
            }
            else
            {
                Console.WriteLine("\nIngrese datos válidos.");
            }
        }
    }
}