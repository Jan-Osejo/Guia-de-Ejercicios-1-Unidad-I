namespace Guía1.ControlStructures
{
    public class Ejercicio14
    {
        public void CalculadoraBásica()
        {
            // Ingreso de datos
            Console.Write("Ingrese el primer número: ");
            double num1 = double.TryParse(Console.ReadLine(), out double n1) ? n1 : 0;

            Console.Write("Ingrese el segundo número: ");
            double num2 = double.TryParse(Console.ReadLine(), out double n2) ? n2 : 0;

            Console.Write("Ingrese el operador (+, -, *, /): ");
            char operador = char.TryParse(Console.ReadLine(), out char op) ? op : ' ';

            Console.WriteLine("\n--- Resultados ---");
            double resultado = 0;

            // Evaluación 
            switch (operador)
            {
               case '+':
                    resultado = num1 + num2;
                    Console.WriteLine($"La suma es: {resultado}");
                    break;
                
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine($"La resta es: {resultado}");
                    break;
                
                case '*':
                    resultado = num1 * num2;
                    Console.WriteLine($"La multiplicación es: {resultado}");
                    break;
                
                case '/':
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"La división es: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero.");
                    }
                    break;
                
                default:
                    Console.WriteLine("Opción no válida");
                    break;
                }
        }
    }   
}
