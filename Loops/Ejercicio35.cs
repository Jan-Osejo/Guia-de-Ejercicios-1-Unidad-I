namespace Guía1.Loops
{
    public class Ejercicio35
    {
        public void MenuPatrones()
        {
            Console.WriteLine("1. Triángulo");
            Console.WriteLine("2. Triángulo invertido");
            Console.WriteLine("3. Rombo");
            Console.WriteLine("4. Cuadrado hueco");
            Console.WriteLine("5. Pirámide numérica");
            
            Console.Write("\nElija una opción (1-5): ");
            int opción = int.TryParse(Console.ReadLine(), out int op) ? op : 0;

            // Validación de valores
            if (opción < 1 || opción > 5)
            {
                Console.WriteLine("Error: Opción inválida.");
                return;
            }

            Console.Write("Ingrese el tamaño (N): ");
            int n = int.TryParse(Console.ReadLine(), out int num) ? num : 0;

            if (n <= 0)
            {
                Console.WriteLine("Ingrese un valor mayor a cero");
                return;
            }

            Console.WriteLine(); // Despejamos la línea para que la figura

            // Evaluación de la opción elegida con un switch básico
            switch (opción)
            {
                case 1:
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:
                    for (int i = n; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    for (int i = 1; i <= n; i++)
                    {
                        for (int espacios = 1; espacios <= n - i; espacios++) Console.Write(" ");
                        for (int asteriscos = 1; asteriscos <= (2 * i - 1); asteriscos++) Console.Write("*");
                        Console.WriteLine();
                    }
                    for (int i = n - 1; i >= 1; i--)
                    {
                        for (int espacios = 1; espacios <= n - i; espacios++) Console.Write(" ");
                        for (int asteriscos = 1; asteriscos <= (2 * i - 1); asteriscos++) Console.Write("*");
                        Console.WriteLine();
                    }
                    break;

                case 4:
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            if (i == 1 || i == n || j == 1 || j == n)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                    break;

                case 5:
                    for (int i = 1; i <= n; i++)
                    {
                        for (int espacios = 1; espacios <= n - i; espacios++) Console.Write(" ");
                        
                        for (int numero = 1; numero <= i; numero++)
                        {
                            Console.Write($"{numero} ");
                        }
                        Console.WriteLine();
                    }
                    break;
            }
            
         
        }
    }
}