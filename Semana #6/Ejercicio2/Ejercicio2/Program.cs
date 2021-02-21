using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            try{

                int cantidadPares;
                double x = 0, y = 0;
                int cuadrante1 = 0, cuadrante2 = 0, cuadrante3 = 0, cuadrante4 = 0, origen = 0;

                Console.Title = ("Solicitud de datos");

                Console.WriteLine("Introduce la cantidad de pares ordenados");
                cantidadPares = int.Parse(Console.ReadLine());

                for (int i = 1; i <= cantidadPares; i++) { 

                    Console.WriteLine($"Digita el {i}° valor de x");
                    x = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Digita el {i}° valor de y");
                    y = double.Parse(Console.ReadLine());

                    if (x > 0 && y > 0) { 
                        cuadrante1++;
                    }
                    else if (x < 0 && y > 0) { 
                        cuadrante2++;
                    }
                    else if (x < 0 && y < 0) { 
                        cuadrante3++;
                    }
                    else if (x > 0 && y < 0) { 
                        cuadrante4++;
                    }
                    else{
                        origen++;
                    }
                }
                Console.Title = "Presentación de resultados";
                Console.WriteLine("\nResultados:");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine($"Hay {cuadrante1} par(es) en el cuadrante 1." +
                    $"\nHay {cuadrante2} par(es) en el cuadrante 2." +
                    $"\nHay {cuadrante3} par(es) en el cuadrante 3." +
                    $"\nHay {cuadrante4} par(es) en el cuadrante 4." +
                    $"\nHay {origen} par(es) en el origen o puntos en el eje x o y.");
            }
            catch (FormatException){
                Console.WriteLine("El tipo de dato ingresado no es válido");
            }
            Console.ReadKey();
        }
    }
}
