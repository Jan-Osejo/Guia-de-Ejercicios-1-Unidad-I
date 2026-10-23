namespace Guía1.Lists
{
    public class Ejercicio48
    {
        public void Ejecutar()
        {
            Console.Write("Números a evaluar: ");
            int totalNúmeros = int.TryParse(Console.ReadLine(), out int c) ? c : 0;

            while (totalNúmeros < 1)
            {
                Console.Write(" Numero invalido ");
                totalNúmeros = int.TryParse(Console.ReadLine(), out c) ? c : 0;
            }

            List<int> númerosÚnicos = new List<int>();
            int totalDescartados = 0;

            for (int i = 1; i <= totalNúmeros; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                int valorIngresado = int.TryParse(Console.ReadLine(), out int n) ? n : 0;

                if (númerosÚnicos.Contains(valorIngresado))
                {
                    totalDescartados++;
                    Console.WriteLine("Número repetido, ha sido descartado.");
                }
                else
                {
                    númerosÚnicos.Add(valorIngresado);
                }
            }

            Console.WriteLine($"Total de duplicados descartados: {totalDescartados}");
            Console.Write("Lista de números únicos: [ ");
            
            for (int i = 0; i < númerosÚnicos.Count; i++)
            {
                Console.Write(númerosÚnicos[i] + (i < númerosÚnicos.Count - 1 ? ", " : ""));
            }
            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}