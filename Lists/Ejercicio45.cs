namespace Guía1.Lists
{
    public class Ejercicio45
    {
        public void ListaTareas()
        {
            // Strings en una lista
            List<string> tareas = new List<string>();
            int opción = 0;

            while (opción != 5)
            {
                Console.WriteLine($"[ Tareas actuales: {tareas.Count} ]\n");
                Console.WriteLine("1. Agregar nueva tarea");
                Console.WriteLine("2. Mostrar todas las tareas");
                Console.WriteLine("3. Eliminar una tarea (por número)");
                Console.WriteLine("4. Mostrar total de tareas pendientes");
                Console.WriteLine("5. Salir");
                Console.Write("Elija una opción: ");

                opción = int.TryParse(Console.ReadLine(), out int op) ? op : 0;

                switch (opción)
                {
                    case 1:
                        Console.Write("\nIngrese la descripción de la nueva tarea: ");
                        string nuevaTarea = Console.ReadLine() ?? "";
                        
                        if (nuevaTarea.Trim() != "")
                        {
                            tareas.Add(nuevaTarea);
                            Console.WriteLine("\n Tarea agregada correctamente");
                        }
                        else
                        {
                            Console.WriteLine("\nLa tarea no puede estar vacía.");
                        }
                        break;

                    case 2:
                        if (tareas.Count == 0)
                        {
                            Console.WriteLine("No existen tareas pendientes");
                        }
                        else
                        {
                            for (int i = 0; i < tareas.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {tareas[i]}");
                            }
                        }
                        break;

                    case 3:
                        if (tareas.Count == 0)
                        {
                            Console.WriteLine("\nNo existen tareas para eliminar");
                        }
                        else
                        {
                            for (int i = 0; i < tareas.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {tareas[i]}");
                            }

                            Console.Write("\nNumero de la tarea a eliminar: ");
                            int numEliminar = int.TryParse(Console.ReadLine(), out int n) ? n : 0;

                            if (numEliminar >= 1 && numEliminar <= tareas.Count)
                            {
                                string tareaBorradas = tareas[numEliminar - 1]; 
                                
                                tareas.RemoveAt(numEliminar - 1); 
                                Console.WriteLine($"\n---> ¡La tarea '{tareaBorradas}' fue eliminada!");
                            }
                            else
                            {
                                Console.WriteLine("\nError: El número de tarea no existe.");
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine($"\n---> Tienes un total de {tareas.Count} tareas pendientes en este momento.");
                        break;

                    case 5:
                        Console.WriteLine("\nSaliendo del administrador de tareas...");
                        break;

                    default:
                        Console.WriteLine("\nOpción inválida. Intente de nuevo.");
                        break;
                }

                if (opción != 5)
                {
                    Console.WriteLine("\nPresione Enter para continuar...");
                    Console.ReadLine();
                }
            }
            Console.Clear();
        }
    }
}