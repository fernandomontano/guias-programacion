using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Impresion de 29 numeros";
            Console.WriteLine("Este programa imprimirá los numeros del 1 al 30 sin incluir el 25.");
            for (int i = 1; i <=30; i++)
            {
                if (i == 25)
                {
                    i++;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
