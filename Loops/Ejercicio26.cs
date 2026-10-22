namespace Guía1.Loops
{
    public class Ejercicio26
    {
        public void CalcularPotencia()
        {   
            // Datos a ingresar
            Console.Write("Ingrese el número base: ");
            double baseNum = double.TryParse(Console.ReadLine(), out double b) ? b : 0;

            Console.Write("Ingrese el exponente: ");
            int exponente = int.TryParse(Console.ReadLine(), out int e) ? e : 0;

            double resultado = 1; 
            int exponentePositivo = exponente;
            
            if (exponente < 0)
            {
                exponentePositivo = exponente * -1; 
            }

            int i = 1;
            while (i <= exponentePositivo)
            {
                resultado = resultado * baseNum;
                i++; // Incremento el exponente
            }

            if (exponente < 0)
            {
                if (baseNum == 0)
                {
                    Console.WriteLine("\nNo se puede elevar a la potencia negativa un número 0.");
                    return;
                }
                
                resultado = 1.0 / resultado;
            }

            Console.WriteLine($"\nResultado: {baseNum} elevado a la {exponente} es igual a {resultado}");
        }
    }
}