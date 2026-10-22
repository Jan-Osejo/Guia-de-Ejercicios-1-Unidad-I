namespace Guía1.Loops
{
    public class Ejercicio25
    {
        public void PromedioCentinela()
        {
            Console.WriteLine("Ingrese números / use -1 para finalizar /");
            
            // Datos a ingresar
            Console.Write("Ingrese un número: ");
            int numero = int.TryParse(Console.ReadLine(), out int n1) ? n1 : 0;

            // Fin de la ejecución si el número es -1
            if (numero == -1)
            {
                Console.WriteLine("Fin de ejecución");
                return;
            }

            int suma = 0;
            int cantidad = 0;
            
            int máximo = numero;
            int mínimo = numero;

            while (numero != -1)
            {
                suma = suma + numero;
                cantidad = cantidad + 1;

                if (numero > máximo)
                {
                    máximo = numero;
                }
                if (numero < mínimo)
                {
                    mínimo = numero;
                }

                Console.Write("Ingrese un número: ");
                numero = int.TryParse(Console.ReadLine(), out int n2) ? n2 : 0;
            }

            // Ultimo cálculo del promedio
            double promedio = (double)suma / (double)cantidad;

            Console.WriteLine($"Números ingresados: {cantidad}");
            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine($"El valor máximo: {máximo}");
            Console.WriteLine($"El valor mínimo: {mínimo}");
        }
    }
}