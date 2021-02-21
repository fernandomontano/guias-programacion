using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 

                int tabla, producto;

                Console.Title = ("Solicitud de datos");

                Console.WriteLine("Introduzca el numero del que desea la tabla");
                tabla = int.Parse(Console.ReadLine());

                Console.Title = ("Presentación de resultados");
                for (int i = 1; i <= 10; i++) { 
                 
                    producto = tabla * i;
                    Console.WriteLine($"{tabla} * {i} = {producto}");
                }
            }
            catch (FormatException) {

                Console.WriteLine("El tipo de dato que se ingreso no es válido");
            }
            Console.ReadKey();
        }
    }
}
