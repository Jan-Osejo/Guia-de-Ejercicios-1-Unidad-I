namespace Guía1.One_DimensionalArrays
{
    public class Ejercicio43
    {
        public void RotaciónArreglo()
        {
            // Arreglo de números
            Console.Write("Números que desea en el arreglo: ");
            int n = int.TryParse(Console.ReadLine(), out int cant) ? cant : 0;

            if (n <= 0)
            {
                Console.WriteLine("\nEl arreglo debe tener al menos 1 elemento.");
                return;
            }

            int[] arreglo = new int[n];

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write($"Ingrese el valor {i + 1}: ");
                arreglo[i] = int.TryParse(Console.ReadLine(), out int valor) ? valor : 0;
            }

            int opción = 0;

            while (opción != 4)
            {
                Console.Write("Valor actual:  ");
                for (int i = 0; i < arreglo.Length; i++)
                {
                    Console.Write(arreglo[i] + (i < arreglo.Length - 1 ? ", " : " "));
                }
                Console.WriteLine("]\n");

                Console.WriteLine("1. Rotar K posiciones a la IZQUIERDA");
                Console.WriteLine("2. Rotar K posiciones a la DERECHA");
                Console.WriteLine("3. Invertir el arreglo completo");
                Console.WriteLine("4. Salir");
                Console.Write("Elija una opción: ");
                
                opción = int.TryParse(Console.ReadLine(), out int op) ? op : 0;

                if (opción == 4)
                {
                    break;
                }

                int k = 0;
                
                switch (opción)
                {
                    case 1:
                        Console.Write("Posiciones a rotar a la IZQUIERDA: ");
                        k = int.TryParse(Console.ReadLine(), out int kIzq) ? kIzq : 0;
                        
                        k = k % arreglo.Length;
                        
                        for (int rotación = 0; rotación < k; rotación++)
                        {
                            int temp = arreglo[0];
                            for (int i = 0; i < arreglo.Length - 1; i++)
                            {
                                arreglo[i] = arreglo[i + 1];
                            }
                            arreglo[arreglo.Length - 1] = temp;
                        }
                        Console.WriteLine($"\nArreglo rotado {k} posiciones a la izquierda.");
                        break;

                    case 2:
                        Console.Write("Posiciones a rotar a la DERECHA: ");
                        k = int.TryParse(Console.ReadLine(), out int kDer) ? kDer : 0;
                        
                        k = k % arreglo.Length;
                        
                        for (int rotación = 0; rotación < k; rotación++)
                        {
                            int temp = arreglo[arreglo.Length - 1];
                            for (int i = arreglo.Length - 1; i > 0; i--)
                            {
                                arreglo[i] = arreglo[i - 1];
                            }
                            arreglo[0] = temp;
                        }
                        Console.WriteLine($"\nArreglo rotado {k} posiciones a la derecha.");
                        break;

                    case 3:
                        for (int i = 0; i < arreglo.Length / 2; i++)
                        {
                            int temp = arreglo[i];
                            arreglo[i] = arreglo[arreglo.Length - 1 - i];
                            arreglo[arreglo.Length - 1 - i] = temp;
                        }
                        Console.WriteLine("\nArreglo invertido correctamente.");
                        break;

                    default:
                        Console.WriteLine("\nOpción inválida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}