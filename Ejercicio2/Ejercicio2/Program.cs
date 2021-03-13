using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double r, angulo, x, y;

                Console.Title = "Solicitud de datos";

                Console.WriteLine("Ingresa el valor de 'r'");
                r = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el valor del angulo");
                angulo = double.Parse(Console.ReadLine());

                //Llamada a las funciones
                Console.Title = "Presentación de resultados";
                x = rectangularX(r, angulo);
                Console.WriteLine($"La componente rectangular X es: {x}");

                y = rectangularY(r, angulo);
                Console.WriteLine($"La componente rectangular Y es: {y}");
            }
            catch (FormatException)
            {
                Console.WriteLine("El dato ingresado no es válido");
            }

            Console.ReadKey();
        }
        static double rectangularX(double a, double b)
        {
            double componenteX;
            componenteX = Math.Round(a * Math.Cos(b),2);
            return componenteX;
        }
        static double rectangularY(double a, double b)
        {
            double componenteY;
            componenteY = Math.Round(a * Math.Sin(b),2);
            return componenteY;
        }
    }
}
