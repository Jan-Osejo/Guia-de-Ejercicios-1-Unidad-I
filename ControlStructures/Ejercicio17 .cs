namespace Guía1.ControlStructures
{
    public class Ejercicio17 
    {
        public void CalcularDescuento()
        {
            Console.Write("Monto de la compra: ");
            double monto = double.TryParse(Console.ReadLine(), out double m) ? m : 0;

            if (monto < 0)
            {
                Console.WriteLine("Ingrese un monto positivo!");
                return; // Sale del programa si ingresa un monto negativo
            }

            double descuento = 0;

            if (monto >= 2500)
            {
                descuento = monto * 0.15;
            }
            else if (monto >= 1000)
            {
                descuento = monto * 0.10;
            }
            else if (monto >= 500)
            {
                descuento = monto * 0.05;
            }

            // Resultados  
            Console.WriteLine($"\nMonto original: L {monto}");
            Console.WriteLine($"Descuento: L {descuento}");
            Console.WriteLine($"Monto final: L {monto - descuento}");
        }
    }
}