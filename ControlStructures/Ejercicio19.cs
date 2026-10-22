namespace Guía1.ControlStructures
{
    public class Ejercicio19
    {
        public void ClasificarTriangulo()
        {
            Console.Write("Ingrese el lado A: ");
            double a = double.TryParse(Console.ReadLine(), out double n1) ? n1 : 0;
            
            Console.Write("Ingrese el lado B: ");
            double b = double.TryParse(Console.ReadLine(), out double n2) ? n2 : 0;
            
            Console.Write("Ingrese el lado C: ");
            double c = double.TryParse(Console.ReadLine(), out double n3) ? n3 : 0;

            // Validación de datos
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Error: Los lados deben ser mayores a cero.");
                return; 
            }
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Medidas incorrectas para el triángulo!");
                return;
            }
            // Clasificación por lados
            if (a == b && b == c)
            {
                Console.WriteLine("Lados: Es un triángulo Equilátero");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Lados: Es un triángulo Isósceles");
            }
            else
            {
                Console.WriteLine("Lados: Es un triángulo Escaleno");
            }

            // Clasificación ángulos
            double a2 = a * a;
            double b2 = b * b;
            double c2 = c * c;

            // Rectángulo: si los ángulos son iguales
            if (a2 == b2 + c2 || b2 == a2 + c2 || c2 == a2 + b2)
            {
                Console.WriteLine("Ángulos: Es Rectángulo");
            }
            // Obtusángulo: si los ángulos son mayores que el tercero
            else if (a2 > b2 + c2 || b2 > a2 + c2 || c2 > a2 + b2)
            {
                Console.WriteLine("Ángulos: Es Obtusángulo");
            }
            // Acutángulo: por descarte
            else
            {
                Console.WriteLine("Ángulos: Es Acutángulo");
            }
        }
    }
}