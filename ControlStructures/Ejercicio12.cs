namespace Guía1.ControlStructures
{
    public class Ejercicio12
    {
        public void MayorYMenor()
        {
            // Ingreso de datos
            Console.Write("Primer número: ");
            int num1 = int.TryParse(Console.ReadLine(), out int n1) ? n1 : 0;

            Console.Write("Segundo número: ");
            int num2 = int.TryParse(Console.ReadLine(), out int n2) ? n2 : 0;

            Console.Write("Tercer número: ");
            int num3 = int.TryParse(Console.ReadLine(), out int n3) ? n3 : 0;

            // Evaluar usando &&
            int mayor = 0;
            int menor = 0;

            // Sacar el # mayor
            if (num1 >= num2 && num1 >= num3)
            {
                mayor = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                mayor = num2;
            }
            else
            {
                mayor = num3;
            }

            // Sacar el # menor
            if (num1 <= num2 && num1 <= num3)
            {
                menor = num1;
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                menor = num2;
            }
            else
            {
                menor = num3;
            }

            Console.WriteLine($"El número mayor es: {mayor}");
            Console.WriteLine($"El número menor es: {menor}");
        }
    }
}