namespace Guía1.ControlStructures
{
    public class Ejercicio13
    {
        public void WeekDay()
        {
           //Ingreso de datos
            Console.Write("Ingrese un número del 1 al 7: ");
            int day = int.TryParse(Console.ReadLine(), out int nro) ? nro : 0;

            // Evaluación
            if (day >= 1 && day <= 7)
            {
                // Usando switch clásico 
                Console.Write("Switch clásico: ");
                switch (day)
                {
                    case 1: Console.WriteLine("Lunes"); break;
                    case 2: Console.WriteLine("Martes"); break;
                    case 3: Console.WriteLine("Miércoles"); break;
                    case 4: Console.WriteLine("Jueves"); break;
                    case 5: Console.WriteLine("Viernes"); break;
                    case 6: Console.WriteLine("Sábado"); break;
                    case 7: Console.WriteLine("Domingo"); break;
                }

                // Usando expresión switch
                string NumbersDay = day switch
                {
                    1 => "Lunes",
                    2 => "Martes",
                    3 => "Miércoles",
                    4 => "Jueves",
                    5 => "Viernes",
                    6 => "Sábado",
                    7 => "Domingo",
                    _ => "Error" 
                };

                Console.WriteLine($"Expresión switch: {NumbersDay}");
            }
            else
            {
                Console.WriteLine("Ingrese un número del 1 al 7.");
            }       
        }
    }
}