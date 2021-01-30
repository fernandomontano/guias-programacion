using System;

namespace areaEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Título de consola
                Console.Title = "Area de un triángulo";

                //Descripción del programa
                Console.WriteLine("Este programa calculará el área de un triángulo dada su base y su altura.");

                //Declaración de variables
                double area, baseT, alturaT;

                //Solicitud de datos
                Console.WriteLine("Introduce el valor que tiene la base del triángulo");
                baseT = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduce el valor que tiene la altura del triángulo");
                alturaT = double.Parse(Console.ReadLine());

                //Creación de la fórmula
                area = (baseT * alturaT) / 2;

                //Impresión de resultados
                Console.WriteLine($"El área de un triángulo con base {baseT}cm y altura {alturaT}cm es: {area}cm^2 ");

                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("--Tipo de dato ingresado no válido--");
            }
        }
    }
}
