using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            try
            {
                do
                {
                    Console.Clear();
                    Console.Title = "Menú";

                    Console.WriteLine("\t\t\t\t\t Menú");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[a] Dividir\t");
                    Console.Write("[b] Obtener cubo\t");
                    Console.Write("[c] Calculo de IMC\t");
                    Console.Write("[d] Salir\n\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Seleccione una opción");
                    opcion = Console.ReadLine().ToLower();
                    Console.Clear();

                    switch (opcion)
                    {
                        case "a":
                            Console.Title = "Dividir dos numeros";

                            double numeroUno, numeroDos;
                            Console.WriteLine("\t\t\tBienvenido a la función 'Dividir'\n");

                            Console.WriteLine("Digite el valor uno (dividendo)");
                            numeroUno = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digite el valor dos (divisor)");
                            numeroDos = double.Parse(Console.ReadLine());

                            Dividir(numeroUno, numeroDos);
                            Console.ReadKey();
                            break;

                        case "b":
                            Console.Title = "Cubo de un numero";

                            double numeroCubo;
                            Console.WriteLine("\t\t\tBienvenido a la función 'Obtener cubo'\n");

                            Console.WriteLine("Digita el número que quieres elevar al cubo");
                            numeroCubo = double.Parse(Console.ReadLine());

                            obtenerCubo(numeroCubo);
                            Console.ReadKey();
                            break;

                        case "c":
                            Console.Title = "Calculo de IMC";

                            double pesoPersona, alturaPersona;
                            Console.WriteLine("\t\t\tBienvenido al cálculo de IMC\n");

                            Console.WriteLine("Digita tu peso en kilogramos [kg]");
                            pesoPersona = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digita tu altura en metros [m]");
                            alturaPersona = double.Parse(Console.ReadLine());

                            calculoIMC(pesoPersona, alturaPersona);
                            Console.ReadKey();
                            break;

                        case "d":
                            Console.Title = "Salida";

                            Console.WriteLine("Gracias por usar el programa.");
                            Console.WriteLine("Presione una tecla para salir...");
                            break;

                        default:
                            Console.Title = "Not found";

                            Console.WriteLine("El valor que ingresaste no corresponde a ninguna opción");
                            Console.WriteLine("Presiona una tecla para continuar...");
                            Console.ReadKey();
                            break;
                    }
                }
                while (opcion != "d");
            }
            catch (FormatException)
            {
                Console.WriteLine("El tipo de dato ingresado no es válido");
            }
            Console.ReadKey();
        }

        static void Dividir(double num1, double num2)
        {
            double formula;

            formula = Math.Round((num1 / num2),2);
            Console.WriteLine($"El resultado de dividir {num1} entre {num2} es: {formula}");
        }

        static void obtenerCubo(double numero)
        {
            double formula;

            formula = Math.Round(Math.Pow(numero, 3));
            Console.WriteLine($"Al elevar {numero} al cubo tenemos como resultado {formula}");
        }

        static void calculoIMC(double peso, double altura)
        {
            double formula;

            formula = Math.Round(peso / (Math.Pow(altura, 2)),2);
            Console.WriteLine($"Tu IMC es de {formula}");
        }
    }
}
