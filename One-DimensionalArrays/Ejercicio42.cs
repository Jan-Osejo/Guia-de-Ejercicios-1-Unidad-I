namespace Guía1.One_DimensionalArrays
{
    public class Ejercicio42
    {
        public void BúsquedaYOrdenamiento()
        {
            // Arreglo de números
            int[] números = new int[10];

            for (int i = 0; i < números.Length; i++)
            {
                Console.Write($"Ingrese el número {i + 1} de 10: ");
                números[i] = int.TryParse(Console.ReadLine(), out int n) ? n : 0;
            }

            Console.Write("Numero que desea buscar: ");
            int buscar = int.TryParse(Console.ReadLine(), out int b) ? b : 0;
            
            bool encontrado = false;
            for (int i = 0; i < números.Length; i++)
            {
                if (números[i] == buscar)
                {
                    Console.WriteLine($"¡Número encontrado en la posición {i + 1}!");
                    encontrado = true;
                    break; 
                }
            }
            if (!encontrado) Console.WriteLine("El número no se encuentra en el arreglo.");

            int mayor = int.MinValue;  
            int segundoMayor = int.MinValue;

            foreach (int num in números)
            {
                if (num > mayor)
                {
                    segundoMayor = mayor;
                    mayor = num;
                }
                else if (num > segundoMayor && num < mayor)
                {
                    segundoMayor = num;
                }
            }
            
            Console.WriteLine($"Número mayor: {mayor}");
            if (segundoMayor != int.MinValue)
            {
                Console.WriteLine($"Segundo mayor: {segundoMayor}");
            }
            else
            {
                Console.WriteLine("No existe un segundo mayor.");
            }

            for (int i = 0; i < números.Length; i += 2)
            {
                Console.WriteLine($"Índice {i} (Posición visual {i + 1}): {números[i]}");
            }

            
            for (int i = 0; i < números.Length - 1; i++)
            {
                for (int j = 0; j < números.Length - i - 1; j++)
                {
                    if (números[j] > números[j + 1])
                    {
                        // Intercambio de variables usando una variable temporal
                        int temp = números[j];
                        números[j] = números[j + 1];
                        números[j + 1] = temp;
                    }
                }
            }

            // MArreglo ya ordenado
            Console.WriteLine("Arreglo ordenado de forma ascendente:");
            for (int i = 0; i < números.Length; i++)
            {
                Console.Write(números[i] + " ");
            }
            Console.WriteLine(); 
        }
    }
}