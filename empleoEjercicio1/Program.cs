using System;

namespace empleoEjercicio1{
    class Program{

        static void Main(string[] args){
            try {
                //Título de la consola
                Console.Title = "Respuestas correctas";

                //Descripción del programa
                Console.WriteLine("Este programa calculará el porcentaje de respuestas correctas");

                //Declaración de variables
                double preguntasTotal, preguntasCorrectas, porcentaje;

                //Solicitud de datos
                Console.WriteLine("Ingresa la cantidad de preguntas que se realizaron");
                preguntasTotal = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa la cantidad de preguntas que se se contestaron correctamente");
                preguntasCorrectas = double.Parse(Console.ReadLine());

                //Validación de datos

                while (preguntasTotal < 0) { 
                    Console.WriteLine("Numero de preguntas inválido, escribalo de nuevo");
                    preguntasTotal = double.Parse(Console.ReadLine());
                }

                while (preguntasCorrectas < 0) { 
                    Console.WriteLine("Numero de preguntas correctas inválido, escribalo de nuevo");
                    preguntasCorrectas = double.Parse(Console.ReadLine());
                }

                while (preguntasCorrectas > preguntasTotal) { 
                    Console.WriteLine("No es posible que las preguntas correctas sean mayores a las preguntas totales");

                    Console.WriteLine("Ingresa la cantidad de preguntas que se realizaron");
                    preguntasTotal = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresa la cantidad de preguntas que se se contestaron correctamente");
                    preguntasCorrectas = double.Parse(Console.ReadLine());
                }

                //Creación de fórmulas
                porcentaje = (preguntasCorrectas / preguntasTotal)*100;

                //Declaración de rango en el que se encuentra
                if (porcentaje >= 90) { 
                    Console.WriteLine($"Tu porcentaje es de acierto es {porcentaje}% y te encuentras en nivel máximo");
                }

                else if (porcentaje >= 75 && porcentaje < 90) { 
                    Console.WriteLine($"Tu porcentaje es de acierto es {porcentaje}% y te encuentras en nivel medio");
                }

                else if (porcentaje >= 50 && porcentaje < 75) { 
                    Console.WriteLine($"Tu porcentaje es de acierto es {porcentaje}% y te encuentras en nivel regular");
                }

                else { 
                    Console.WriteLine($"Tu porcentaje es de acierto es {porcentaje}% y te encuentras fuera de nivel");
                }
            }

            catch (FormatException) { 
                Console.WriteLine("Dato ingresado no válido");
            }
            Console.ReadKey();
        }
    }
}
