namespace Guía1.One_DimensionalArrays
{
    public class Ejercicio37
    {
        public void RegistroNúmeros()
        {            
            Console.Write("Valores a ingresar: ");
            int n = int.TryParse(Console.ReadLine(), out int cant) ? cant : 0;

            if (n <= 0)
            {
                Console.WriteLine("\nIngrese un valor mayor a cero.");
                Console.WriteLine("Fin del programa");
                Console.ReadLine();
                return; 
            }

            // Arreglo de números
            int[] números = new int[n];

            for (int i = 0; i < números.Length; i++)
            {
                Console.Write($"Ingrese el número para la posición {i + 1}: ");
                números[i] = int.TryParse(Console.ReadLine(), out int num) ? num : 0;
            }

            // Variables de almacenamiento
            int suma = 0;
            double promedio = 0.0;
            
            int mayor = números[0];
            int menor = números[0];

            for (int i = 0; i < números.Length; i++)
            {
                suma += números[i];
            }
            
            promedio = (double)suma / números.Length;

            foreach (int número in números)
            {
                if (número > mayor)
                {
                    mayor = número;
                }
                
                if (número < menor)
                {
                    menor = número;
                }
            }

            // Resultados 
            Console.WriteLine($"Suma total de los números: {suma}");
            Console.WriteLine($"Promedio de los números:   {promedio}");
            Console.WriteLine($"El valor MAYOR ingresado:  {mayor}");
            Console.WriteLine($"El valor MENOR ingresado:  {menor}");
        }
    }
}