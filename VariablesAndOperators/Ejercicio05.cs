namespace Guía1.VariablesAndOperators
{
    public class Ejercicio05
    {
        public void MenuTemperatura()
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("1. Celsius a Fahrenheit y Kelvin");
                Console.WriteLine("2. Fahrenheit a Celsius y Kelvin");
                Console.WriteLine("3. Kelvin a Celsius y Fahrenheit");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                
                string opción = Console.ReadLine() ?? "";

                if (opción == "4")
                {
                    salir = true;
                    Console.WriteLine("Saliendo del programa.");
                    continue;
                }

                // Se verifica que la opción sea válida
                if (opción == "1" || opción == "2" || opción == "3")
                {
                    Console.Write("Ingrese los grados a convertir: ");
                    double grados = double.TryParse(Console.ReadLine(), out double g) ? g : 0;

                    switch (opción)
                    {
                        case "1":
                            double CaF = (grados * 9 / 5) + 32;
                            double CaK = grados + 273.15;
                            Console.WriteLine($"{grados:F2} °C equivalen a: {CaF:F2} °F y {CaK:F2} K");
                            break;
                        case "2":
                            double FaC = (grados - 32) * 5 / 9;
                            double FaK = FaC + 273.15;
                            Console.WriteLine($"{grados:F2} °F equivalen a: {FaC:F2} °C y {FaK:F2} K");
                            break;
                        case "3":
                            double KaC = grados - 273.15;
                            double KaF = (KaC * 9 / 5) + 32;
                            Console.WriteLine($"{grados:F2} K equivalen a: {KaC:F2} °C y {KaF:F2} °F");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Opción no válida. Intente de nuevo.");
                }
            }
        }
    }
}