namespace Guía1.Loops
{
    public class Ejercicio23
    {
        public void MultiplicationTable()
        {
            Console.Write("Ingrese un número para ver su tabla: ");
            
            // Ingreso de datos
            int numero = int.TryParse(Console.ReadLine(), out int n) ? n : 0;

            Console.WriteLine($"\nTabla del {numero}: ");

           // ciclo for para imprimir la tabla
            for (int j = 1; j <= 12; j++)
            {
                Console.WriteLine($"{numero} x {j} = {numero * j}");
            }
        }
    }  
}