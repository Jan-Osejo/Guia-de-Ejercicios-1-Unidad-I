namespace Guía1.Lists
{
    public class Ejercicio46
    {
        public void Ejecutar()
        {
            List<string> inventario = new List<string>();
            int selección = 0;

            while (selección != 5)
            {
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Buscar producto");
                Console.WriteLine("4. Mostrar lista ordenada");
                Console.WriteLine("5. Salir");
                Console.Write("Elija una opción: ");

                selección = int.TryParse(Console.ReadLine(), out int s) ? s : 0;

                switch (selección)
                {
                    case 1:
                        Console.Write("\nIngrese el producto a agregar: ");
                        string articuloNuevo = (Console.ReadLine() ?? "").Trim().ToLower();

                        if (articuloNuevo == "")
                        {
                            Console.WriteLine("\nNo puede estar vacío.");
                        }
                        else if (inventario.Contains(articuloNuevo))
                        {
                            Console.WriteLine("\nProducto ya existe en la lista.");
                        }
                        else
                        {
                            inventario.Add(articuloNuevo);
                            Console.WriteLine("\nProducto agregado exitosamente.");
                        }
                        break;

                    case 2:
                        Console.Write("\nIngrese el producto que desea eliminar: ");
                        string articuloBorrar = (Console.ReadLine() ?? "").Trim().ToLower();

                        if (inventario.Contains(articuloBorrar))
                        {
                            inventario.Remove(articuloBorrar);
                            Console.WriteLine("\nProducto eliminado de la lista.");
                        }
                        else
                        {
                            Console.WriteLine("\nEl producto no existe en el registro.");
                        }
                        break;

                    case 3:
                        Console.Write("\nIngrese el producto a buscar: ");
                        string articuloBuscar = (Console.ReadLine() ?? "").Trim().ToLower();

                        if (inventario.Contains(articuloBuscar))
                        {
                            Console.WriteLine($"\nEl producto '{articuloBuscar}' se encuentra en la lista.");
                        }
                        else
                        {
                            Console.WriteLine($"\nEl producto '{articuloBuscar}' no fue encontrado.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\n--- Lista de Compras ---");
                        if (inventario.Count == 0)
                        {
                            Console.WriteLine("La lista está vacía.");
                        }
                        else
                        {
                            inventario.Sort(); 
                            Console.WriteLine($"Total de artículos guardados: {inventario.Count}\n");

                            foreach (string articulo in inventario)
                            {
                                Console.WriteLine($"- {articulo}");
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("\nSaliendo del programa.");
                        break;

                    default:
                        Console.WriteLine("\nIntente de nuevo.");
                        break;
                }

                if (selección != 5)
                {
                }
            }
        }
    }
}