namespace Guía1.ControlStructures
{
    public class Ejercicio11
    {
        public void EvaluarNumero()
        {
            // Ingreso de datos 
            Console.Write("Ingrese un número entero: ");
            int numero = int.TryParse(Console.ReadLine(), out int nro) ? nro : 0;
            
            // Evaluaciones
            if (numero > 0)
            {
                Console.WriteLine("El número ingresado es POSITIVO.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número ingresado es NEGATIVO.");
            }
            else
            {
                Console.WriteLine("El número ingresado es CERO.");
            }

            // Operador ternario
            Console.WriteLine($"Además, el número es {(numero % 2 == 0 ? "PAR" : "IMPAR")}.");
        }
    }
}