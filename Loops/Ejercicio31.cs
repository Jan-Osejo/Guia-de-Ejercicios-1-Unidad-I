namespace Guía1.Loops
{
    public class Ejercicio31
    {
        public void MCDyMCM()
        {
            // Ingreso de datos
            Console.Write("Ingrese el #1: ");
            int num1 = int.TryParse(Console.ReadLine(), out int n1) ? n1 : 0;

            Console.Write("Ingrese el #2: ");
            int num2 = int.TryParse(Console.ReadLine(), out int n2) ? n2 : 0;

            // Validación
            if (num1 <= 0 || num2 <= 0)
            {
                Console.WriteLine("Ingrese números positivos!");
                return;
            }

            int a = num1;
            int b = num2;

            // Ciclo while requerido
            while (b != 0)
            {
                int residuo = a % b;
                a = b;
                b = residuo;
            }

            int mcd = a;

            int mcm = (num1 * num2) / mcd;

            Console.WriteLine($"\nMáximo Común Divisor (MCD) de {num1} y {num2} es: {mcd}");
            Console.WriteLine($"Mínimo Común Múltiplo (MCM) de {num1} y {num2} es: {mcm}");
        }
    }
}