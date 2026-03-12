using System;

class RegistroVacunas
{
    static void Main()
    {
        // Variables
        string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
        int vacunas;
        int total = 0;
        double promedio;

        // Ciclo for
        for (int i = 0; i < 7; i++)
        {
            Console.Write("Vacunas aplicadas el " + dias[i] + ": ");
            vacunas = int.Parse(Console.ReadLine());
            total = total + vacunas;
        }

        // Calcular promedio
        promedio = total / 7.0;

        // Reporte final
        Console.WriteLine("\n====== REPORTE SEMANAL ======");
        Console.WriteLine("Total de vacunas:   " + total);
        Console.WriteLine("Promedio diario:    " + promedio);
        Console.WriteLine("=============================");
    }
}
