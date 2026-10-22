namespace Guía1.ControlStructures
{
    public class Ejercicio15
    {
        public void VocalOConsonante()
        {
            Console.WriteLine("Ingrese una letra: ");
            
            char letra = char.TryParse(Console.ReadLine(), out char c) ? c : ' ';

            if (!char.IsLetter(letra))
            {
                Console.WriteLine("Ingrese una letra válida");
                return; // Interrumpe la ejecución del programa
            }

            char letraMinúscula = char.ToLower(letra);

            // Evaluación con switch
            switch(letraMinúscula)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine($"La letra {letra} es una vocal");
                    break;
                default:
                    Console.WriteLine($"La letra {letra} es una consonante");
                    break;
            }
        }
    }
}