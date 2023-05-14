using System;

namespace ConversionUnidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al convertidor de unidades");
            Console.WriteLine("1. Millas a kilómetros");
            Console.WriteLine("2. Grados Celsius a Fahrenheit");
            Console.WriteLine("3. Libras a kilogramos");
            Console.WriteLine("4. Salir del programa");
            Console.Write("Seleccione la unidad de medida que desea convertir:\t");
            Console.WriteLine(" " );
            int opcion = int.Parse(Console.ReadLine());

            while (opcion != 4)
            {
                try
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese el valor en millas:\t");
                            double millas = double.Parse(Console.ReadLine());
                            Console.WriteLine(" ");
                            double kilometros = millas * 1.60934;
                            Console.WriteLine("{0} millas son {1} kilómetros.", millas, kilometros);
                            Console.WriteLine(" ");
                            break;
                        case 2:
                            Console.Write("Ingrese el valor en grados Celsius:\t");
                            double celsius = double.Parse(Console.ReadLine());
                            Console.WriteLine(" ");
                            double fahrenheit = (celsius * 1.8) + 32;
                            Console.WriteLine("{0} grados Celsius son {1} grados Fahrenheit.", celsius, fahrenheit);
                            Console.WriteLine(" ");
                            break;
                        case 3:
                            Console.Write("Ingrese el valor en libras:\t");
                            double libras = double.Parse(Console.ReadLine());
                            Console.WriteLine(" ");
                            double kilogramos = libras * 0.453592;
                            Console.WriteLine("{0} libras son {1} kilogramos.", libras, kilogramos);
                            Console.WriteLine(" ");
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada no válida. Intente de nuevo.");
                }
                Console.WriteLine("1. Millas a kilómetros");
                Console.WriteLine("2. Grados Celsius a Fahrenheit");
                Console.WriteLine("3. Libras a kilogramos");
                Console.WriteLine("4. Salir del programa");
                Console.WriteLine("Seleccione la unidad de medida que desea convertir:");
                Console.WriteLine(" ");
                opcion = int.Parse(Console.ReadLine());
            }
        }
    }
}


