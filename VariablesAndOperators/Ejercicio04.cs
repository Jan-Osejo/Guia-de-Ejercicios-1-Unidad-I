namespace Guía1.VariablesAndOperators
{
    public class Ejercicio04
    {
        public void MenuGeometría()
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Triángulo");
                Console.WriteLine("3. Rectángulo");
                Console.WriteLine("4. Trapecio");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                
                string opción = Console.ReadLine() ?? "";

                    switch (opción)
                    {
                        case "1":
                        CalcularCirculo();
                        break;
                    case "2":
                        CalcularTriangulo();
                        break;
                    case "3":
                        CalcularRectángulo();
                        break;
                    case "4":
                        CalcularTrapecio();
                        break;
                    case "5":
                        salir = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        public double LeerPositivo(string mensaje)
        {
            double valor;
            while (true)
            {
                Console.Write(mensaje);
                if (double.TryParse(Console.ReadLine(), out valor) && valor > 0)
                {
                    return valor; 
                }
                Console.WriteLine("Por favor ingrese un número válido mayor a cero");
            }
        }

        public void CalcularCirculo()
        {
            double radio = LeerPositivo("Ingrese el radio: ");
            
            double area = Math.PI * Math.Pow(radio, 2); 
            double perímetro = 2 * Math.PI * radio;

            MostrarResultados(area, perímetro);
        }

        public void CalcularTriangulo()
        {
            double base1 = LeerPositivo("Ingrese la base: ");
            double altura = LeerPositivo("Ingrese la altura: ");
            double lado1 = LeerPositivo("Ingrese el L1: : ");
            double lado2 = LeerPositivo("Ingrese el L2: ");

            double area = (base1 * altura) / 2;
            double perímetro = base1 + lado1 + lado2;

            MostrarResultados(area, perímetro);
        }

        public void CalcularRectángulo()
        {
            double base2 = LeerPositivo("Ingrese la base: ");
            double altura = LeerPositivo("Ingrese la altura: ");

            double area = base2 * altura;
            double perímetro = 2 * (base2 + altura);

            MostrarResultados(area, perímetro);
        }

        public void CalcularTrapecio()
        {
            double baseMayor = LeerPositivo("Ingrese la base mayor: ");
            double baseMenor = LeerPositivo("Ingrese la base menor: ");
            double altura = LeerPositivo("Ingrese la altura: ");
            double l1 = LeerPositivo("Ingrese el L2 izquierdo: ");
            double l2 = LeerPositivo("Ingrese el L2 derecho: ");

            double area = ((baseMayor + baseMenor) * altura) / 2;
            double perímetro = baseMayor + baseMenor + l1 + l2;

            MostrarResultados(area, perímetro);
        }
        public void MostrarResultados(double area, double perímetro)
        {
            Console.WriteLine($"\nÁrea: {area:F2}");
            Console.WriteLine($"Perímetro: {perímetro:F2}");
        }
    }
}