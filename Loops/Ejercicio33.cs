namespace Guía1.Loops
{
    public class Ejercicio33
    {
        public void JuegoAdivinanza()
        {
            Console.WriteLine("El usuario tiene 7 intentos para adivinar el numero oculto entre 1 y 100.");

            Random random = new Random();
            int numeroOculto = random.Next(1, 101);

            int IntentoUsuario = 0;
            int IntentosUsados = 0;
            int IntentosLimite = 7;

            while (IntentosUsados < IntentosLimite && IntentoUsuario != numeroOculto)
            {
                Console.Write($"\nIntento {IntentosUsados + 1}: ");
                IntentoUsuario = int.TryParse(Console.ReadLine(), out int n) ? n : 0;

                // Validación para que el usuario ingrese un número válido
                if (IntentoUsuario <= 0 || IntentoUsuario > 100)
                {
                    Console.WriteLine("Ingrese un número entre 1 y 100!");
                }
                else
                {
                    // Se van sumando los intentos del usuario
                    IntentosUsados = IntentosUsados + 1;

                    if (IntentoUsuario < numeroOculto)
                    {
                        Console.WriteLine("Pista: El numero a encontrar es Mayor");
                    }
                    else if (IntentoUsuario > numeroOculto)
                    {
                        Console.WriteLine("Pista: El numero a encontrar es Menor");
                    }
                    else
                    {
                        Console.WriteLine("Numero oculto encontrado!");
                    }
                }
            }   

            if (IntentoUsuario == numeroOculto)
            {
                Console.WriteLine("Felicidades!");
            }
            else
            {
                Console.WriteLine("No se encontró el numero oculto :( ");
                Console.WriteLine($"Numero oculto: {numeroOculto}");
            }

            Console.WriteLine($"Intentos utilizados: {IntentosUsados} de {IntentosLimite}");
        }
    }
}