namespace Guía1.Loops
{
    public class Ejercicio36
    {
        public void CalculadoraConMenu()
        {
            // Datos de la calculadora
            Console.Write("Ingrese el valor inicial para empezar: ");
            double resultado = double.TryParse(Console.ReadLine(), out double vInicial) ? vInicial : 0;

            int opción = 0;

            while (opción != 9)
            {
                Console.WriteLine($"[ Resultado Actual: {resultado} ]");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raíz cuadrada");
                Console.WriteLine("7. Porcentaje");
                Console.WriteLine("8. Limpiar valor inicial");
                Console.WriteLine("9. Salir");
                Console.Write("Elija una operación: ");
                
                opción = int.TryParse(Console.ReadLine(), out int op) ? op : 0;

                // Evaluación de las opciones de la calculadora
                if (opción == 9)
                {
                    Console.WriteLine("Saliendo del programa");
                    break;
                }
                if (opción == 8)
                {
                    Console.Write("Ingrese el nuevo valor inicial: ");
                    resultado = double.TryParse(Console.ReadLine(), out double vNuevo) ? vNuevo : 0;
                    continue;
                }

                double numero2 = 0;
                if ((opción == 6) || (opción == 7))
                {
                    Console.Write("Ingrese el valor para la operación: ");
                    numero2 = double.TryParse(Console.ReadLine(), out double n2) ? n2 : 0;
                }

                // Se muestran los resultados de la opción seleccionada
                switch (opción)
                {
                    case 1:
                        resultado = resultado + numero2;
                        break;
                    case 2:
                        resultado = resultado - numero2;
                        break;
                    case 3:
                        resultado = resultado * numero2;
                        break;
                    case 4:
                        if (numero2 != 0)
                        {
                            resultado = resultado / numero2;
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir entre cero.");
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
                            Console.WriteLine("No existe raíz cuadrada para un número negativo");
                        }
                        break;
                    case 7:
                        resultado = resultado * (numero2 / 100.0);
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}