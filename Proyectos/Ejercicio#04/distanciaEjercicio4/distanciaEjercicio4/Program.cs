using System;

namespace distanciaEjercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Título de la consola
                Console.Title = "Distancia entre 2 puntos";

                //Descripción del programa
                Console.WriteLine("Este programa calculará la distancia entre 2 puntos");

                //Declaración de variables
                double x1, x2, y1, y2, formula, restaX, restaY;

                //Pedida de datos
                Console.WriteLine("Introduzca el valor de 'X1'");
                x1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduzca el valor de 'Y1'");
                y1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduzca el valor de 'X2'");
                x2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduzca el valor de 'Y2'");
                y2 = double.Parse(Console.ReadLine());

                restaX = x2 - x1;
                restaY = y2 - y1;

                //Creación de la fórmula
                formula = Math.Pow(restaX, 2) + Math.Pow(restaY, 2);

                //Impresion de resultado
                Console.WriteLine($"La distancia entre el punto ({x1},{y1}) y ({x2},{y2}) es: {formula}");

                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("--Tipo de dato ingresado no válido--");
            }
        }
    }
}
