using System;

class CalculadoraDosis
{
    static double CalcularDosis(double peso, double dosisPorKg)
    {
        return peso * dosisPorKg;
    }

    static void MostrarResultado(string nombre, double dosis)
    {
        Console.WriteLine("\n Paciente: " + nombre);
        Console.WriteLine("Dosis calculada: " + dosis + " mg");
    }

    static void Main()
    {
        Console.Write("> Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("> Peso (kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("> Dosis por kg: ");
        double dosisPorKg = double.Parse(Console.ReadLine());

        double dosis = CalcularDosis(peso, dosisPorKg);
        MostrarResultado(nombre, dosis);
    }
}
