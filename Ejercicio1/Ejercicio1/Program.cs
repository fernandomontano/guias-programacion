using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Title = "Solicitud de datos";

                int nacimiento;
                Console.WriteLine("Digita el año en que naciste");
                nacimiento = Int32.Parse(Console.ReadLine());

                while (nacimiento > 2021)
                {
                    Console.WriteLine("El año de nacimiento no es válido");
                    Console.WriteLine("Digita el año en que naciste de nuevo");
                    nacimiento = Int32.Parse(Console.ReadLine());
                }

                Console.Title = "Presentación de resultados";
                Console.ForegroundColor = ConsoleColor.Yellow;
                edadPersona(nacimiento);
            }
            catch (FormatException)
            {
                Console.WriteLine("Dato ingresado no válido");
            }
            Console.ReadKey();
        }
        static void edadPersona(int personaNacimiento)
        {
            int edad;
            edad = 2021 - personaNacimiento;
            Console.WriteLine($"Naciste en el año {personaNacimiento}, entonces " +
            $"tienes o cumplirás {edad} año(s)");
        }
    }
}
