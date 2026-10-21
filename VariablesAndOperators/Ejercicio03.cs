namespace Guía_1.VariablesAndOperators
{
    public class Ejercicio03
    {
        public void ExchangeOfValues()
        {
            int a = 15;
            int b = 30;

            Console.WriteLine($"Antes: a = {a}, b = {b}");

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Después: a = {a}, b = {b}");
        }

        public void AdditionalExchangeOfValues()
        //Reto extra
        {
            int x = 100;
            int y = 200;

            Console.WriteLine($"Antes: x = {100}, y = {200}");

            x = x - y;
            y = x - y; 
            x = x - y;

            Console.WriteLine($"Después: x = {x}, y = {y}");
        }
    }
}