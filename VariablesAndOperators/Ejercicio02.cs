namespace Guía1.VariablesAndOperators
{
    public class Ejercicio02
    {
        public void ImcCalculator()
        {
            Console.WriteLine("Ingrese su peso en kilogramos: ");
            double peso = double.TryParse(Console.ReadLine(), out double Peso) ? Peso : 0;
            
            Console.WriteLine("Ingrese su altura en metros: ");
            double altura = double.TryParse(Console.ReadLine(), out double Altura) ? Altura : 0;

            if (peso <=  0 || altura <= 0)
            {
                Console.WriteLine("Por favor ingrese valores mayores a cero!");
                return;
            }

            double imc = peso / (altura * altura);

            string categoría = imc switch
            {
                <18.5 => "Bajo peso",
                <25.0 => "Bajo peso",
                <30.0 => "Bajo peso",
                _=> "Obesidad"
            };

            Console.WriteLine($"Su indice de masa corporal es: {imc:F2}");
            Console.WriteLine($"Categoría: {categoría}");

        }
    }
}