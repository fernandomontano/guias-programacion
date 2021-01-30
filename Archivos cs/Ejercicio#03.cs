using System;

namespace ecuacionEjercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Título de consola
                Console.Title = "Volumen de una esfera";

                //Descripción del proyecto
                Console.WriteLine("Este programa calculará el volumen de una esfera");

                //Declaración de variables
                double radio, volumen;

                //Solicitud de datos
                Console.WriteLine("Introduce el valor del radio:");
                radio = double.Parse(Console.ReadLine());

                //Aplicación de formula
                volumen = (4 * Math.PI * Math.Pow(radio, 3)) / 3;

                //Math.Round para cortar el resultado a 2 decimales
                double volumenDecimal = Math.Round(volumen, 2);

                //Impresión de resultados
                Console.WriteLine($"El volumen de una esfera con radio {radio}cm es: {volumenDecimal}cm^3");

                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("--Tipo de dato ingresado no válido--");
            }
        }
    }
}
