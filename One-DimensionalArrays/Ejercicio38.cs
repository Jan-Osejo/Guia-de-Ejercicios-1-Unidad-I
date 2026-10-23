namespace Guía1.One_DimensionalArrays
{
    public class Ejercicio38
    {
        public void ArregloDeNombres()
        {
            // Creación de un arreglo de nombres
            string[] nombres = new string[5];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($"Ingrese un nombre {i + 1}: ");
                nombres[i] = Console.ReadLine() ?? ""; 
            }

            for (int i = nombres.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{i + 1}. {nombres[i]}");
            }

            string nombreMasLargo = nombres[0]; 
            
            foreach (string nombre in nombres)
            {
                if (nombre.Length > nombreMasLargo.Length)
                {
                    nombreMasLargo = nombre;
                }
            }
            Console.WriteLine($"\nNombre más largo: {nombreMasLargo}");

            Console.Write("Nombre a buscar: ");
            string buscar = Console.ReadLine() ?? "";
            
            bool encontrado = false; 

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i].ToLower() == buscar.ToLower())
                {
                    Console.WriteLine($"¡Éxito! El nombre '{nombres[i]}' fue encontrado en la posición {i + 1}.");
                    encontrado = true;
                    break; 
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine($"El nombre '{buscar}' no fue encontrado.");
            }
        }
    }
}