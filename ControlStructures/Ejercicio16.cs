namespace Guía1.ControlStructures
{
    public class Ejercicio16
    {
        public void GradingSystem()
        {
            Console.Write("Ingrese una nota de 0 a 100: ");
            
            int nota = int.TryParse(Console.ReadLine(), out int n) ? n : 0;

            // Validaciones
            if (nota >= 0 && nota <= 100)
            {
                char letra;
                string descripción;

                // Evaluación de rangos con switch
                if (nota >= 90) 
                { 
                    letra = 'A'; 
                    descripción = "Excelente"; 
                }
                else if (nota >= 80) 
                { 
                    letra = 'B'; 
                    descripción = "Muy Bueno"; 
                }
                else if (nota >= 70) 
                { 
                    letra = 'C'; 
                    descripción = "Bueno"; 
                }
                else if (nota >= 60) 
                { 
                    letra = 'D'; 
                    descripción = "Suficiente"; 
                }
                else 
                { 
                    letra = 'F'; 
                    descripción = "Insuficiente"; 
                }

                // Operador ternario 
                string estado = (nota >= 65) ? "Aprobó" : "Reprobó";

                Console.WriteLine($"\nLetra: {letra}");
                Console.WriteLine($"Descripción: {descripción}");
                Console.WriteLine($"Estado: {estado}");
            }
            else
            {
                Console.WriteLine("\nIngrese una nota valida de 0 a 100!");
            }
        }
    }
}