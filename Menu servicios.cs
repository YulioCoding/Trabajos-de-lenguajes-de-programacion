using System;

class MenuClinica
{
    static void Main()
        {
           Console.WriteLine("=========================================================");
           Console.WriteLine ("\nMENÚ DE SERVICIOS");
           Console.WriteLine("\n=========================================================");
           Console.WriteLine("1. Consulta General - $50.000");
           Console.WriteLine("2. Laboratorio - $80.000");
           Console.WriteLine("3. Rayos X - $120.000");
           Console.WriteLine("4. Farmacia - $30.000");
           Console.WriteLine("5. Salir");
           
           Console.Write("Seleccione una opción: ");
           int opcion = int.Parse(Console.ReadLine());
           
           switch(opcion)
            {
              case 1:
                Console.WriteLine("\nServicio: Consulta General");
                Console.WriteLine("Precio: $50.000");
                Console.WriteLine("Tiempo de espera: 20 minutos");
                break;
            case 2:
                Console.WriteLine("\nServicio: Laboratorio");
                Console.WriteLine("Precio: $80.000");
                Console.WriteLine("Tiempo de espera: 30 minutos");
                break;
            case 3:
                Console.WriteLine("\nServicio: Rayos X");
                Console.WriteLine("Precio: $120.000");
                Console.WriteLine("Tiempo de espera: 45 minutos");
                break;
            case 4:
                Console.WriteLine("\nServicio: Farmacia");
                Console.WriteLine("Precio: $30.000");
                Console.WriteLine("Tiempo de espera: 10 minutos");
                break;
            case 5:
                Console.WriteLine("\nHasta luego.");
                break;
            default:
                Console.WriteLine("\nOpción inválida.");
                break;   
            }
        }
}       
