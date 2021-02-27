using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double numeroUno, numeroDos, i;

                Console.WriteLine("Ingresa el número uno");
                numeroUno = double.Parse(Console.ReadLine());

                while (numeroUno < 0)
                {
                    Console.WriteLine("Digita un valor mayor para el primer número");
                    numeroUno = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ingresa el número dos");
                numeroDos = double.Parse(Console.ReadLine());

                while (numeroDos < 0 || numeroDos <= numeroUno)
                {
                    Console.WriteLine("Digita un valor mayor para el segundo número");
                    numeroDos = double.Parse(Console.ReadLine());
                }


                Console.WriteLine("Los pares del primer número al segundo son");
                Console.ForegroundColor = ConsoleColor.Yellow;
                for(i=numeroUno+1; i<numeroDos;i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"{i}");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Tipo de dato ingresado no válido");
            }
            Console.ReadLine();
        }
    }
}
