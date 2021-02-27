using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Title = "Asteriscos";
                int numero, i = 1;
                Console.WriteLine("Digite un número entre 1-15");
                numero = int.Parse(Console.ReadLine());

                if (numero > 15)
                {
                    Console.WriteLine("El número está fuera de rango");
                }
                else
                {
                    while (i <= numero)
                    {
                        if (i % 2 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.WriteLine($"\n {i}. *");
                        i++;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Tipo de dato no válido");
            }
            Console.ReadKey();
        }
    }
}
