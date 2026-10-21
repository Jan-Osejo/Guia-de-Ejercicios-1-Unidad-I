namespace Guía1.VariablesAndOperators
{
    public class Ejercicio10
    {
        public void CalcularPréstamo()
        {

            // Datos a ingresar
            Console.Write("Monto del préstamo en Lempiras: ");
            double monto = double.TryParse(Console.ReadLine(), out double nro1) ? nro1 : 0;

            Console.Write("Porcentaje de interés: ");  
            double tasa = double.TryParse(Console.ReadLine(), out double nro2) ? nro2 : 0;

            Console.Write("Plazo en meses: ");
            int meses = int.TryParse(Console.ReadLine(), out int nro3) ? nro3 : 0;

            // Evaluación de datos
            if (monto > 0 && tasa > 0 && meses > 0)
            {
                // Formula de interés
                double interés = monto * (tasa / 100) * (meses / 12.0);

                Console.WriteLine($"Interés total: L {interés:F2}");
                
                // Pago final
                Console.WriteLine($"Monto total a pagar: L {(monto + interés):F2}");
                Console.WriteLine($"Cuota mensual: L {((monto + interés) / meses):F2}");
            }
            else
            {
                Console.WriteLine("\nIngrese datos válidos.");
            }
                
        }
    }
}