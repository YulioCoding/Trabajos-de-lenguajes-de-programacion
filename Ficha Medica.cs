using System;

class FichaMedica
{
    static void Main()
        {
            string nombre;
            int edad;
            double peso, estatura;
            DateTime fechaRegistro = DateTime.Now;
            
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            
            Console.Write("Edad: ");
            edad = int.Parse(Console.ReadLine());
            
            Console.Write("Peso (kg): ");
            peso = double.Parse(Console.ReadLine());
            
            Console.Write("Estatura (m): ");
            estatura = double.Parse(Console.ReadLine());
            
            Console.Write("¿Tiene seguro? (S/N): ");
            string tieneSeguro = Console.ReadLine();
            
            double imc = peso/(estatura * estatura);
            
            string clasificacion;
                if (imc < 18.5)
                    clasificacion = "(Peso bajo)";
                else if (imc <= 24.9)
                    clasificacion = "(Peso normal)";
                else
                    clasificacion = "(Sobrepeso)";
            
            Console.WriteLine("\n=============================================================");
            Console.WriteLine("\nFICHA MÉDICA DEL PACIENTE");
             Console.WriteLine("\n=============================================================");
            Console.WriteLine("Fecha: "+fechaRegistro);
            Console.WriteLine("Nombre: "+nombre);
            Console.WriteLine("Edad: "+edad);
            Console.WriteLine("IMC: "+imc+" - "+clasificacion);
            Console.WriteLine("Seguro: "+tieneSeguro);
            
        }
}        
