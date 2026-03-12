using System;

class InventarioMedicamentos
{
   static void Main()
    {
        string[] nombres = new string [5];
        int[] cantidades = new int[5]; 
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nombre del medicamento " + (i+1)+": ");
            nombres[i] = Console.ReadLine();
            
            Console.Write("Cantidad disponible: ");
            cantidades[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("\n==============================================");
        Console.WriteLine("INVENTARIO DE MEDICAMENTOS");
        Console.WriteLine("\n==============================================");
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine((i+1)+". "+nombres[i]+ " - " +cantidades[i] + " unidades");
            Console.WriteLine("\n==============================================");
            
            int menorCantidad = cantidades[0];
            string menorNombre = nombres[0];
            
            for (int j = 0; j < 5; j++)
            {
                if (cantidades[i] < menorCantidad)
                {
                    menorCantidad = cantidades[i];
                    menorNombre = nombres[i];
                }
            }
            Console.WriteLine ("Menor stock: " + menorNombre + " (" + menorCantidad + ")");
        }
    }
}
