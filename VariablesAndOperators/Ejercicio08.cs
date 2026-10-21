namespace Guía1.VariablesAndOperators
{
    public class Ejercicio08
    {
        public void DesglosarBilletes()
        {   
            // Ingresamos el monto
            Console.Write("Ingrese el monto en lempiras: ");
            int monto = int.TryParse(Console.ReadLine(), out int nro) ? nro : 0;

            // Evaluamos la entrada
            if (monto > 0)
            {
                // L.500.00
                int L500 = monto / 500;
                monto = monto % 500; 

                // L.100.00
                int L100 = monto / 100;
                monto = monto % 100;

                // l.50.00
                int L50 = monto / 50;
                monto = monto % 50;

                // l.20.00
                int L20 = monto / 20;
                monto = monto % 20;

                // l.10.00
                int L10 = monto / 10;
                monto = monto % 10;

                // l.5.00
                int L5 = monto / 5;
                monto = monto % 5;

                // L.2.00
                int L2 = monto / 2;
                monto = monto % 2;

                // L.1.00
                int L1 = monto;

                // Resultados
                if (L500 > 0) Console.WriteLine($"Billetes de 500: {L500}");
                if (L100 > 0) Console.WriteLine($"Billetes de 100: {L100}");
                if (L50 > 0) Console.WriteLine($"Billetes de 50: {L50}");
                if (L20 > 0) Console.WriteLine($"Billetes de 20: {L20}");
                if (L10 > 0) Console.WriteLine($"Billetes de 10: {L10}");
                if (L5 > 0) Console.WriteLine($"Billetes de 5: {L5}");
                if (L2 > 0) Console.WriteLine($"Billetes de 2: {L2}");
                if (L1 > 0) Console.WriteLine($"Billetes de 1: {L1}");
            }
            else
            {
            Console.WriteLine("Error: Por favor, ingrese un monto válido mayor a 0.");
            }
        }
    }
}