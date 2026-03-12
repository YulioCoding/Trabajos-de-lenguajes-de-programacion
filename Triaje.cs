using System;

class Triage
{
    static void Main()
        {
           double temperatura;
           int presion;
           
           Console.Write("Temperatura corporal (°C): ");
           temperatura = double.Parse(Console.ReadLine());
           
           Console.Write("Presión sistólica: ");
           presion = int.Parse(Console.ReadLine());
           
           string triaje;
           string recomendacion;
           
           if (temperatura > 39 || presion > 180)
           {
               triage = "ROJO (Crítico)";
               recomendacion = "Atención inmediata requerida";
           }
           else if (temperatura > 38 || presion > 140)
           {
               triage = "AMARILLO (Urgente)";
               recomendacion = "Pasar a consulta pronto";
           }
           else
           {
               triage = "VERDE (Estable)";
               recomendacion = "Puede esperar su turno";
           }
           Console.WriteLine("\nTemperatura: "+temperatura+ ">Presión: "+presion);
           Console.WriteLine("Triaje: "+triaje);
           Console.WriteLine("Recomendación: "+recomendacion);
        }
}      
