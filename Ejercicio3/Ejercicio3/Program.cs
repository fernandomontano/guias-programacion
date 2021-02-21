using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int cantidadTriangulos;
                double lado1, lado2, lado3;

                //Contadores
                int trianguloEquilatero = 0, trianguloIsósceles = 0, trianguloEscaleno = 0;

                Console.Title = "Solicitud de datos";
                Console.WriteLine("Introduce la cantidad de triángulos que desea construir");
                cantidadTriangulos = int.Parse(Console.ReadLine());

                for (int i = 1; i <= cantidadTriangulos; i++)
                {
                    Console.WriteLine($"\nDigita el lado 1 del triángulo {i}");
                    lado1 = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Digita el lado 2 del triángulo {i}");
                    lado2 = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Digita el lado 3 del triángulo {i}");
                    lado3 = double.Parse(Console.ReadLine());

                    if (lado1 == lado2 && lado2 == lado3)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;

                        trianguloEquilatero++;
                        Console.WriteLine("Este triángulo es equilátero");

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                    {
                        trianguloIsósceles++;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        
                        Console.WriteLine("Este triángulo es isósceles");

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;

                        trianguloEscaleno++;
                        Console.WriteLine("Este triángulo es escaleno");

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.Title = "Presentación de resultados";
                Console.WriteLine($"Hay {trianguloEquilatero} triangulo(s) equilateros." +
                    $"\nHay {trianguloEscaleno} triangulo(s) escalenos" +
                    $"\nHay {trianguloIsósceles} triangulo(s) isósceles." +
                    $"\n");

                if (trianguloEquilatero > trianguloIsósceles && trianguloIsósceles >= trianguloEscaleno)
                {
                    Console.WriteLine($"El tipo de triángulo equilátero tiene {trianguloEquilatero} triángulos, y es el que más triángulos tiene.");
                }
                else if (trianguloEquilatero > trianguloEscaleno && trianguloEscaleno >= trianguloIsósceles) 
                {
                    Console.WriteLine($"El tipo de triángulo equilátero tiene {trianguloEquilatero} triángulos, y es el que más triángulos tiene.");
                }
                else if (trianguloIsósceles > trianguloEquilatero && trianguloEquilatero >= trianguloEscaleno)
                {
                    Console.WriteLine($"El tipo de triángulo isósceles tiene {trianguloIsósceles} triángulos, y es el que más triángulos tiene.");
                }
                else if (trianguloIsósceles > trianguloEscaleno && trianguloEscaleno >= trianguloEquilatero)
                {
                    Console.WriteLine($"El tipo de triángulo isósceles tiene {trianguloIsósceles} triángulos, y es el que más triángulos tiene.");
                }
                else if (trianguloEscaleno > trianguloEquilatero && trianguloEquilatero >= trianguloIsósceles)
                {
                    Console.WriteLine($"El tipo de triángulo escaleno tiene {trianguloEscaleno} triángulos, y es el que más triángulos tiene.");
                }
                else if (trianguloEscaleno > trianguloIsósceles && trianguloIsósceles >= trianguloEquilatero)
                {
                    Console.WriteLine($"El tipo de triángulo escaleno tiene {trianguloEscaleno} triángulos, y es el que más triángulos tiene.");
                }
                else
                {
                    Console.WriteLine("La categoría de triángulos que tiene mayor cantidad es igual a otra categoría.");
                }
            }
            catch (FormatException){
                Console.WriteLine("El tipo de dato que ingresó no es válido");
            }
            Console.ReadKey();
        }
    }
}
