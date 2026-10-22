namespace Guía1.ControlStructures
{
    public class Ejercicio22
    {
        public void SimularCajero()
        {
            int saldo = 5000; // Saldo disponible en el cajero

            Console.Write("Ingrese el monto a retirar que sea múltiplo de 20: ");
            int monto = int.TryParse(Console.ReadLine(), out int m) ? m : 0;

            // Validaciones
            if (monto <= 0)
            {
                Console.WriteLine("Ingrese un monto positivo!");
                return;
            }
            if (monto > saldo)
            {
                Console.WriteLine("Fondos insuficientes!");
                return;
            }
            if (monto % 20 != 0)
            {
                Console.WriteLine("Escoja una cifra que sea múltiplo de 20!");
                return;
            }

            saldo = saldo - monto;

            int billetes500 = monto / 500;
            monto = monto % 500; 

            int billetes100 = monto / 100;
            monto = monto % 100;

            int billetes20 = monto / 20;

            // Desglose de los billetes y saldo restante
            Console.WriteLine($"\nBilletes de 500 entregados: {billetes500}");
            Console.WriteLine($"Billetes de 100 entregados: {billetes100}");
            Console.WriteLine($"Billetes de 20 entregados: {billetes20}");
            Console.WriteLine($"Saldo restante: L {saldo}");
        }
    }
}