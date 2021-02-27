using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            try
            {
                do
                {
                    double x, formula, y;

                    Console.Clear();

                    Console.Title = "Menú";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Menú:");
                    Console.WriteLine("a. Seno de x");
                    Console.WriteLine("b. Coseno de x");
                    Console.WriteLine("c. Tangente de x");
                    Console.WriteLine("d. Raiz cuadrada de x");
                    Console.WriteLine("e. Potencia de Y^x");
                    Console.WriteLine("f. Verifica si un número es par o impar");
                    Console.WriteLine("g. Salir del programa\n");

                    Console.WriteLine("Selecciona una opción...");
                    op = Console.ReadLine().ToLower();

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Clear();
                    switch (op)
                    {
                        case "a":
                            Console.Title = "Seno de x";

                            Console.WriteLine("Digita el valor de x");
                            x = double.Parse(Console.ReadLine());
                            formula = Math.Round(Math.Sin(x), 2);
                            Console.WriteLine($"El seno de {x} es: {formula}");
                            Console.WriteLine("Presiona una tecla para continuar...");
                            Console.ReadKey();
                            break;

                        case "b":
                            Console.Title = "Coseno de x";

                            Console.WriteLine("Digita el valor de x");
                            x = double.Parse(Console.ReadLine());
                            formula = Math.Round(Math.Cos(x), 2);
                            Console.WriteLine($"El coseno de {x} es: {formula}");
                            Console.WriteLine("Presiona una tecla para continuar...");
                            Console.ReadKey();
                            break;

                        case "c":
                            Console.Title = "Tangente de x";

                            Console.WriteLine("Digita el valor de x");
                            x = double.Parse(Console.ReadLine());
                            formula = Math.Round(Math.Tan(x), 2);
                            Console.WriteLine($"La tangente de {x} es: {formula}");
                            Console.WriteLine("Presiona una tecla para continuar...");
                            Console.ReadKey();
                            break;

                        case "d":
                            Console.Title = "Raiz de x";

                            Console.WriteLine("Digita el valor de x");
                            x = double.Parse(Console.ReadLine());
                            formula = Math.Round(Math.Sqrt(x), 2);
                            Console.WriteLine($"La raíz cuadrada de {x} es: {formula}");
                            Console.WriteLine("Presiona una tecla para continuar...");
                            Console.ReadKey();
                            break;

                        case "e":
                            Console.Title = "Y elevado a la x";

                            Console.WriteLine("Digita el valor de x");
                            x = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digita el valor de y");
                            y = double.Parse(Console.ReadLine());
                            formula = Math.Round(Math.Pow(y, x), 2);
                            Console.WriteLine($"Al elevar {y} a la {x} tenemos: {formula}");
                            Console.WriteLine("Presiona una tecla para continuar...");
                            Console.ReadKey();
                            break;

                        case "f":
                            Console.Title = "Numero par o impar";

                            Console.WriteLine("Digita el numero que desea comprobar si es par o impar");
                            x = double.Parse(Console.ReadLine());
                            if (x % 2 == 0)
                            {
                                Console.WriteLine($"El numero {x} es par");
                            }
                            else
                            {
                                Console.WriteLine($"El numero {x} es impar");
                            }
                            Console.WriteLine("Presiona una tecla para continuar...");
                            Console.ReadKey();
                            break;

                        case "g":
                            Console.WriteLine("Gracias por usar el programa");
                            Console.WriteLine("\nPresione una tecla para salir...");
                            Console.ReadKey();
                            break;

                        default:
                            Console.WriteLine("La letra no corresponde a ninguna opción");
                            Console.WriteLine("Presiona una tecla para continuar...");
                            Console.ReadKey();
                            break;
                    }
                }
                while (op != "g");
            }
            catch (FormatException)
            {
                Console.WriteLine("Tipo de dato ingresado no válido");
                Console.ReadKey();
            }
        }
    }
}
