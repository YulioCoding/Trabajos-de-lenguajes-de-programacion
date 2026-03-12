using System;

class SistmaTurnos
{
    static void Main()
    {
        string continuar = "S";

        while (continuar == "S" || continuar == "s")
        {
            int turno = 0;
            while (turno <= 0)
            {
                Console.Write("> Ingrese número de turno: ");
                turno = int.Parse(Console.ReadLine());

                if (turno <= 0)
                    Console.WriteLine("Error: el turno debe ser mayor de 0");
            }

            Console.WriteLine("Turno " + turno + " registrado.");

            Console.Write("> ¿Desea continuar? (S/N): ");
            continuar = Console.ReadLine();
        }

        Console.WriteLine("\nSistema finaliado.");
    }
}
