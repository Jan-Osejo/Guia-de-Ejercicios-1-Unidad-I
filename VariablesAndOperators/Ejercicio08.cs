namespace Guía1.VariablesAndOperators
{
    public class Ejercicio08
    {
        public void DesglosarBilletes()
        {   
            // Ingresamos el monto
            Console.Write("Ingrese el monto en lempiras: ");
            int monto = int.TryParse(Console.ReadLine(), out int nro) ? nro : 0;

            // Evaluamos las entradas
            if (monto > 0)
            {
                int L500 = monto / 500;
                monto = monto % 500;

                int L100 = monto / 100;
                monto = monto % 100;

                int L50 = monto / 50;
                monto = monto % 50;

                int L20 = monto / 20;
                monto = monto % 20;

                int L10 = monto / 10;
                monto = monto % 10;

                int L5 = monto / 5;
                monto = monto % 5;

                int L2 = monto / 2;
                monto = monto % 2;

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