using System;

namespace conversionEjercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Título de consola
                Console.Title = "Conversion de km a unidades";

                //Descripción del programa
                Console.WriteLine("Este programa convertirá cierta cantidad de kilómetros en distintas unidades de medida.");

                //Declaración de variables
                double kilometros, metros, yardas, varas;

                //Solicitud de datos
                Console.WriteLine("Introduce la cantidad de kilómetros que deseas convertir.");
                kilometros = double.Parse(Console.ReadLine());

                //Expresar las quivalencias
                metros = kilometros * 1000;
                yardas = metros * 1.09361;
                varas = metros * 1.1963;

                //Mostrar resultados
                Console.WriteLine($"La cantidad de {kilometros}km convertido:");
                Console.WriteLine($"1. A metros: {metros} metros");
                Console.WriteLine($"2. A yardas: {yardas} yardas");
                Console.WriteLine($"3. A varas: {varas} varas");

                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("--Tipo de dato ingresado no válido--");
            }
        }
    }
}
