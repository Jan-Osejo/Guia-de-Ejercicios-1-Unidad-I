namespace Guía1.Loops
{
    public class Ejercicio36
    {
        public void CalculadoraConMenu()
        {            
            Console.Write("Ingrese un valor inicial: ");
            double resultado = double.TryParse(Console.ReadLine(), out double vInicial) ? vInicial : 0;

            int opción = 0;

            while (opción != 9)
            {
                // Opciones de la calculadora
                Console.WriteLine($"\n\nEl valor actual es: {resultado}");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raíz cuadrada");
                Console.WriteLine("7. Porcentaje");
                Console.WriteLine("8. Cambiar valor inicial");
                Console.WriteLine("9. Salir");
                Console.Write("Elija una operación: ");
                
                opción = int.TryParse(Console.ReadLine(), out int op) ? op : 0;

                if (opción == 9)
                {
                    Console.WriteLine("Saliendo del programa.");
                    break;
                }

                if (opción == 8)
                {
                    Console.Write("Ingrese el nuevo valor inicial: ");
                    resultado = double.TryParse(Console.ReadLine(), out double vNuevo) ? vNuevo : 0;
                    
                    Console.WriteLine("\nValor inicial cambiado a: " + resultado);
                    continue;
                }

                double numero2 = 0;
                if ((opción >= 1 && opción <= 4) || (opción == 6))
                {
                    Console.Write("Ingrese el valor para la operación: ");
                    numero2 = double.TryParse(Console.ReadLine(), out double n2) ? n2 : 0;
                }

                bool operaciónExitosa = true;

                switch (opción)
                {
                    case 1:
                        resultado += numero2;
                        break;
                    case 2:
                        resultado -= numero2;
                        break;
                    case 3:
                        resultado *= numero2;
                        break;
                    case 4:
                        if (numero2 != 0)
                        {
                            resultado /= numero2;
                        }
                        else
                        {
                            Console.WriteLine("\nError: No se puede dividir entre cero.");
                            operaciónExitosa = false;
                        }
                        break;
                    case 5:
                        resultado = Math.Pow(resultado, numero2);
                        break;
                    case 6:
                        if (resultado >= 0)
                        {
                            resultado = Math.Sqrt(resultado);
                        }
                        else
                        {
                            Console.WriteLine("\nError: No se puede calcular la raíz de un número negativo.");
                            operaciónExitosa = false;
                        }
                        break;
                    case 7:
                        // Multiplica el resultado actual por el porcentaje solicitado
                        resultado = resultado * (numero2 / 100.0);
                        break;
                    default:
                        Console.WriteLine("\nOpción inválida. Intente de nuevo.");
                        operaciónExitosa = false;
                        break;
                }
                if (operaciónExitosa)
                {
                    Console.WriteLine($"\nEl nuevo valor es: {resultado}");
                }

                // Pausar y limpiar la terminal
                Console.WriteLine("\nContinuar");
                Console.ReadLine();
            }
        }
    }
}