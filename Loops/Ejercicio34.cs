namespace Guía1.Loops
{
    public class Ejercicio34
    {
        public void ValidarContraseña()
        {
            bool valida = false;

            while (valida == false)
            {
                // Ingreso de datos
                Console.Write("\nIngrese una contraseña: ");
                string pass = Console.ReadLine() ?? "";

                int mayus = 0, minus = 0, nums = 0, esp = 0;

                for (int i = 0; i < pass.Length; i++)
                {
                    char letra = pass[i];

                    if (char.IsUpper(letra)) mayus = mayus + 1;
                    else if (char.IsLower(letra)) minus = minus + 1;
                    else if (char.IsDigit(letra)) nums = nums + 1;
                    else esp = esp + 1;
                }

                // Evaluación de la contraseña
                if (pass.Length >= 8 && mayus > 0 && minus > 0 && nums > 0 && esp > 0)
                {
                    Console.WriteLine("Seleccione una contraseña válida!");
                    valida = true; // Se acaba el ciclo while y se muestra si le falta algo a la contraseña
                }
                else
                {
                    Console.WriteLine("La contraseña no es válida, agregue lo siguiente:");
                    
                    if (pass.Length < 8) Console.WriteLine("- Mínimo 8 caracteres");
                    if (mayus == 0) Console.WriteLine("- Al menos una mayúscula");
                    if (minus == 0) Console.WriteLine("- Al menos una minúscula");
                    if (nums == 0) Console.WriteLine("- Al menos un número");
                    if (esp == 0) Console.WriteLine("- Al menos un carácter especial");
                }
            }
        }
    }
}