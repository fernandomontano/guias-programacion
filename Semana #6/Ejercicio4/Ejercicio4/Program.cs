using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Title = "Solicitud de datos";
                double numero, suma = 0;
                int numeroNegativo = 0, numeroPositivo = 0, multiplos = 0;

                Console.WriteLine("A continuación, ingresarás 10 números");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"Ingrese el {i}° numero");
                    numero = double.Parse(Console.ReadLine());

                    if (numero > 0)
                    {
                        numeroPositivo++;
                    }
                    if (numero < 0)
                    {
                        numeroNegativo++;
                    }
                    if ((numero%15) == 0)
                    {
                        multiplos++;
                    }
                    if (numero % 2 == 0)
                    {
                        suma += numero;
                    }
                }
                Console.Title = "Presentación de resultados";

                Console.WriteLine("Resultados:");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine($"Hay {numeroPositivo} numeros positivos.\n" +
                        $"{numeroNegativo} numeros negativos.\n" +
                        $"{multiplos} multiplos de 15\n" +
                        $"La suma de los pares es {suma}");
            }
            catch (FormatException)
            {
                Console.WriteLine("El tipo de dato ingresado no es válido");
            }
            Console.ReadKey();
        }
    }
}

